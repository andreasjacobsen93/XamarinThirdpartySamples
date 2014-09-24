### Building a Bluetooth status widget with Xamarin

![bluetooth logo](https://github.com/wislon/xamarin-bluetooth-status-widget/blob/master/src/BluetoothWidget/Resources/drawable-xhdpi/bluetooth_on.png)![bluetooth logo](https://github.com/wislon/xamarin-bluetooth-status-widget/blob/master/src/BluetoothWidget/Resources/drawable-xhdpi/bluetooth_off.png)

This is an example of how to build a simple status widget in Xamarin, using the Bluetooth adapter as a source.

It demonstrates:

* Building a class with the right properties and attributes to be treated as a widget
* Setting up a `BroadcastReceiver` to receive intents.
* Capturing specific intents related to widget updates and bluetooth adapter state changes
* Managing the behaviour and display of the widget UI based on those intents.

The project can be opened and built in either Xamarin Studio or Visual Studio (with the Xamarin add-in installed).

There's a blog post detailing exactly how it all fits together over on my blog at [wislon.io](http://blog.wislon.io/posts/2014/08/01/building-a-bluetooth-status-widget-with-xamarin/)

_It's published under the MIT license, so it's quite permissive. However one of the images is provided by a third-party, and was distributed as freeware, not for commercial use, so as it stands, it can't be sold onwards._


