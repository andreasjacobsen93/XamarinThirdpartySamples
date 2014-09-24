Getting the Screen Size
=======================

![iPhone Size](/ScreenSize/ScreenShots/iphone.png)

![iPad Size](/ScreenSize/ScreenShots/ipad.png)

When writing iOS apps targeting multiple devices, it can be helpful to get the screen size of the device for device specific implementations. This recipe describes how to get the size of the device screen in pixels.

Recipe
======

In order to get the screen size, first get the bounds of the <code>MainScreen</code>:

<code>RectangleF screenRect = UIScreen.MainScreen.Bounds;</code>

Once we have the <code>RectangleF</code> representing the screen, we can get the height and width as follows:

<code>
float height = screenRect.Height;
float width = screenRect.Width;
</code>