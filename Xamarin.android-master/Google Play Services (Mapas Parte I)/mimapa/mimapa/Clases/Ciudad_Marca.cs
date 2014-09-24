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
using Android.Gms.Maps.Model;

namespace mimapa
{
	class Ciudad_Marca
	{

		public Ciudad_Marca(string nombre,string descripcion, LatLng ubicacion,string imagen)
		{
			this.Nombre = nombre;
			this.Descripcion = descripcion;
			this.Ubicacion = ubicacion;
			this.Imagen = imagen;
		}

		public string Nombre{
			get;
			set;
		}
		public string Descripcion{
			get;
			set;
		}
		public string Imagen{
			get;
			set;
		}
		public LatLng Ubicacion{
			get;
			set;
		}
		public Marker Marcador{
			get;
			set;
		}

	}
}

