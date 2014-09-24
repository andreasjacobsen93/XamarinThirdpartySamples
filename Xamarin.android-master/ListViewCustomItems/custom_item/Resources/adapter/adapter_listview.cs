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
	public class adapter_listview : BaseAdapter<cls_Libro>
	{

		List<cls_Libro> items;
		Activity context;

		public adapter_listview(Activity context, List<cls_Libro> items): base()
		{
			this.context = context;
			this.items = items;
		}


		#region implemented abstract members of BaseAdapter
		public override long GetItemId (int position)
		{
			return position;
		}

		public override View GetView (int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) 
				view = context.LayoutInflater.Inflate(Resource.Layout.custom_item, null);

			view.FindViewById<TextView> (Resource.Id.txtNombre).Text = item.Nombre;
			view.FindViewById<TextView>(Resource.Id.txtAutor).Text = item.Autor;
			view.FindViewById<TextView>(Resource.Id.txtPaginas).Text = item.Pag_leidas.ToString()+" DE "+ item.Total_pag.ToString() +" PAG.";
			view.FindViewById<ProgressBar> (Resource.Id.pbProgreso).Max = item.Total_pag;
			view.FindViewById<ProgressBar> (Resource.Id.pbProgreso).Progress = item.Pag_leidas;

			int id_img = context.Resources.GetIdentifier ("img"+item.Id_libro.ToString(), "drawable", context.PackageName);
			view.FindViewById<ImageView>(Resource.Id.imgPortada_item).SetImageResource(id_img);

			return view;
		}

		public override int Count {
			get { return items.Count; }
		}
		#endregion

		#region implemented abstract members of BaseAdapter
		public override cls_Libro this [int position] {
			get { return items[position]; }
		}
		#endregion
	}
}

