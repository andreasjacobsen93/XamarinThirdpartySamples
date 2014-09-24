using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content.PM;
using Android.Provider;
using System.IO;

using Environment = Android.OS.Environment;
using Path = System.IO.Path;
using Uri = Android.Net.Uri;
using Android.Graphics;

namespace CamaraFoto
{
	[Activity (Label = "CamaraFoto", MainLauncher = true,ScreenOrientation = ScreenOrientation.Landscape)]
	public class MainActivity : Activity
	{

		// VARIABLES GENERALES
		int CAMERA_CAPTURE_IMAGE_REQUEST_CODE = 100;

		// DIRECTORIO DONDE SE GUARDARAN LAS IMAGENES
		String IMAGE_DIRECTORY_NAME = "AlmacenFotos";

		//VARIABLE QUE CONTIENE LA URL DONDE ESTA ALMACENADA LA IMAGEN
		private Uri fileUri; 

		//VARIABLES DE NUESTROS CONTROLES
		private ImageView imgPreview;
		private Button btnCapturePicture;


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			btnCapturePicture= FindViewById<Button> (Resource.Id.btnCapturePicture);
			imgPreview= FindViewById<ImageView> (Resource.Id.imgPreview);
			btnCapturePicture.Click += (s, args) => {

				CapturamosImagen();
			};

		}


		void CapturamosImagen ()
		{
			//FUNCION QUE SE ENCARGA DE CAPTURAR LA IMAGEN USANDO UN INTENT
			Intent intent = new Intent (MediaStore.ActionImageCapture);
			fileUri = GetOutputMediaFile (this.ApplicationContext, IMAGE_DIRECTORY_NAME, String.Empty);
			intent.PutExtra(MediaStore.ExtraOutput, fileUri);

			//LANZAMOS NUESTRO ITEM PARA CAPTURA LA IMAGEN
			StartActivityForResult(intent, CAMERA_CAPTURE_IMAGE_REQUEST_CODE);
		}



		//OBTENEMOS LA URI DE NUESTRA FUTURA IMAGEN 
		Uri GetOutputMediaFile (Context context, string subdir, string name)
		{
			subdir = subdir ?? String.Empty;
			//SI NO SE LE ASIGNA UN NOMBRE DE IMAGEN, EL SISTEMA ASIGNA UNO
			if (String.IsNullOrWhiteSpace (name))
			{
				string timestamp = DateTime.Now.ToString ("yyyyMMdd_HHmmss");
				name = "IMG_" + timestamp + ".jpg";
			}

			//OBTENEMOS EL PATH DONDE SE ENCUENTRA EL DIRECTORIO DE PICTURES DENTRO DE NUESTRO DISPOSITIVO
			string mediaType = Environment.DirectoryPictures;

			//OBTENEMOS EL PATH ABSOLUTO EN COMBINACION CON EL SUBDIRECTORIO DONDE GUARDAREMOS LAS IMAGENES
			using (Java.IO.File mediaStorageDir = new Java.IO.File (Environment.GetExternalStoragePublicDirectory(mediaType), subdir))
			{
				//VERIFICAMOS QUE EXISTA EL SUBDIRECTORIO
				if (!mediaStorageDir.Exists())
				{
					//SI NO EXISTE CREAMOS EL DIRECTORIO
					if (!mediaStorageDir.Mkdirs())
						throw new IOException ("NO se pudo crear el directorio, asegurece que tenga permisos la APP para crear archivos");

				}

				//REGRESAMOS LA URI DE LA NUEVA IMAGEN QUE SE USARA PARA GUARDAR LA FOTO
				return Uri.FromFile (new Java.IO.File (GetUniquePath (mediaStorageDir.Path, name)));
			}

		}

		//VERIFICAMOS QUE SEA UN PATH UNICO PARA LA NUEVA IMAGEN DE LA FOTOGRAFIA
		string GetUniquePath (string path, string name)
		{
			string ext = Path.GetExtension (name);
			if (ext == String.Empty)
				ext = ".jpg";

			name = Path.GetFileNameWithoutExtension (name);

			string nname = name + ext;
			int i = 1;
			while (File.Exists (Path.Combine (path, nname)))
				nname = name + "_" + (i++) + ext;

			return Path.Combine (path, nname);
		}


		protected override void OnActivityResult (int requestCode, Result resultCode, Intent data)
		{
			base.OnActivityResult (requestCode, resultCode, data);

			// VERIFICAMOS EL CODIGO DE CAPTURA DE LA IMAGEN
			if (requestCode == CAMERA_CAPTURE_IMAGE_REQUEST_CODE) 
			{
				//SI LA FOTO SE CAPTURO PROCEDEMOS A MOSTRA LA IMAGEN DE ESTA
				if (resultCode == Result.Ok ) {
					// DESPLEGAMOS LA IMAGEN QUE CAPTURAMOS DE NUESTRA FOTO
					previewCapturedImage ();
				} else if (resultCode == Result.Canceled) {
					// CUANDO LA CAPTURA ES CANCELADA

					Toast.MakeText(this.ApplicationContext,"La captura de la imagen fue cancelada.", ToastLength.Short )
						.Show();
				} else {
					// CUANDO ALGO FALLO EN LA CAPTURA DE LA IMAGEN
					Toast.MakeText(this.ApplicationContext,"Se produjo un fallo en la captura de la imagen.",  ToastLength.Short)
						.Show();
				}

			}

		}

		void previewCapturedImage ()
		{
			//MUESTRA LA IMAGEN QUE CAPTURAMOS
			BitmapFactory.Options options = new BitmapFactory.Options();
			options.InSampleSize = 8;
			//CREAMOS NEUSTRO BITMAP
			Bitmap bitmap = BitmapFactory.DecodeFile(fileUri.Path,options);
			//LE ASIGNAMOS EL BITMAP A NUESTRO CONTROL IMAGE
			imgPreview.SetImageBitmap (bitmap);
		}
	}
}


