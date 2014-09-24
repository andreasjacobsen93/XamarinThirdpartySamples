using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Database.Sqlite;
using System.Threading.Tasks;
using Android.Text;
using Android.Util;

namespace MySearchView
{
	public class Manejador_db
	{


		#region Seccion manejador de la BD.
		//Definimos las llaves que nos serviran para hacer la busquedad, estan ya estan definidas por default 
		//dentro de la clase SearchManager, las cuales utilizaremos como campos de nuestra tabla virtual en la base de datos
		public static readonly String KEY_PAIS = Android.App.SearchManager.SuggestColumnText1;
		public static readonly String KEY_CONTINENTE = Android.App.SearchManager.SuggestColumnText2;


		//Variable que nos ayudara para crear el mapeo del contenido de la tabla y realizar la busquedad mas sensillo
		static Dictionary<string, string> MapColumnas = CrearMapaColumnas ();
		static Dictionary<string, string> CrearMapaColumnas ()
		{
			Dictionary<string, string> map = new Dictionary<string, string> ();
			map.Add (KEY_PAIS, KEY_PAIS);
			map.Add (KEY_CONTINENTE, KEY_CONTINENTE);
			map.Add (Android.Provider.BaseColumns.Id, "rowid AS " +		Android.Provider.BaseColumns.Id);
			map.Add (SearchManager.SuggestColumnIntentDataId, "rowid AS " +	SearchManager.SuggestColumnIntentDataId);
			return map;
		}

		//Varible de la clase BaseDatosOpenHelper, para hacersar a la informacion desde el manejador
		BaseDatosOpenHelper dasedatosOpenHelper;


		/// <summary>
		/// Constructor de la clase
		/// </summary>
		/// <param name="context">Context.</param>
		public Manejador_db (Context context)
		{
			dasedatosOpenHelper = new BaseDatosOpenHelper (context);
		}


		// Regresa un pais en especifico de acuerdo al rowid 
		public Android.Database.ICursor RegresaPais (String rowId, String[] columns)
		{
			String selection = "rowid = ?";
			String[] selectionArgs = new String[] { rowId };
			return EjecutaSentencia (selection, selectionArgs, columns);
		}

		// Regresa los paises que contengan la letra o letras colocadas en el search view.
		public Android.Database.ICursor RegresaPaisesSemejantes(String query, String[] columns)
		{
			String selection = KEY_PAIS + " MATCH ?";
			String[] selectionArgs = new String[] { query + "*" };
			return EjecutaSentencia (selection, selectionArgs, columns);
		}


		/// Ejecutas las sentencias de busquedad deacuerdo a los parametros que le hayan pasado.
		Android.Database.ICursor EjecutaSentencia (String selection, String[] selectionArgs, String[] columns)
		{
			//creamos un querybuilder
			var builder = new SQLiteQueryBuilder ();
			//le asignamos el nombre de la tabla va utilizar para ejecutar las sentencias
			builder.Tables = FTS_VIRTUAL_TABLE;
			//Asignamos el esquema de mapeo de columnas que utilizara nuestro query builder para ejecutar la sentencias
			builder.SetProjectionMap (MapColumnas);

			//Ejecutamos la sentencia y le pasamos los argumentos necesarios para ejecutarla
			var cursor = builder.Query (dasedatosOpenHelper.ReadableDatabase,
				columns, selection, selectionArgs, null, null, null);

			//verificamos que nuestro cursor tenga informacion
			if (cursor == null) {
				return null;
			} else if (!cursor.MoveToFirst ()) {
				cursor.Close ();
				return null;
			}
			return cursor;
		}




		#endregion




		#region Clase para crear la base de datos

		//nombre de la base de datos
		static String DATABASE_NAME = "dbPaises";
		//nombre de la tabla virtual
		static String FTS_VIRTUAL_TABLE = "FTSPaises";
		//version de la  base de datos
		static int DATABASE_VERSION = 1;


		///Clase utilizada para generar la tabla virtual para poder realizar la busquedad de los paises(sugerencias) para nuestro search view
		class BaseDatosOpenHelper : SQLiteOpenHelper
		{

