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
using Java.Interop;

namespace tutorial2
{
	public class cls_Libro : Java.Lang.Object, IParcelable

	{
		/*CONFIRAMOS LAS FUNCIONES PARCEL DE NUESTRA INTERFACE*/

		#region IParcelable implementation
		public int DescribeContents ()
		{
			return 0;
		}
		public void WriteToParcel (Parcel dest, ParcelableWriteFlags flags)
		{
			dest.WriteInt(this.Id_libro);
			dest.WriteString(this.Nombre);
			dest.WriteString(this.Autor);
			dest.WriteInt(this.Total_pag);
			dest.WriteString(this.Descripcion);
		}
		#endregion


		[ExportField("CREATOR")]
		public static IParcelableCreator GetCreator()
		{
			return new MyParcelableCreator();
		}

		// Parcelable.Creator 
		class MyParcelableCreator : Java.Lang.Object, IParcelableCreator
		{
			#region IParcelableCreator implementation
			Java.Lang.Object IParcelableCreator.CreateFromParcel(Parcel source)
			{
				int id = source.ReadInt ();
				string nombre = source.ReadString();
				string autor = source.ReadString();
				int total_pag = source.ReadInt ();
				string descripcion = source.ReadString();
				return new cls_Libro(id,nombre,autor,total_pag,descripcion);
			}

			Java.Lang.Object[] IParcelableCreator.NewArray(int size)
			{
				return new Java.Lang.Object[size];
			}
			#endregion
		}
 		

		/*VARIABLES*/
		int _id;
		string _nombre;
		string _autor;
		int _total_pag;
		string _descripcion;


		/*CONSTRUCTOR*/
		public cls_Libro(int id,
		                 string nombre,
		                 string autor,
		                 int total_pag,
		                 string descripcion)
		{
			this.Id_libro = id;
			this.Nombre= nombre;
			this.Autor= autor;
			this.Total_pag= total_pag;
		    this.Descripcion = descripcion;

		}


		/*PROPIEDADES*/

		public string Descripcion
		{
			get{ return _descripcion;} 
			set{ _descripcion = value;}
		}


		public int Total_pag
		{
			get{ return _total_pag;} 
			set{ _total_pag = value;}
		}

		public string Autor
		{
			get{ return _autor;} 
			set{ _autor = value;}
		}

		public string Nombre
		{
			get{ return _nombre;} 
			set{ _nombre = value;}
		}
		public int Id_libro
		{
			get{ return _id;} 
			set{ _id = value;}
		}


	}
}

