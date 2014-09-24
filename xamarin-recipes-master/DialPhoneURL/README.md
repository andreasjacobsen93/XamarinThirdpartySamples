Dialing the Phone by URI
========================

iOS apps utilize uniform resource locators (URLs), a form of uniform resource identifiers (URIs), to access schemes that integrate with system apps. The <code>tel</code> URL scheme launches the Phone app and dials the number contained in the <code>NSUrl</code>.

![Dial By URI](/DialPhoneURL/Screenshots/Screenshot.png)

Recipe
======

<ol>
  
  <li><p>First, we must generate a <code>NSUrl</code> from the string <code>"tel:"</code> appended to the number we want to dial. For this example, lets place the following code in the <code>CallButton</code> <code>TouchUpInside</code> event handler:</p>
  
  <pre><code>var url = new NSUrl ("tel:" + PhoneTextField.Text);</code></pre>
  </li>
  
  <li><p>To create a scheme to access the Phone app, we would place the following code after we generate our <code>NSUrl</code> variable:</p>
  
    UIApplication.SharedApplication.OpenUrl (url);
  
  <li><p>Since emulators don't support the system Phone app, we should instead attempt to create our scheme inside the following conditional statement:</p>
  
    if (!UIApplication.SharedApplication.OpenUrl (url)) {
    	var av = new UIAlertView ("Not supported",
	      "Scheme 'tel:' is not supported on this device",
          null,
	      "OK",
		  null);
	    av.Show ();
    };
					     
  <p>If the scheme cannot be generated, we alert the user using a <code>UIAlertView</code>.
  
  
