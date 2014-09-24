using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace custom_item
{
	[Activity (Label = "custom_item", MainLauncher = true)]
	public class Activity1 : Activity
	{

		List<cls_Libro> libros = new List<cls_Libro>();

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			libros.Add(new cls_Libro(1,"FROST BURNED","PATRICIA BRIGGS",350,100));
			libros.Add(new cls_Libro(2,"INFIERNO","DAN BROWN",430,70));
			libros.Add(new cls_Libro(3,"COLD VENGEANCE","PRESTON & CHILD",280,20));
			libros.Add(new cls_Libro(4,"BONES", "JAN BURKE",480,150));
			libros.Add(new cls_Libro(5,"ALEX CROSS","JAMES PATTERSON",410,52));
			libros.Add(new cls_Libro(6,"BATMAN YEAR ONE","FRANK MILLER, DAVID MAZZUCCHELLI",150,72));
			libros.Add(new cls_Libro(7,"CALLING THE DEAD","MARILYN MEREDITH",368,20));
			libros.Add(new cls_Libro(8,"FOOL ME TWICE","MICHAEL BRANDMAN",288,210));
			libros.Add(new cls_Libro(9,"A QUESTOF HEROES","MORGAN RICE",450,110));
			libros.Add(new cls_Libro(10,"FEVER MOON","KAREN MARIE MONING",560,230));

			ListView lwLibros= FindViewById<ListView> (Resource.Id.lwLibros);

			lwLibros.Adapter = new adapter_listview(this, libros);

			lwLibros.ItemClick += OnListItemClick;
		}

		protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
		{
			var listView = sender as ListView;
			var l = libros[e.Position];
			Android.Widget.Toast.MakeText(this, l.Nombre, Android.Widget.ToastLength.Short).Show();
		}


	}
}


