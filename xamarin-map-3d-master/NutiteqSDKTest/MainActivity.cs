using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Com.Nutiteq;
using Com.Nutiteq.Projections;
using NutiteqComponents;
using NutiteqStyle;
using NutiteqGeometry;
using Com.Nutiteq.Utils;
using Com.Nutiteq.UI;
using Android.Graphics;
using Com.Nutiteq.Log;
using Com.Nutiteq.Layers.Vector;
using Com.Nutiteq.Vectorlayers;
using Com.Nutiteq.Roofs;
using Com.Nutiteq.Layers.Raster;

namespace NutiteqSDKTest
{
	[Activity (Label = "NutiteqSDKTest", MainLauncher = true)]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);


			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// enable Nutiteq SDK logging

			Log.EnableAll ();

			// get MapView

			MapView view = FindViewById<MapView> (Resource.Id.mapView);

			// define mandatory parameters

			// Components keeps internal state and parameters for MapView
			view.Components = new Components ();

			// define base projection, almost always EPSG3857, but others can be defined also
			EPSG3857 proj = new EPSG3857 ();


			// set online base layer with MapQuest Open Tiles
			view.Layers.BaseLayer = new TMSMapLayer(proj, 0, 18, 0, "http://otile1.mqcdn.com/tiles/1.0.0/osm/", "/", ".png");

			/*
			//set offline base layer from MBTiles file
			//TODO: set path properly
			String MbTilePath = "/sdcard/europe-tilemill-mbtiles.sqlite";

			view.Layers.BaseLayer = new MBTilesMapLayer (proj, 0, 5, 1, MbTilePath, this);
			*/

			// start map
			view.StartMapping ();

			// add a marker

			// define marker style (image, size, color)
			Bitmap pointMarker = UnscaledBitmapLoader.DecodeResource(Resources, Resource.Drawable.olmarker);

			MarkerStyle.Builder markerStyleBuilder = new MarkerStyle.Builder ();
			markerStyleBuilder.SetBitmap (pointMarker);
			markerStyleBuilder.SetColor (NutiteqComponents.Color.White);
			markerStyleBuilder.SetSize (0.5f);
			MarkerStyle markerStyle = markerStyleBuilder.Build ();

			// define label what is shown when you click on marker
			Label markerLabel = new DefaultLabel ("San Francisco", "Here is a marker");

			// define location of the marker, it must be converted to base map coordinate system
			MapPos SanFrancisco = view.Layers.BaseLayer.Projection.FromWgs84 (-122.416667f, 37.766667f);
			MapPos London = view.Layers.BaseLayer.Projection.FromWgs84 (0.0f, 51.0f);

			// create layer and add object to the layer, finally add layer to the map. 
			// All overlay layers must be same projection as base layer, so we reuse it
			MarkerLayer markerLayer = new MarkerLayer(view.Layers.BaseLayer.Projection);

			markerLayer.Add(new Marker(SanFrancisco, markerLabel, markerStyle, markerLayer));
			view.Layers.AddLayer(markerLayer);

			// 3d building layer

			Polygon3DStyle.Builder nml3dStyleBuilder = new Polygon3DStyle.Builder ();
			Polygon3DStyle nml3dStyle = nml3dStyleBuilder.Build ();

			StyleSet nmlStyleSet = new StyleSet ();
			nmlStyleSet.SetZoomStyle (14, nml3dStyle);

			NMLModelOnlineLayer Online3dLayer = new NMLModelOnlineLayer (view.Layers.BaseLayer.Projection, "http://aws-lb.nutiteq.ee/nml/nmlserver2.php?data=demo&", nmlStyleSet);

			// persistent caching settings for the layer
			Online3dLayer.SetMemoryLimit (20*1024*1024); // 20 MB
			Online3dLayer.SetPersistentCacheSize (50*1024*1024); // 50 MB
			Online3dLayer.SetPersistentCachePath ("/sdcard/nmlcache.db"); // mandatory to be set

			view.Layers.AddLayer(Online3dLayer);

			// OSM Polygon3D layer

			Polygon3DStyle.Builder poly3dStyleBuilder = new Polygon3DStyle.Builder ();
			poly3dStyleBuilder.SetColor (NutiteqComponents.Color.White);
			Polygon3DStyle poly3dStyle = poly3dStyleBuilder.Build ();

			StyleSet polyStyleSet = new StyleSet ();
			polyStyleSet.SetZoomStyle (16, poly3dStyle);

			Roof DefaultRoof = new FlatRoof ();

			Polygon3DOSMLayer Poly3DLayer = new Polygon3DOSMLayer (view.Layers.BaseLayer.Projection, 0.3f, DefaultRoof, unchecked((int) 0xffffffff) /* white */, unchecked((int) 0xff888888) /* gray */, 1500, polyStyleSet);
			view.Layers.AddLayer (Poly3DLayer);

			// set map center and zoom
			view.FocusPoint = SanFrancisco;
			view.Zoom = 5.0f;

			// set listener for map events
			MapListener listener = new MyMapListener ();
			view.Options.MapListener = listener;

		}
	}
}


