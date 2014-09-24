Customizing a UISwitch
======================

![Custom UISwitch](/CustomUISwitch/Screenshots/CustomUISwitch.png)

This recipe describes how to use the <code>On</code>, <code>OnTintColor</code>, and <code>ThumbTintColor</code> properties to control <code>UISwitch</code> appearance. 


Recipe
======


* <p>We can set the boolean <code>On</code> property to control the state of the <code>UISwitch</code>. Let's add the following code in our <code>ViewDidLoad()</code> method to disable the switch:</p>

<pre><code>CustomSwitch.On = false; </code></pre>

* <p>We can use the <code>OnTintColor</code> property to set the fill color of the <code>UISwitch</code> while it's switched on. This can be done after any event, but to initialize our <code>UISwitch</code> with this setting, let's add the following code in our <code>ViewDidLoad()</code> method: </p>

<pre><code>CustomSwitch.OnTintColor = UIColor.Purple;</code></pre>

* <p>Let's set the <code>TintColor</code> property to control the outline color of the <code>UISwitch</code> while it's switched off. Let's add the following code to our <code>ViewDidLoad()</code> method to initialize a custom <code>UIColor</code> and set it to be the <code>TintColor</code>:</p> 

<pre><code>UIColor lightP = UIColor.FromRGB (184, 152, 205);
CustomSwitch.TintColor = lightP;</code></pre>
		 
* <p>Next, we can set the <code>ThumbTintColor</code> property to determine the fill color of Thumb slider in our <code>UISwitch</code>. Let's add the following code in our <code>ViewDidLoad()</code> method:</p>

<pre><code>CustomSwitch.ThumbTintColor = lightP;</code></pre>

* <p>We can handle value changes in our <code>UISwith</code> by placing the following code in your <code>ViewDidLoad()</code> method:</p>

<pre><code>CustomSwitch.ValueChanged += delegate {
 		//Check to see new value, change Switch Label Accordingly 
		if (CustomSwitch.On) {
			// Handle "On" events here
			SwitchLabel.Text = "Switch is on";
		} else {
			// Handle "Off" events here
			SwitchLabel.Text = "Switch is off";
			}
};</code></pre> 

Additional Information
======================

The <code>OnImage</code> and <code>OffImage</code> properties have no effect in iOS 7. 
