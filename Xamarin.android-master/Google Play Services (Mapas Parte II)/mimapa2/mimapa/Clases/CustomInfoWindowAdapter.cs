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
using Android.Gms.Maps;

namespace mimapa
{
	class CustomInfoWindowAdapter : Java.Lang.Object, GoogleMap.IInfoWindowAdapter 
	{


		private readonly View mWindow;
		MainActivity parent;
		List<Ciudad_Marca> Ciudades;

		public CustomInfoWindowAdapter (MainActivity parent,List<Ciudad_Marca> MisCiudades) 
		{
			this.parent = parent;
			mWindow = parent.LayoutInflater.Inflate (Resource.Layout.custominfowindow, null);
			this.Ciudades = MisCiudades;

		}


		public View GetInfoContents (Android.Gms.Maps.Model.Marker p0)
		{
			throw new NotImplementedException ();
		}

		public View GetInfoWindow (Android.Gms.Maps.Model.Marker marker)
		{
			Render(marker, mWindow);
			return mWindow;
		}

		private void Render (Android.Gms.Maps.Model.Marker marker, View view) 
		{
			int id_Imagen=0;

			foreach (Ciudad_Marca ciudad in Ciudades) 
			{
				if (marker.Equals (ciudad.Marcador)) 
				{
					id_Imagen = parent.Resources.GetIdentifier (ciudad.Imagen, "drawable", parent.PackageName);

				}
			}

			((ImageView) view.FindViewById (Resource.Id.badge)).SetImageResource (id_Imagen);

			System.String titulo = marker.Title;
			TextView txtTitulo = ((TextView) view.FindViewById (Resource.Id.title));

			if (titulo != null) {

				txtTitulo.Text = titulo;
			} else {
				txtTitulo.Text = ("");
			}

			System.String descripcion = marker.Snippet;

			TextView txtDescripcion = ((TextView) view.FindViewById(Resource.Id.snippet));
			if (descripcion != null) {
				txtDescripcion.Text = descripcion;
			} else {
				txtDescripcion.Text = "";
			}



		}




	}
}

