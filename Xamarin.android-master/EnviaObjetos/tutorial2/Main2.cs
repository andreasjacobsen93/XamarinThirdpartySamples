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

namespace tutorial2
{
	[Activity (Label = "Main2")]			
	public class Main2 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main_2);
			var mi_libro = this.Intent.GetParcelableExtra("libro_enviado") as cls_Libro;

			TextView titulo= FindViewById<TextView> (Resource.Id.txtTitulo);
			TextView autor= FindViewById<TextView> (Resource.Id.txtAutor);
			TextView descripcion= FindViewById<TextView> (Resource.Id.txtDescripcion);

			// Create your application here

			titulo.Text = mi_libro.Nombre;

			autor.Text = mi_libro.Autor + " (" + mi_libro.Total_pag.ToString()+ " pag.)";
			descripcion.Text = mi_libro.Descripcion;
		}
	}
}

