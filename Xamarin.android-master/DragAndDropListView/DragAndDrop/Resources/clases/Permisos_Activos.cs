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

namespace DragAndDrop
{
	class Permisos_Activos
	{
		public Permisos_Activos(string titulo, string icono)
		{
			this.Titulo  = titulo;
			this.Icono = icono;
		}

		public string Titulo
		{
			get;
			set;
		}

		public string Icono
		{
			get;
			set;
		}
	}
}

