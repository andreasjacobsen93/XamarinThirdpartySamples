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
using Parse;
using System.Threading.Tasks;
using System.Threading;

namespace ParseAndroidStarterProject
{
	[Activity (Label = "Alta de contactos")]
	public class AltaActivity : Activity
	{

		Button btnGuardar;
		EditText txtNombre;
		EditText txtTelefono;
	


		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
					
			SetContentView (Resource.Layout.alta_contacto);

			btnGuardar = FindViewById<Button> (Resource.Id.btnGuardar);
			txtNombre = FindViewById<EditText> (Resource.Id.txtNombre);
			txtTelefono = FindViewById<EditText> (Resource.Id.txtTelefono);


			btnGuardar.Click += delegate {
				ParseObject contactos = new ParseObject("MisContactos");
				contactos["nombre"] =txtNombre.Text;
				contactos["telefono"] = txtTelefono.Text;
				contactos.SaveAsync ();
				txtNombre.Text="";
				txtTelefono.Text="";

				Toast.MakeText (this, "Se registro nuevo contacto", ToastLength.Long).Show();

			};



		}

	







	}
}


