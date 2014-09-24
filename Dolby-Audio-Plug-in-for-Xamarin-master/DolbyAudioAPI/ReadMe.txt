The DolbyAPI solution contains two projects:

DolbyAPI: a Xamarin.Android java binding project for the Dolby API 
DolbyTest: a Xamarin.Android test appication demonstrates the API in C#

*** Required ***

Xamarin.Android http://www.xamarin.com 

The Dolby Android Java API http://developer.dolby.com/tools-tech.aspx

At the time of writing it's been tested with both versions 1.0.0 & 1.1.0

To hear the Dolby API working you'll need an Andrdoid device with Dolby hardware.  
Ex: Kindle Fire HD, Kindle Fire HDX, etc.

*** Installation ***

Download the Android Dolby API http://developer.dolby.com/tools-tech.aspx
Extract the dolby_audio_processing.jar from the Library folder
Add dolby_audio_processing.jar to the "Jars" folder of the DolbyAPI project
Make sure the build action is set to "EmbeddedJar"

*** Running the test App ***

Once you've completed the Installation you should be able to build the DolbyAPI project. 
The DolbyTest project references a DLL created by the DolbyAPI.

You should now be able to run/debug the DolbyTest project on an Android device containing Dolby hardware.

*** About ***

This source code can be used without restrictions.

You can find the latest version on github:
https://github.com/adrianstevens/XamarinAndroid-Dolby

If you'd like contribute improvements please e-mail info@beetrootsoftware.com 

DolbyAPI Solution was created by Adrian Stevens & BeetRoot Software
For more information please visit:
http://www.beetrootsoftware.com
http://www.themethodology.net

The MP3 sage.mp3 in the DolbyTest project is an original composition by Adrian Stevens

This project is not associated with Dobly Laboratories Inc. or Xamarin Inc.

