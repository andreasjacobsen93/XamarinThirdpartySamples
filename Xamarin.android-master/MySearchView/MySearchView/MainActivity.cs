using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace MySearchView
{
	[Activity (Label = "MySearchView", MainLauncher = true, LaunchMode = Android.Content.PM.LaunchMode.SingleTop)]
	[IntentFilter(new string[]{"android.intent.action.SEARCH"})]//Le indicamos a la actividad que sea capas de utilizar ACTION_SEARCH.
	[MetaData(("android.app.searchable"), Resource = "@xml/searchable")]//Le espeficicamos el tipo de configuracion de busquedad que va ha utilizar.
	public class MainActivity : Activity
	{
		TextView tv_Mensaje;
		ListView lv_Paises;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			tv_Mensaje = this.FindViewById<TextView> (Resource.Id.tv_Mensaje);
			lv_Paises = this.FindViewById<ListView> (Resource.Id.lv_Paises);

			EscuchadorBusquedad (Intent);

		}

		protected override void OnNewIntent (Android.Content.Intent intent)
		{
			// Debido a que esta actividad se ha fijado launchMode = "singleTop", el sistema llama a este método 
			// Para entregar la intención si este actvity es actualmente la actividad de primer plano cuando 
			// Invocamos de nuevo (cuando el usuario ejecuta una búsqueda de esta actividad, no creamos 
			// Una nueva instancia de esta actividad, por lo que el sistema ofrece la intención de búsqueda aquí)
			EscuchadorBusquedad (intent);
		}


		//Inicializamos el menu personalizado para que pueda desplegar la funciones de busquedad
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.menu, menu);

			var searchManager = (SearchManager)GetSystemService (Context.SearchService);
			var searchView = (SearchView)menu.FindItem (Resource.Id.search).ActionView;

			searchView.SetSearchableInfo (searchManager.GetSearchableInfo (ComponentName));
			searchView.SetIconifiedByDefault (false);

			return true;
		}

		//Capturamos cuando se selecciona el item de busquedad para habilitarla
		public override bool OnOptionsItemSelected (IMenuItem item)
		{
			switch (item.ItemId) {
			case Resource.Id.search:
				OnSearchRequested ();
				return true;
			default:
				return false;
			}
		}





		//Este metodo nos ayudar para obtener  la opcion seleecionada de los diferentes paises
		//tambien nos servira pasa saber para identificar con que accion recobramos la opcion 
		void EscuchadorBusquedad (Intent intent)
		{
			//Verificamos si la forma de obtener el pais fue traves de presionar directamente desde los elementos desplegrables 
			if (Intent.ActionView.Equals (intent.Action)) 
			{

				//obtenemos el uri del pais que seleccionamos
				string uri_string = intent.DataString ;
				Android.Net.Uri uri_pais = Android.Net.Uri.Parse (uri_string);

				//recobramos el pais de nuestro proveedor y lo guardamos en un cursos
				var cursor = ManagedQuery (uri_pais, null, null, null, null);

				if (cursor == null) {
					Android.Widget.Toast.MakeText(this,"No se selecciono ningun elemento. ", Android.Widget.ToastLength.Short).Show();
				} else {
					cursor.MoveToFirst ();
					//recobramos los indices de las columnas para obtener los datos de nuestro pais
					int pIndex = cursor.GetColumnIndexOrThrow (Manejador_db.KEY_PAIS );
					int cIndex = cursor.GetColumnIndexOrThrow (Manejador_db.KEY_CONTINENTE);
					Android.Widget.Toast.MakeText(this,"Pais: "+cursor.GetString (pIndex)+" Continente:"+cursor.GetString (cIndex), Android.Widget.ToastLength.Long).Show();

				}


			} //Verificamos si la forma de obtener el pais fue traves de presionar el boton de ¨ir¨ en el teclado virtual
			else if (Intent.ActionSearch.Equals (intent.Action)) {
				string query = intent.GetStringExtra (SearchManager.Query);
				BuscarPaisesCoincidan (query); 
			}
		}

		void BuscarPaisesCoincidan (string query)
		{
			var cursor = ManagedQuery (cpProveedorDatos.CONTENT_URI, null, null, new string[] {query}, null);
			if (cursor == null) {
				// No se encontraro resultados        
				tv_Mensaje.Text = GetString (Resource.String.no_results, query); 
			} else {

				int count = cursor.Count;
				var countString = Resources.GetQuantityString (Resource.Plurals.search_results, count, count, query);
				tv_Mensaje.Text = countString;

				string[] from = new string[] { Manejador_db.KEY_PAIS,Manejador_db.KEY_CONTINENTE };
				int[] to = new int[] { Resource.Id.tv_Pais,	Resource.Id.tv_Continente};
				var words = new SimpleCursorAdapter (this, Resource.Layout.item_pais, cursor, from, to);

				lv_Paises.Adapter = words;

			}
		}






	}
}


