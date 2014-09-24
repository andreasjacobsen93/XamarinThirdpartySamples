Android Alert Dialog
===================

Alert dialogs are the choose-your-own-adventure of Android - they let the user decide how to proceed in response to some event. This recipe illustrates the creation of a simple two-button dialog using the Android AlertDialog Builder.

![Android Alert Dialog](/AlertDroid/Screenshots/alert.png)

Recipe
======

<ol>
<li>Create a new instance of the <code>AlertDialog.Builder</code>:

<pre><code>AlertDialog.Builder dialog = new AlertDialog.Builder (this);</code></pre>
</li>
<li>
Set properties on the dialog. We can specify things such as title, message, and icon:

<pre><code>dialog.SetTitle ("My Alert Dialog");
dialog.SetIcon (Resource.Drawable.Icon);
dialog.SetMessage ("Add to click count?");
dialog.SetNeutralButton ("OK", delegate {
	// add code to handle user press here
});
dialog.SetNegativeButton ("Cancel", delegate {
	// add code to handle user press here
});</code></pre>

There are three button types available in an Android dialog: positive, negative, and neutral. When we set the button, we specify the button text as well as the delegate to respond to the user's action.
</li>
<li>
Finally, we show the dialog:

<pre><code>dialog.Show ();</code></pre>
</li>
</ol>