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

namespace MySearchView
{
	/// Registramos nuestro Content provider en nuestro androidmanifest desde la clase, ya que una 
	/// vez instalada la aplicación en el dispositivo Android conozca la existencia de dicho recurso.
	[ContentProvider(new string[]{"mysearchview.cpProveedorDatos"})]
	public class cpProveedorDatos: ContentProvider
	{

		#region Variables Del Proveedor

		//Definimos el identificador en sí del content provider
		public static readonly String AUTHORITY = "mysearchview.cpProveedorDatos";

		//Definimos URI con la que se accederá a nuestro content provider
		public static readonly Android.Net.Uri CONTENT_URI = Android.Net.Uri.Parse ("content://" + AUTHORITY + "/paises");

		//Definimos los  dos tipos MIME distintos para cada entidad del content provider
		public static readonly String PAIS_MIME_TYPE = ContentResolver.CursorDirBaseType + "/vnd.MySearchView.MySearchView";
		public static readonly String CONTINENTE_MIME_TYPE = ContentResolver.CursorItemBaseType + "/vnd.MySearchView.MySearchView";


		//Definimos la variable que utilizaremos para poder hacer realizar la busqueda de las coincidencia dentro de la base de datos
		Manejador_db Manejador;

		// Identificadores unicos que usaremos para definir nuestras URI para determinar que acciones realizara nuestro
		//contenprovider
		const int BUSCAR_PALABRAS = 0;
		const int RECUPERAR_PALABRA = 1;
		const int BUSCAR_SUJERENCIAS = 2;

		//Definimos una variable uriMatcher la que nos facilitara la interpretacion determinados patrones en una URI
		static UriMatcher uriMatcher = ConstructorUriMatcher ();

		/// Metodo que nos genera la URI a utilizar y las almacena en un URIMatcher
		static UriMatcher ConstructorUriMatcher ()
		{
			var matcher = new UriMatcher (UriMatcher.NoMatch);

			//definimos los URI para poder accesar a la informacion apra realizar la busquedad o buscar una palabra en especifico
			// to get definitions...
			matcher.AddURI (AUTHORITY, "paises", BUSCAR_PALABRAS);
			matcher.AddURI (AUTHORITY, "paises/#", RECUPERAR_PALABRA);

			// to get suggestions...
			matcher.AddURI (AUTHORITY, SearchManager.SuggestUriPathQuery, BUSCAR_SUJERENCIAS);
			matcher.AddURI (AUTHORITY, SearchManager.SuggestUriPathQuery + "/*", BUSCAR_SUJERENCIAS);

			return matcher;
		}


		#endregion

		#region Metodos ContentProvider

		//Definimos el evento oncreate
		public override bool OnCreate ()
		{
			//Inicializamos la vriable  de tipo Manejador_db para poder accesar a los datos de los paises
			Manejador = new Manejador_db (Context);
			return true;
		}


		/// Nos permite ejecutar una sentencia de acuerdo a la Uri y a los parametros asignados.
		/// ya sea buscar paises, sugerencias de paises o una pais en especifico
		public override Android.Database.ICursor Query (Android.Net.Uri uri, string[] projection, string selection, string[] selectionArgs, string sortOrder)
		{
			switch (uriMatcher.Match (uri)) {
			//Regresa todas las coincidencias de los nombre de los paises que pertenescan a la palabra que esta buscando
			case BUSCAR_SUJERENCIAS:
				if (selectionArgs == null) {
					throw new Java.Lang.IllegalArgumentException (
						"No hay argumentos para la siguiente Uri: " + uri);
				}
				return BuscarSugerencias (selectionArgs [0]);



				//Regresa los nombre de los paises que coincidan con los parametros
			case BUSCAR_PALABRAS:
				if (selectionArgs == null) {
					throw new Java.Lang.IllegalArgumentException (
						"No hay argumentos para la siguiente Uri: " + uri);
				}
				return Buscar (selectionArgs [0]);


				//Regresa un pais especifico deacuerdo al _id a buscar
			case RECUPERAR_PALABRA:
				return RecuperarPais(uri);

			default:
				throw new Java.Lang.IllegalArgumentException ("Uri desconocida: " + uri);
			}

		}

