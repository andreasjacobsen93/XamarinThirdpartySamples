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
	class Adapter_Permisos: BaseAdapter<Permisos_Activos>
	{

		//Lista que almacena los permisos con los que se van a caragr nuestro adapter
		List<Permisos_Activos> items;

		Activity context;

		//Constructor de nuestro adapter
		public Adapter_Permisos(Activity context, List<Permisos_Activos> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}


		#region implemented abstract members of BaseAdapter

		public override long GetItemId (int position)
		{
			return position ;
		}

		//Generamos la vista de nuestro Permiso en el listview
		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			//Obtenemos el objecto Permiso de nuestro listado
			var item = items[position];

			View view = convertView;
			//Generamos la refencia al template que utilizaremos para mostrar nuestro Permiso
			if (view == null)
				view = context.LayoutInflater.Inflate(Resource.Layout.item_permiso, null);

			//Asignamos el titulo del Permiso
			view.FindViewById<TextView> (Resource.Id.txtTitulo).Text = item.Titulo;

			//Asignamos el icono al Permiso de nuestros recursos.
			int id_img = context.Resources.GetIdentifier (item.Icono, "drawable", context.PackageName);
			view.FindViewById<ImageView>(Resource.Id.imvIcono).SetImageResource(id_img);

			return view;
		}

		//Regresamos el numero de elementos que tiene nuestro adapter
		public override int Count
		{
			get { return items.Count; }
		}


		#endregion

		#region implemented abstract members of BaseAdapter

		public override Permisos_Activos this [int index] {
			get {
				return items[index]; 
			}
		}

		#endregion


		//Actuliza los cambios hechos en nuestro adapter y puedan ser visibles
		public override void NotifyDataSetChanged ()
		{
			base.NotifyDataSetChanged ();
		}

		//Agrega un nuevo elemento a nuestro adapter(Listado de Permisos)
		public void add(Permisos_Activos p)
		{
			items.Add (p);
			NotifyDataSetChanged ();
		}
		//Removemos un elemento de nuestro adapter(Listado de Permisos)
		public void remove(int index)
		{
			items.RemoveAt (index);
			NotifyDataSetChanged ();
		}

		//Regresa eun objecto tipo Permisos_Activo de acuerdo al indice que deseamos
		public Permisos_Activos PermisoBuscado(int index)
		{
			return items[index];
		}



	}
}

