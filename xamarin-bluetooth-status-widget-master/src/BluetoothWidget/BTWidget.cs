/*
  The MIT License (MIT)

  Copyright (c) 2014 John Wilson

  Permission is hereby granted, free of charge, to any person obtaining a copy
  of this software and associated documentation files (the "Software"), to deal
  in the Software without restriction, including without limitation the rights
  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
  copies of the Software, and to permit persons to whom the Software is
  furnished to do so, subject to the following conditions:

  The above copyright notice and this permission notice shall be included in all
  copies or substantial portions of the Software.
*/

using Android.App;
using Android.Appwidget;
using Android.Content;
using Android.Bluetooth;
using Android.Util;
using Android.Widget;

namespace BluetoothWidget
{
  // see https://developer.android.com/guide/topics/appwidgets/index.html
  // and http://stackoverflow.com/questions/4073907/update-android-widget-from-activity?rq=1
  [BroadcastReceiver(Label = "Bluetooth Widget")]
  [IntentFilter(new string[] { "android.appwidget.action.APPWIDGET_UPDATE", BluetoothAdapter.ActionStateChanged })]
  [MetaData("android.appwidget.provider", Resource = "@xml/bt_widget")]
  public class BTWidget : AppWidgetProvider
  {
    private const string APP_NAME = "BTWidget";

    /// <summary>
    /// This event fires for every intent you're filtering for. There can be lots of them,
    /// and they can arrive very quickly, so spend as little time as possible processing them
    /// on the UI thread.
    /// </summary>
    /// <param name="context">The Context in which the receiver is running.</param>
    /// <param name="intent">The Intent being received.</param>
    public override void OnReceive(Context context, Intent intent)
    {
      Log.Info(APP_NAME, "OnReceive received intent: {0}", intent.Action);

      if(intent.Action == "android.appwidget.action.APPWIDGET_UPDATE")
      {
        Log.Info(APP_NAME, "Received AppWidget Update");
        var currentState = Android.Bluetooth.BluetoothAdapter.DefaultAdapter.State;
        Log.Info(APP_NAME, "BT adapter state currently {0}", currentState);
        UpdateWidgetDisplay(context, (int)currentState);
        return;
      }

      if(intent.Action == Android.Bluetooth.BluetoothAdapter.ActionStateChanged)
      {
        Log.Info(APP_NAME, "Received BT Action State change message");
        ProcessBTStateChangeMessage(context, intent);
        return;
      }
    }

    private void ProcessBTStateChangeMessage(Context context, Intent intent)
    {
      int prevState = intent.GetIntExtra(BluetoothAdapter.ExtraPreviousState, -1);
      int newState = intent.GetIntExtra(BluetoothAdapter.ExtraState, -1);
      string message = string.Format("Bluetooth State Change from {0} to {1}", prevState, newState);
      Log.Info(APP_NAME, message);

      UpdateWidgetDisplay(context, newState);
    }

    /// <summary>
    /// Updates the widget display image based on the new state
    /// </summary>
    /// <param name="context">Context.</param>
    /// <param name="newState">New state.</param>
    private void UpdateWidgetDisplay(Context context, int newState)
    {
      var appWidgetManager = AppWidgetManager.GetInstance(context);
      var remoteViews = new RemoteViews(context.PackageName, Resource.Layout.initial_layout);
      Log.Debug(APP_NAME, "this.GetType().ToString(): {0}", this.GetType().ToString());

      var thisWidget = new ComponentName(context, this.Class);
      Log.Debug(APP_NAME, thisWidget.FlattenToString());
      Log.Debug(APP_NAME, "remoteViews: {0}", remoteViews.ToString());

      int imgResource = Resource.Drawable.bluetooth_off;
      switch((Android.Bluetooth.State)newState)
      {
        case Android.Bluetooth.State.Off:
        case Android.Bluetooth.State.TurningOn:
          {
            imgResource = Resource.Drawable.bluetooth_off;
            break;
          }

        case Android.Bluetooth.State.On:
        case Android.Bluetooth.State.TurningOff:
          {
            imgResource = Resource.Drawable.bluetooth_on;
            break;
          }

        default:
          {
            imgResource = Resource.Drawable.bluetooth_off;
            break;
          }
      }

      remoteViews.SetImageViewResource(Resource.Id.imgBluetooth, imgResource);
      appWidgetManager.UpdateAppWidget(thisWidget, remoteViews);
    }
  }
}