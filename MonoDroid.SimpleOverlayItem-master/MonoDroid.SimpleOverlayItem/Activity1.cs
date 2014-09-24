using System;

using Android.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.GoogleMaps;
using Android.Graphics.Drawables;

namespace MonoDroid.SimpleOverlayItem
{
    [Activity(Label = "MonoDroid.TestOverlayItem", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : MapActivity
    {
        MapView mapView;
        MyItemizedOverlay myItemizedOverlay;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Read more about obtaining a Maps Key here: http://docs.xamarin.com/android/advanced_topics/Obtaining_a_Google_Maps_API_Key
            mapView = new MapView(this, "<your key here>");
            mapView.LayoutParameters = new ViewGroup.LayoutParams(ViewGroup.LayoutParams.FillParent, ViewGroup.LayoutParams.FillParent);
            mapView.Satellite = true;

            SetContentView(mapView);

            Drawable marker = Resources.GetDrawable(Resource.Drawable.Icon); //these are the markers put on the map
            myItemizedOverlay = new MyItemizedOverlay(this, marker);
            mapView.Overlays.Add(myItemizedOverlay);
            mapView.PostInvalidate();

            GeoPoint point = new GeoPoint((int)(55.785213 * 1E6), (int)(12.522182 * 1E6)); //DTU
            myItemizedOverlay.AddOverlayItem(new OverlayItem(point, "DTU", "Anker Engelunds Vej 101"));

            point = new GeoPoint((int)(55.816034 * 1E6), (int)(12.532547 * 1E6));
            myItemizedOverlay.AddOverlayItem(new OverlayItem(point, "Brüel & Kjær", "Skodsborgvej 307C"));
        }

        protected override bool IsRouteDisplayed
        {
            get { return false; }
        }
    }
}

