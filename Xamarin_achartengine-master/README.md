Xamarin_achartengine
====================

An example for using achartengine library for Xamarin. Building a java binding for the jar library.

A Xamarin Java binding library for the AChartEngine.

Contains 2 project:-

1. Java binding for the [achartengine library](https://code.google.com/p/achartengine/ "achartengine")
2. A sample Xamarin.Android app to use the java binding project.
You can get the java-binding project and use it directly and create a wounderfuel charts :)

Steps of creating the java-binding project:-
====================

1. Create a new Android Java Bindings Library Project.
2. Add the .jar to Jars folder. 3- set the build action to EmbededJar.
3. add these lines to Metadata.xml
```
<attr path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine']/method[@name='getType' and count(parameter)=0]" name="managedName">GetBehaviorType</attr>
<attr path="/api/package[@name='org.achartengine.renderer']/class[@name='XYSeriesRenderer.FillOutsideLine.Type']" name="managedName">FillOutsideLineBehaviorType</attr>
<attr path="/api/package[@name='org.achartengine']" name="managedName">AChartEngine</attr>
<attr path="/api/package[@name='org.achartengine.chart']" name="managedName">AChartEngine.Chart</attr>
<attr path="/api/package[@name='org.achartengine.model']" name="managedName">AChartEngine.Model</attr>
<attr path="/api/package[@name='org.achartengine.renderer']" name="managedName">AChartEngine.Renderer</attr>
<attr path="/api/package[@name='org.achartengine.tools']" name="managedName">AChartEngine.Tools</attr>
<attr path="/api/package[@name='org.achartengine.util']" name="managedName">AChartEngine.Util</attr>
<attr path="/api/package[@name='org.achartengine.tools']/class[@name='Pan']/method[@name='addPanListener']" name="eventName">PanEvent</attr>
```

Screen shot
--------
![alt text](/images/chartengine.PNG "screenshot")
