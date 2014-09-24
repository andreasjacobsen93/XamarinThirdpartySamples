Setting the Focus to a UITextField
==================================

We can manually change the focus of a view to bring up the keyboard for entry in a <code>UITextField</code> without tapping it. 

![Focus Screen](/SetUITextFieldFocus/ScreenShots/focusScreenShot.png)

Recipe 
======

<p>To have our <code>UITextField</code>, in this case named <code>FocusTextField</code>, selected as soon as we open the view, we can place the following line of code in the <code>ViewDidLoad ()</code> method:</p>

<pre><code>FocusTextField.BecomeFirstResponder ();</code></pre>



Additional Information
----------------------

We can call <code>BecomeFirstResponder ()</code> on a <code>UITextField</code> at any point to switch focus - not just inside <code>ViewDidLoad ()</code>.
