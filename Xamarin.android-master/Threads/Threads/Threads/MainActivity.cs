using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Control;
using Java.Net;
using Java.IO;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
	[Activity (Label = "Threads", MainLauncher = true)]
	public class MainActivity : Activity
	{
		int count = 1;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it

			//JAVA THREAD
			ProgressCircleView  pv_Porcentaje_uno= FindViewById<ProgressCircleView> (Resource.Id.pv_Porcentaje_uno);
			Button btnJavaThread= FindViewById<Button> (Resource.Id.btnJavaThread);
			btnJavaThread.Click += delegate {
				LLama_JavaThread(pv_Porcentaje_uno,"http://www.sullenclothing.com/Porcelain_18x24_Giclee.jpg");
			};

			//SYSTEM.THREAD
			ProgressCircleView  pv_Porcentaje_dos= FindViewById<ProgressCircleView> (Resource.Id.pv_Porcentaje_dos);
			Button btnThread= FindViewById<Button> (Resource.Id.btnThread);
			btnThread.Click += delegate {
				LLama_SystemThread(pv_Porcentaje_dos,"http://www.sullenclothing.com/HeadHunter_18x24_Giclee.jpg");
			};

			//TASK PARALLEL LIBRARY
			ProgressCircleView  pv_Porcentaje_tres= FindViewById<ProgressCircleView> (Resource.Id.pv_Porcentaje_tres);
			Button btnTaskParallelLibrary= FindViewById<Button> (Resource.Id.btnTaskParallelLibrary);
			btnTaskParallelLibrary.Click += delegate {
				LLama_TaskParallelLibrary(pv_Porcentaje_tres,"http://www.sullenclothing.com/ConfilctedBlk_18x24_Giclee.jpg");
			};

			//ASYNCTASK
			Button btnAsyncTask= FindViewById<Button> (Resource.Id.btnAsyncTask);
			btnAsyncTask.Click += delegate {
				LLama_Asynctask("http://www.sullenclothing.com/Gustavo_14x11_Giclee.jpg");
			};

		}

		//JAVA THREAD METODOS
		void LLama_JavaThread (ProgressCircleView  tem_pcv, string url_archivo)
		{
			new Java.Lang.Thread(() =>
			 {
				DescargaArchivo(tem_pcv,url_archivo);

			}).Start();
		}

		//SYSTEM.THREAD
		void LLama_SystemThread (ProgressCircleView  tem_pcv, string url_archivo)
		{
			new Thread(new ThreadStart(() =>
			                           {
				DescargaArchivo(tem_pcv,url_archivo);

			})).Start();
		}

		//TASK PARALLEL LIBRARY
		void LLama_TaskParallelLibrary(ProgressCircleView  tem_pcv, string url_archivo)
		{
			Task.Factory.StartNew(() =>{
				DescargaArchivo(tem_pcv,url_archivo);
			})
				.ContinueWith(task =>RunOnUiThread(() =>tem_pcv.setPorcentaje(100)));
		}


		//ASYNCTASK
		void LLama_Asynctask( string url_archivo)
		{
			new AsyncDownloadFile(this).Execute(url_archivo);
		}

		//CLASE QUE HERADA DE ASYNCTASK
		public class AsyncDownloadFile : AsyncTask
		{
			private Context _context;
			private ProgressDialog _progressDialog;

			//CONSTRUCTOR DE LA CLASE
			public AsyncDownloadFile(Context context)
			{
				_context = context;
			}

			//METODO QUE SE EJECUTA PREVIAMENTE ANTES DE SU EJECUCION, ES MUY COMUN USADO PARA INICIALIZAR VARIABLES
			//O OTRO TIPO DE ELEMENTOS QUE SE NECESITEN
			protected override void OnPreExecute()
			{
				base.OnPreExecute();
				//INICIALIZAMOS UN PROGRESSDIALOG
				_progressDialog = ProgressDialog.Show(_context, "Descarga en progreso", "Espere por favor... =p");
			}

			protected override Java.Lang.Object DoInBackground (params Java.Lang.Object[] @params)
			{
				//REALIZAMOS EL PROCESO DE DESCARGA DEL ARCHIVO
				try{

					string filePath = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures).AbsolutePath+"/DescargaImagen/" ;
					Java.IO.File directory = new Java.IO.File (filePath);
					if(directory.Exists() ==false)
					{
						directory.Mkdir();
					}

					//RECUPERAMOS LA DIRECCION DEL ARCHIVO QUE DESEAMOS DESCARGAR
					string url_link = @params [0].ToString ();
					URL url = new URL(url_link);
					URLConnection conexion = url.OpenConnection();
					conexion.Connect ();

					int lenghtOfFile = conexion.ContentLength;
					InputStream input = new BufferedInputStream(url.OpenStream());

					string NewImageFile = directory.AbsolutePath+ "/"+ url_link.Substring (url_link.LastIndexOf ("/") + 1);
					OutputStream output = new FileOutputStream(NewImageFile);
					byte[] data= new byte[lenghtOfFile];


					int count;
					while ((count = input.Read(data)) != -1) 
					{
						output.Write(data, 0, count);
					}
					output.Flush();
					output.Close();
					input.Close();
					return true;

				}catch {
					return  false;
				}

			}

			protected override void OnPostExecute(Java.Lang.Object result)
			{
				//UNA VEZ QUE EL PROCESO CONCLUYO, REVISAMOS SI SE DESCARGO EXITOSAMENTE EL ARCHIVO
				base.OnPostExecute(result);
				_progressDialog.Hide ();
				Boolean SeDescargo = (Boolean)result;

				if (SeDescargo) { 
					new AlertDialog.Builder (_context)
						.SetTitle ("Aviso")
							.SetMessage ("Se descargo exitosamente! =)")
							.Show ();

				} else {

					new AlertDialog.Builder(_context)
						.SetTitle("Error")
							.SetMessage("Error al descargar el arhivo! =(")
							.Show();

				}

			}

		}

		//***************************************************************************************************
		//******************FUNCION  QUE SE ENCARGA DEL PROCESO DE DESCARGA DE ARCHIVO***********************
		//***************************************************************************************************
		void DescargaArchivo(ProgressCircleView  tem_pcv, string url_archivo)
		{
			//OBTENEMOS LA RUTA DONDE SE ENCUENTRA LA CARPETA PICTURES DE NUESTRO DISPOSITIVO Y LE CONCTENAMOS 
			//EL NOMBRE DE UNA CARPETA NUEVA CARPETA, ES AQUI DONDE GUADAREMOS EL ARCHIVO A DESCARGAR
			string filePath = Android.OS.Environment.GetExternalStoragePublicDirectory(Android.OS.Environment.DirectoryPictures).AbsolutePath+"/DescargaImagen/" ;
			Java.IO.File directory = new Java.IO.File (filePath);

			//VERIFICAMOS SI LA CARPETA EXISTE, SI NO LA CREAMOS
			if(directory.Exists() ==false)
			{
				directory.Mkdir();
			}

			//ESTABLECEMOS LA UBICACION DE NUESTRO ARCHIVO A DESCARGAR
			URL url = new URL(url_archivo);

			//CABRIMOS UNA CONEXION CON EL ARCHIVO
			URLConnection conexion = url.OpenConnection();
			conexion.Connect ();

			//OBTENEMOS EL TAMAÑO DEL ARCHIVO A DESCARGAR
			int lenghtOfFile = conexion.ContentLength;

			//CREAMOS UN INPUTSTREAM PARA PODER EXTRAER EL ARCHIVO DE LA CONEXION
			InputStream input = new BufferedInputStream(url.OpenStream());

			//ASIGNAMOS LA RUTA DONDE SE GUARDARA EL ARCHIVO, Y ASIGNAMOS EL NOMBRE CON EL QUE SE DESCARGAR EL ARCHIVO
			//PARA ESTE CASO CONSERVA EL MISMO NOMBRE
			string NewFile = directory.AbsolutePath+ "/"+ url_archivo.Substring (url_archivo.LastIndexOf ("/") + 1);

			//CREAMOS UN OUTPUTSTREAM EN EL CUAL UTILIZAREMOS PARA CREAR EL ARCHIVO QUE ESTAMOS DESCARGANDO
			OutputStream output = new FileOutputStream(NewFile);
			byte[] data= new byte[lenghtOfFile];
			long total = 0;

			int count;
			//COMENSAMOS A LEER LOS DATOS DE NUESTRO INPUTSTREAM
			while ((count = input.Read(data)) != -1) 
			{
				total += count;
				//CON ESTA OPCION REPORTAMOS EL PROGRESO DE LA DESCARGA EN PORCENTAJE A NUESTRO CONTROL
				//QUE SE ENCUENTRA EN EL HILO PRINCIPAL
				RunOnUiThread(() => tem_pcv.setPorcentaje ((int)((total*100)/lenghtOfFile)));

				//ESCRIBIMOS LOS DATOS DELIDOS ES NUESTRO OUTPUTSTREAM
				output.Write(data, 0, count);

			}
			output.Flush();
			output.Close();
			input.Close();

			//INDICAMOS A NUESTRO PROGRESS QUE SE HA COMPLETADO LA DESCARGA AL 100%
			RunOnUiThread(() => tem_pcv.setPorcentaje (100));

		}

	}
}


