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

namespace custom_item
{


	public class cls_Libro
	{
		/*VARIABLES*/
		int _id_libro;
		string _nombre;
		string _autor;
		int _total_pag;
		int _pag_leidas;


		/*CONSTRUCTOR*/
		public cls_Libro(int id_libro,
		                 string nombre,
		                 string autor,
		                 int total_pag,
		                 int pag_leidas)
		{

			this._id_libro=id_libro;
			this._nombre = nombre;
			this._autor=nombre;
			this._total_pag=total_pag;
			this._pag_leidas=pag_leidas;
		}

		/*PROPIEDADES*/

		public int Pag_leidas{
			get{
				return _pag_leidas;
			}
			set{

				_pag_leidas = value;
			}
		}

		public int Total_pag{
			get{
				return _total_pag;
			}
			set{

				_total_pag = value;
			}
		}


		public string Autor{
			get{
				return _autor;
			}
			set{

				_autor = value;
			}
		}


		public string Nombre{
			get{
				return _nombre;
			}
			set{

				_nombre = value;
			}
		}

		public int Id_libro{
			get{
				return _id_libro;
			   }
			set{

				_id_libro = value;
			   }
		}


	}
}

