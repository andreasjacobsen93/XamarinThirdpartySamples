using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.GoogleMaps;
using Android.Graphics.Drawables;

namespace MonoDroid.GoogleMapsDemo
{
    
    [Activity(Label = "GoogleMapsDemo", MainLauncher = true, Icon = "@drawable/icon")]
    public class MyMapActivity : MapActivity
    {
        MyLocationOverlay myLocationOverlay;
        MapView mapView;
        MyItemizedOverlay myItemizedOverlay;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            /*
             * For Information on how to add you own keystore to the project read the README from the
             * old GoogleMaps sample: https://github.com/xamarin/monodroid-samples/tree/master/GoogleMaps
             * 
             * */

            // Remember to generate your own API key
            mapView = new MapView(this, "0Nd7w_yOI1NbUsBP_Mg2IosWa0Ns2j22r4meJnA");
            mapView.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);

            SetContentView(mapView);

            mapView.SetBuiltInZoomControls(true);
            mapView.Enabled = true;
            mapView.Clickable = true; //This has to be set to true to be able to navigate the map

            myLocationOverlay = new MyLocationOverlay(this, mapView); //this shows your current position on the map
            mapView.Overlays.Add(myLocationOverlay);

            Drawable marker = Resources.GetDrawable(Resource.Drawable.Icon); //these are the markers put on the map
            myItemizedOverlay = new MyItemizedOverlay(this, marker);
            mapView.Overlays.Add(myItemizedOverlay);

            myItemizedOverlay.AddItem(new GeoPoint((int)(55.816149 * 1E6),(int)(12.532868 * 1E6)), "BKSV", "Brüel & Kjær Sound & Vision");
            mapView.PostInvalidate();
        }

        protected override bool IsRouteDisplayed
        {
            get { return false; }
        }

        protected override void OnResume()
        {
            base.OnResume();
            myLocationOverlay.EnableMyLocation();
            myLocationOverlay.EnableCompass();
        }

        protected override void OnPause()
        {
            base.OnPause();
            myLocationOverlay.DisableMyLocation();
            myLocationOverlay.DisableCompass();
        }
    }
}

