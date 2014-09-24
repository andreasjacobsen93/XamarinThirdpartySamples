using System;
using System.IO;
using Android.App;
using Android.Hardware;
using Android.Widget;
using Android.OS;
using Android.Media;
using Environment = Android.OS.Environment;
using File = Java.IO.File;
using Android.Content.PM;


namespace Guardar_Video
{
	[Activity (Label = "Guardar_Video", MainLauncher = true, ScreenOrientation = ScreenOrientation.Portrait)]
	public class MainActivity : Activity
	{

		//NUESTRAS VARIABLES GLOBALES DE NUESTRA APLICACION
		MediaRecorder _mediaRecorder;
		Camera _camera;
		private VideoView _videoView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//INICIALIZAMOS NUESTRAS VISTAS PARA PODER UTILIZARLAS
			//BOTON GRABAR(RECORD)
			var recordButton = FindViewById<Button>(Resource.Id.Record);
			//BOTON STOP
			var stopButton = FindViewById<Button>(Resource.Id.Stop);
			//VISTA DONDE VEMOS LO QUE ESTAMOS GRABANDO
			_videoView = FindViewById<VideoView>(Resource.Id.SampleVideoView);


			recordButton.Click += delegate
			{
				//INVOCAMNOS EL METODO QUE PREPARA NUESTRA CAMARA Y MEDIA RECORD PARA COMENZAR A GRABAR
				if (PrepararVideoRecorder())
					//COMOENZAMOS LA GRABACION DE NUESTRO VIDEO
					_mediaRecorder.Start();
				else
					//LIBERAMOS LOS RECURSOS DE NUESTRO MEDIA RECORD
					LiberarMediaRecorder();

			};

			stopButton.Click += delegate
			{
				//DETEMOS NUESTRA GRABACION
				_mediaRecorder.Stop();
				//LIBERAMOS LOS RECURSOS DE NUESTRA MEDIA RECORD
				LiberarMediaRecorder();
				//CERRAMOS NUESTRA CAMARA PARA EVITAR QUE OTROS PROCESOS PUEDAN ACCEDER A EL.
				_camera.Lock();
			};



		}
		//OBTENEMOS LA INSTANCIA DE NUESTRA CAMARA DEPENDIENDO DE LA VERSION
		public static Camera ObtenerInstanciaCamara()
		{
			try
			{
				var buildInt = (int) Build.VERSION.SdkInt;
				//INSTANCIAMOS NUESTRA CAMARA DEPENDIENDO DE LA VERSION
				//AL USAR  Camera.Open(0) USAMOS LA CAMARA PRINCIPAL DE NUESTRO DISPOSITIVO ESTO
				//SIEMPRE CUANDO NUESTRO DISPOSITIVO TENGA MAS DE DOS CAMARAS
				return buildInt >= 9 ? Camera.Open(0) : Camera.Open();
			}catch{
				return null; 
			}
		}


		//REGRESA LA DIRECCION DE NUESTRO ARCHIVO DE VIDEO
		private static string PathArchivoVideo()
		{
			//CREAMOS UNA CARPETA DONDE GUARDAREMOS NUESTROS VIDEOS DENTRO DE LA CARPETA PICTURES DE NUESTRO DISPOSITIVO
			var mediaStorageDir = new File(Environment.GetExternalStoragePublicDirectory(Environment.DirectoryPictures), "MisVideosPersonales");
			if (!mediaStorageDir.Exists())
			{
				if (!mediaStorageDir.Mkdirs()) return null;
			}
			//REGRESAMOS EL PATH DE NUESTRO NUEVO ARCHIVO DE VIDEO CON UN NOMBRE UNICO DEFINIDO POR NUESTRA VARIABLE GUID, 
			//PARA EVITAR QUE SE REPITAN
			return Path.Combine(mediaStorageDir.Path, String.Format("video_{0}.mp4", Guid.NewGuid()));
		}