		//Regresan las sugerencias de paises de acuerdo en ICursor, ademas de regresar el id del registro
		Android.Database.ICursor BuscarSugerencias (String query)
		{
			query = query.ToLower ();
			//definimos las columnas que implementaremos para el mapeo de nuestra tabla

			String[] columns = new String[] {
				Android.Provider.BaseColumns.Id,
				Manejador_db.KEY_PAIS,
				Manejador_db.KEY_CONTINENTE,
				SearchManager.SuggestColumnIntentDataId
			};

			//invocamor el metodo para relizar la busqueda de las palabras que coincidan
			return Manejador.RegresaPaisesSemejantes (query, columns);
		}

		//Regresa los paises sin su id, solamente la informacion 
		Android.Database.ICursor Buscar (String query)
		{
			query = query.ToLower ();
			String[] columns = new String[] {
				Android.Provider.BaseColumns.Id,
				Manejador_db.KEY_PAIS,
				Manejador_db.KEY_CONTINENTE
			};

			return Manejador.RegresaPaisesSemejantes (query, columns);
		}

		//Regresa una pais en especifico buscada por su id
		Android.Database.ICursor RecuperarPais (Android.Net.Uri uri)
		{
			//obtenemos el _ID del pais a buscar que se encuentra el nuestra Uri
			String rowId = uri.LastPathSegment;
			//definimos las columnas que implementaremos para el mapeo de nuestra tabla
			String[] columns = new String[] {
				Manejador_db.KEY_PAIS,
				Manejador_db.KEY_CONTINENTE
			};

			return Manejador.RegresaPais (rowId, columns);
		}


		/// <param name="uri">the URI to query.</param>
		/// <summary>
		/// Regresa los tipos de datos que estamos implementando
		///  given URI.
		/// </summary>
		/// <returns>To be added.</returns>
		public override String GetType (Android.Net.Uri uri)
		{
			switch (uriMatcher.Match (uri)) {
			case BUSCAR_PALABRAS:
				return PAIS_MIME_TYPE;
			case RECUPERAR_PALABRA:
				return CONTINENTE_MIME_TYPE;
			case BUSCAR_SUJERENCIAS:
				return SearchManager.SuggestMimeType;

			default:
				throw new Java.Lang.IllegalArgumentException ("Uri desconocida: " + uri);
			}
		}


		/// <param name="uri">The full URI to query, including a row ID (if a specific record is requested).</param>
		/// <param name="selection">An optional restriction to apply to rows when deleting.</param>
		/// <param name="selectionArgs">To be added.</param>
		/// <summary>
		/// Implement this to handle requests to delete one or more rows.
		/// </summary>
		/// <returns>To be added.</returns>
		public override int Delete (Android.Net.Uri uri, string selection, string[] selectionArgs)
		{
			throw new Java.Lang.UnsupportedOperationException ();
		}
		/// <summary>
		/// Insert the specified uri and values.
		/// </summary>
		/// <param name="uri">URI.</param>
		/// <param name="values">Values.</param>
		public override Android.Net.Uri Insert (Android.Net.Uri uri, ContentValues values)
		{
			throw new Java.Lang.UnsupportedOperationException ();
		}
		/// <param name="uri">The URI to query. This can potentially have a record ID if this
		///  is an update request for a specific record.</param>
		/// <summary>
		/// Update the specified uri, values, selection and selectionArgs.
		/// </summary>
		/// <param name="values">Values.</param>
		/// <param name="selection">Selection.</param>
		/// <param name="selectionArgs">Selection arguments.</param>
		public override int Update (Android.Net.Uri uri, ContentValues values, string selection, string[] selectionArgs)
		{
			throw new Java.Lang.UnsupportedOperationException ();
		}


		#endregion





	}
}

