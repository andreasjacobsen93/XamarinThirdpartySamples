Handle Button Click in Android
===============================

This recipe illustrates three ways of wiring a button in Android.

![buttons before](/ButtonDroid/Screenshots/01.png)
![buttons after](/ButtonDroid/Screenshots/02.png)

Recipe
======
![buttons in designer](/ButtonDroid/Screenshots/03.png)
<ol>
<li>
<p>First, we'll open our layout file in the Android designer and drag three buttons onto the design surface. We'll edit the properties to give each button a unique id, as illustrated by the screenshot above.</p>
</li>

<li>
<p>Next, in our backing Activity, we'll add the following code to get a reference to the button objects:</p>
<pre><code>Button onclick = FindViewById<Button> (Resource.Id.button1);
Button del = FindViewById<Button> (Resource.Id.button2);
Button lambda = FindViewById<Button> (Resource.Id.button3);</code></pre>
</li>

<li>
<p>We'll wire up the first button by giving it a named event handler, as illustrated by the code below:</p>
<pre><code>onclick.Click += OnClick;</code></pre>
<p>Then, we'll create the <code>OnClick</code> method:</p>
<pre><code>void OnClick (object sender, EventArgs e)
{
  Button button = (Button)sender;
  button.Text = "Click handled by OnClick method";
}</code></pre>
</li>
<li>
<p>Next, we'll wire up the second button and handle the click using a delegate:</p>
<pre><code>del.Click += delegate {
  del.Text = string.Format ("Click handled with delegate");
};</code></pre>
</li>
<li>
<p>Finally, we'll handle the third button's click event with a lambda, as in the code below:</p>
<pre><code>lambda.Click += (o, e) => {
  lambda.Text = string.Format ("Click handled with lambda");
};</code></pre>



</ol>