		//PREPARAMOS NUESTRO MEDIA RECORD Y CAMARA
		private bool PrepararVideoRecorder()
		{
			//OBTENEMOS LA INSTANCIA DE NUESTRA CAMARA YA PREPARADA
			_camera = ObtenerInstanciaCamara();
			//INICIALIZAMOS NUESTRA VARIABLE MEDIARECORDER
			_mediaRecorder = new MediaRecorder();

			//LE INDICAMOS A NUESTRA CAMARA QUE CAMBIE DE ROTACION ESTO ES DEVIDO QUE POR DEFUALT NOS MUESTRA EN POSICION HORIZONTAL,
			//Y COMO DEFINIMOS QUE LA POSICION DE NUESTRA APP SEA Portrait, REALIZAMOS EL CAMBIO.
			_camera.SetDisplayOrientation (90);
			//ABRIMOS NUESTRA CAMARA PARA SER USADA
			_camera.Unlock();


			//DE IGUAL FORMA QUE NUESTRA CAMARA CAMBIAMOS LA POSICION DE NUESTRA MEDIARECORDER
			_mediaRecorder.SetOrientationHint (90);
			//ASIGNAMOS LA CAMARA A NUESTRA MEDIARECORDER
			_mediaRecorder.SetCamera(_camera);

			//ASIGNAMOS LOS FORMATOS DE VIDEO Y AUDIO
			_mediaRecorder.SetAudioSource(AudioSource.Camcorder);
			_mediaRecorder.SetVideoSource(VideoSource.Camera);

			//RECUPERAMOS EL PERFIL QUE TIENE NUESTRA CAMARA PARA PODER ASIGNARSELA A NUESTRA MEDIARECORDER
			var camcorderProfile = ((int)Build.VERSION.SdkInt) >= 9 ? CamcorderProfile.Get(0, CamcorderQuality.High) : CamcorderProfile.Get(CamcorderQuality.High);

			//ASIGNAMOS EL PERFIL A NUESTRO MEDIARECORDER
			_mediaRecorder.SetProfile(camcorderProfile);

			//LE ASIGNAMOS EL PATH DONDE SE ENCUESTRA NUESTRO ARCHIVO DE VIDEO PARA PODER CREARLO
			_mediaRecorder.SetOutputFile(PathArchivoVideo ());


			//ASIGNAMOS EL SURFACE A NUESTRO MEDIARECORDER QUE UTILIZARA PARA VISUALIZAR LO QUE ESTAMOS GRABANDO
			_mediaRecorder.SetPreviewDisplay(_videoView.Holder.Surface);
			try
			{
				//CONFIRMAMOS LOS CAMBIOS HECHOS EN NUESTRO MEDIA RECORDER PARA PODER INICIAR A GRABAR
				_mediaRecorder.Prepare();
				return true;
			}
			catch
			{
				//SI OCURRE ALGUN PROBLEMA LIBRAMOS LOS RECURSOS ASIGNADOS A NUESTRO MEDIARECORDER
				LiberarMediaRecorder();
				return false;
			}
		}


		//LIBERAMOS LOS RECURSOS DE NUESTRA CAMARA
		private void LiberarCamera()
		{
			if (_camera == null) return;
			_camera.Release(); 
			_camera.Dispose();
			_camera = null;
		}


		//LIBERAMOS LOS RECURSOS DE NUESTRO MEDIARECORDER
		private void LiberarMediaRecorder()
		{
			if (_mediaRecorder == null) return;
			_mediaRecorder.Reset();
			_mediaRecorder.Release();
			_mediaRecorder.Dispose();
			_mediaRecorder = null;
			_camera.Lock();
		}


		//LIBERAMOS TODOS LOS RECURSOS UNA VES QUE HEMOS TERMINADO DE USAR NUESTRA ACTIVIDAD
		protected override void OnDestroy()
		{
			base.OnDestroy();
			LiberarMediaRecorder();
			LiberarCamera();
		}







	}
}


