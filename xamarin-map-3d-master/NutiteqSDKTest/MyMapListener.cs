using System;
using Com.Nutiteq.UI;
using Android.Util;
using NutiteqGeometry;
using Android.Widget;
using Android.Content;

namespace NutiteqSDKTest
{
	internal partial class MyMapListener: MapListener
	{

		override public void OnMapClicked (double x, double y, bool longClick)
		{
			Log.Debug ("NT", "OnMapClicked " + x + " " + y + " " + longClick);
		}

		override public void OnLabelClicked(VectorElement element, bool longClick)
		{
			Log.Debug ("NT", "OnLabelClicked " + element+ " " + longClick);
		}

		override public void OnVectorElementClicked(VectorElement element, double x, double y,  bool longClick)
		{
			Log.Debug ("NT", "OnVectorElementClicked "  + x + " " + y + " " + element+ " " + longClick);
		}

		override public void OnMapMoved()
		{
			Log.Debug ("NT", "OnMapMoved" );
		}
			
	}
}

