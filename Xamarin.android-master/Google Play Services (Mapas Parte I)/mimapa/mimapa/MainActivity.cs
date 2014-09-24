using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using Android.Support.V4.App;
using System.Collections.Generic;

namespace mimapa
{
	[Activity (Label = "mimapa", MainLauncher = true)]
	public class MainActivity : Activity
	{
		private MapFragment _mapFragment;
		List<Ciudad_Marca> MisCiudades = new List<Ciudad_Marca>();
		GoogleMap mMap;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
			Inicializa_MapFragment ();
			//Definimos las ciudades en las cuales pondremos nuestros marcadores en el mapa
			MisCiudades.Add ( new Ciudad_Marca ("MÉXICO D.F.","En su forma abreviada México, D. F., es la capital y sede de los poderes federales de los Estados Unidos Mexicanos.",new LatLng (19.430334, -99.13599),"p1"));
			MisCiudades.Add ( new Ciudad_Marca ("LEÓN","Es una ciudad mexicana localizada  en el Estado de Guanajuato,México, en la región del Bajío.",new LatLng ( 21.12806,-101.689163),"p2"));
			MisCiudades.Add ( new Ciudad_Marca ("LAGOS DE MORENO"," Es un municipio y la ciudad más grande y poblada de la Región denominada Los Altos de Jalisco, ubicados en el estado mexicano de Jalisco.",new LatLng ( 21.36453,-101.939076),"p3"));
			MisCiudades.Add ( new Ciudad_Marca ("GUADALAJARA","es una ciudad mexicana, capital del estado de Jalisco, así como principal localidad del área urbana denominada Zona Metropolitana de Guadalajara.",new LatLng ( 20.663626,-103.343754),"p4"));

			CargamosMarcadores ();

		}
		protected override void OnResume ()
		{
			base.OnResume ();
			CargamosMarcadores ();
		}

		void Inicializa_MapFragment ()
		{
			//RECUPERAMOS NUESTRO FrameLayout Y LO CONVERTIMOS EN UN MapFragment
			_mapFragment = FragmentManager.FindFragmentByTag("map") as MapFragment;
			if (_mapFragment == null)
			{
				//Configuramos las opciones con las cuales se cargara nuestro mapa,
				// asignamos el tipo de mapa a mostrar
				// habilitamos los botones de zoom 
				// nos muestre el compas en el mapa
				GoogleMapOptions mapOptions = new GoogleMapOptions()
					.InvokeMapType(GoogleMap.MapTypeNormal)
						.InvokeZoomControlsEnabled(true)
						.InvokeCompassEnabled(true);

				//Realizamos la transaccion para cargar el MapFragment con las opciones que definimos
				var fragTx = FragmentManager.BeginTransaction();
				_mapFragment = MapFragment.NewInstance(mapOptions);
				fragTx.Add(Resource.Id.map, _mapFragment, "map");
				fragTx.Commit();
			}
		}

		void CargamosMarcadores ()
		{
			if (mMap == null) 
			{
				mMap = _mapFragment.Map;
				if (mMap != null)
				{
					//Relizamos un ciclo para cargar todas las ciudades en nuestro mapa y le asignamos un puntero de color azul
					foreach (Ciudad_Marca ciudad in MisCiudades) 
					{
						ciudad.Marcador=mMap.AddMarker(new MarkerOptions()
						                               .SetPosition(ciudad.Ubicacion)
						                               .SetTitle(ciudad.Nombre)
						                               .SetSnippet(ciudad.Descripcion)
						                               .InvokeIcon(BitmapDescriptorFactory.DefaultMarker(BitmapDescriptorFactory.HueAzure)));
					}

					//Le indicamos que deve de cargar un ventana de información personalizada 
					mMap.SetInfoWindowAdapter (new CustomInfoWindowAdapter (this,MisCiudades));

					//Ubicamos la cámara en un posición que se puedan ver las marcas 
					mMap.MoveCamera(CameraUpdateFactory.NewLatLngZoom(new LatLng ( 21.12806,-101.689163), 6));

				}

			}
		}

	}
}


