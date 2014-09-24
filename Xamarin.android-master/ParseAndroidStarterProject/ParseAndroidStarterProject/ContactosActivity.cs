
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

namespace ParseAndroidStarterProject
{
	[Activity (Label = "Contactos", MainLauncher = true)]			
	public class ContactosActivity : Activity
	{
		//VARIABLES PARA NUESTRO LSITVIEW QUE NOS MOSTRARAN TODOS LOS CONTACTOS QUE ESTAN REGISTRADOS
		List<ParseObject> Lista_Contactos;
		ListView lvContactos;
		adapter_listview lvadapter;

		//BOTONES
		Button btnAlta;
		Button btnActualizar;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.lista_contacto);

			//INICIALIZAMOS NUESTRAS VARIABLES DEL LISTVIEW, LE AGREGAMOS EL EVENTO CLICK Y EL ADAPTADOR PARA CARGAR
			//LOS CONTACTOS EN NUESTRO LISTVIEW

			//INICIALIZAMOS NUESTRA LISTA DE CONTACTOS, LOS CUALES SERAN OBJECTOS DE TIPO ParseObject
			Lista_Contactos = new List<ParseObject> ();

			//INICIALIZAMOS EL ADAPTADOR Y LE ASIGNAMOS LA LISTA DE CONTACTOS
			lvadapter=new adapter_listview(this, Lista_Contactos);

			lvContactos = FindViewById<ListView> (Resource.Id.lvContactos);
			lvContactos.Adapter = lvadapter;
			lvContactos.ItemClick += OnListItemClick;


			//INICIALIZAMOS NUESTROS BOTONES PARA INVOCAR LA ACTIVIDAD PARA DAR DE ALTA Y ACTUALIZAR
			//LA LISTA DE CONTACTOS
			btnAlta= FindViewById<Button> (Resource.Id.btnAlta);
			btnAlta.Click += delegate {
				var id = new Intent (this, typeof(AltaActivity));
				StartActivity (id);  
			};

			btnActualizar= FindViewById<Button> (Resource.Id.btnActualizar);
			btnActualizar.Click += delegate {
				RegresaContactos ();
			};

			//METODO QUE INVOCARARA AL ParseObject.GetQuery, PARA RECUPERAR NUESTROS CONTACTOS
			RegresaContactos ();
		}

	
		protected void OnListItemClick(object sender, Android.Widget.AdapterView.ItemClickEventArgs e)
		{

			var contacto = lvadapter[e.Position];
			//Toast.MakeText (this, "Nombre ="+ contacto.Get<string>("nombre"), ToastLength.Long).Show();

			var id = new Intent (this, typeof(EditarActivity));

			id.PutExtra ("id", contacto.ObjectId);
			StartActivity (id);  
		}


		public async Task RegresaContactos ()
		{
			//RECUPERAMOS NUESTROS CONTACTOS
			var query = ParseObject.GetQuery("Contacto");
			IEnumerable<ParseObject> results = await query.FindAsync ();


			//UNA VEZ QUE SE TIENE LOS CONTACTOS LOS ASIGNAMOS A NUESTRA VARIABLE Lista_Contactos
			Lista_Contactos = results.ToList ();

			//PASAMOS LA LISTA DE CONTACTOS A NUESTRO ADAPTADOR PARA PODER CARGARLOS EN NUESTO LISTVIEW
			lvadapter.refresh (Lista_Contactos);

		}
	}


	/// <summary>
	/// -----------------------------------ADAPTADOR DEL LISTVIEW DE CONTACTOS--------------------------------------------
	/// </summary>
	public class adapter_listview: BaseAdapter<ParseObject>
	{
		List<ParseObject> items;
		Activity context;

		public adapter_listview(Activity context, List<ParseObject> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}

		public override ParseObject this[int position]
		{
			get { return items[position]; }
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override int Count
		{
			get { return items.Count; }
		}

		public void refresh(List<ParseObject> items)
		{
			this.items = items;
			this.NotifyDataSetChanged ();
		} 

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;
			if (view == null) 
				view = context.LayoutInflater.Inflate(Resource.Layout.item_lista, null);


			view.FindViewById<TextView> (Resource.Id.txtNombre).Text = item.Get<string>("nombre");
			view.FindViewById<TextView>(Resource.Id.txtTelefono).Text = item.Get<string>("telefono");

			return view;
		}

	}

}