			//Definimos las variables a utilizar, asi como la sentencia para crear la tabla que contendra los paises en la base de datos
			Context helperContext;
			SQLiteDatabase database;
			static String FTS_TABLE_CREATE =
				"CREATE VIRTUAL TABLE " + FTS_VIRTUAL_TABLE +
				" USING fts3 (" +
				KEY_PAIS + ", " +
				KEY_CONTINENTE + ");";

			//Tag utilzado para identificar las acciones en el log
			static String TAG = "BaseDatosOpenHelper";


			/// <summary>
			/// Initializes a new instance of the <see cref="SearchableDictionary.DictionaryDatabase+DictionaryOpenHelper"/> class.
			/// </summary>
			/// <param name="context">Context.</param>
			public BaseDatosOpenHelper (Context context): base(context, DATABASE_NAME, null, DATABASE_VERSION)
			{
				helperContext = context;
			}

			/// <param name="db">The database.</param>
			/// <summary>
			/// Este evento se llama cuando se crea por primera vez.
			/// Ademas ejecuta las sentencias necesarias para construir la tablas de la base de datos
			/// </summary>
			public override async void OnCreate (SQLiteDatabase db)
			{
				database = db;
				//Crea la tabla ejecutando el query
				database.ExecSQL (FTS_TABLE_CREATE);
				//Manda llamar un metodo para cargar los paises 
				await LLamaCargaDatosAsync ();
			}


			//Funcion que generar una tarea para cargar asincronamente los paises en la tabla de la base de datos
			async Task LLamaCargaDatosAsync ()
			{
				await CargaPaisesAsync ();
			}

			/// <summary>
			/// Carga las palabras y su definicion de forma asincrona y verifica que no haya ningun problema
			/// </summary>
			/// <returns>The words async.</returns>
			async Task CargaPaisesAsync ()
			{


				//Obtiene el recursos desde la tarea asincrona para poder abrir un input stream 
				//y leer el archivo de recurso alojado en la carpeta raw
				var resources = helperContext.Resources;
				var inputStream = resources.OpenRawResource (Resource.Raw.paises);

				using (var reader = new System.IO.StreamReader(inputStream)) {

					try {
						String line;
						//ciclo que lee una linea del archivo
						while ((line = await reader.ReadLineAsync ()) != null) {
							//Hace un split de la linea usando como separador el carcter "@"
							String[] strings = TextUtils.Split (line, "@");
							//verifica que tenga dos elementos la linea(la palabra y su definicion)
							if (strings.Length < 2) 
								continue;
							//invoca al metodo para guardar la palabra y su definicion en la tabla
							long id = AddPais(strings [0].Trim (), strings [1].Trim ());
							if (id < 0) 
							{
								Log.Error (TAG, "unable to add word: " + strings [0].Trim ());
							}
						}
					} finally {
						reader.Close ();
					}
				}

				Log.Debug (TAG, "DONE loading words.");
			}

			/// <summary>
			/// Insertamos el pais y su continente dentro de la tabla virtual
			/// </summary>
			/// <returns>The word.</returns>
			/// <param name="word">Word.</param>
			/// <param name="definition">Definition.</param>
			public long AddPais (String pais, String continente)
			{
				var initialValues = new ContentValues ();
				initialValues.Put (KEY_PAIS, pais);
				initialValues.Put (KEY_CONTINENTE, continente);

				return database.Insert (FTS_VIRTUAL_TABLE, null, initialValues);
			}

			/// <param name="db">The database.</param>
			/// <param name="oldVersion">The old database version.</param>
			/// <param name="newVersion">The new database version.</param>
			/// <summary>
			/// Called when the database needs to be upgraded.
			/// </summary>
			public override void OnUpgrade (SQLiteDatabase db, int oldVersion, int newVersion)
			{
				Log.Warn (TAG, "Actulizando la version de la base de datos " + oldVersion + " a la "	+ newVersion + ", los datos de la version anterior seran borrados.");
				db.ExecSQL ("DROP TABLE IF EXISTS " + FTS_VIRTUAL_TABLE);
				OnCreate (db);
			}




		}


		#endregion
	}
}

