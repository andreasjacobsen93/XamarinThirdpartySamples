Launch Map by URI
========================

iOS apps utilize uniform resource locators (URLs), a form of uniform resource identifiers (URIs), to communicate with system apps. By calling the <code>OpenURL(NSUrl url)</code> method on the main application class, it is possible to launch the Maps application already focused on a specific location. 

![App Screen](/OpenMapsURI/Screenshots/app.png)

![Map Screen](/OpenMapsURI/Screenshots/map.png)

Recipe
======

<ol>
  
  <li><p>First, we must generate a <code>NSUrl</code> starting with the path <code>"http://maps.apple.com/?q="</code> appended to the location we wish to bring up in Maps.  For this example, lets place the following code in the <code>callMap</code> <code>TouchUpInside</code> event handler:</p>
  
  <pre><code>String cityAddress = cityText.Text.Replace (' ', '+');
			 var url = new NSUrl ("http://maps.apple.com/?q="+ cityAddress);</code></pre>
  </li>
  
  <li><p>Since the <code>NSUrl</code> cannot contain space characters, we replace them with <code>'+'</code> characters.To open Maps, we would place the following code after we generate our <code>NSUrl</code> variable:</p>
  
    <pre><code>UIApplication.SharedApplication.OpenUrl (url);</code></pre>
  
<p>This code will cause the Maps application to open, searching for the location entered in the <code>cityText</code> UILabel.</p>

</ol>

Additional Information
======================

There are a variety of parameters that can be appended onto <code>"http://maps.apple.com/?"</code> that can specify the information loaded by the Maps app. In this example, we used the query parameter, <code>"q="</code>, which loads the following string as if it had been typed into the query box in the Maps app. To see all available parameters, see the [Apple URL Scheme Reference](https://developer.apple.com/library/ios/featuredarticles/iPhoneURLScheme_Reference/MapLinks/MapLinks.html)




 
  
    
					     
  
