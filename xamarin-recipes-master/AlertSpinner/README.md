Show Spinner in an Alert Dialog
===============================

Android spinners are dropdown menus that present an easy way to select an item out of a set. This recipe demonstrates how to add a spinner to an Alert Dialog.

![screen](/AlertSpinner/Screenshots/01.png)
![dialog](/AlertSpinner/Screenshots/02.png)
![spinner](/AlertSpinner/Screenshots/03.png)
![selection](/AlertSpinner/Screenshots/04.png)

Recipe
======
<ol>
<li>
<p>First, we need a data set to populate the spinner. In our example, we'll create a simple array of strings:</p>
<pre><code>string[] villains = { "Citizen Dawn", "Baron Blade", "Omnitron", "Plague Rat", "The Dreamer", "Gloom Weaver", "Kismet", "Iron Legacy" };</code></pre>

<p>We'll need an <code>ArrayAdapter</code> to populate the spinner with the <code>villains</code> array, so let's create one:</p>
<pre><code>ArrayAdapter<String> adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerItem, villains);</code></pre>
</li>
<li>
<p>Next, let's create the spinner. We'll add some layout parameters to ensure the spinner is big enough to hold all of its content, and we'll set the <code>Adapter</code> to the adapter we just created:</p>
<pre><code>Spinner spinner = new Spinner(this);
spinner.LayoutParameters = new LinearLayout.LayoutParams (ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
spinner.Adapter = adapter;</code></pre>
</li>
<li>
<p>Next, we'll build out the Alert Dialog and set the spinner as the view:</p>
<pre><code>AlertDialog.Builder builder = new AlertDialog.Builder(this);
builder.SetView(spinner);
builder.SetNeutralButton("OK", delegate {});
builder.Show();</code></pre>
</li>
<li>
<p>To handle user item selection, we'll add a handler to the spinner's <code>ItemSelected</code> event, as illustrated by the code below:</p>
<pre><code>spinner.ItemSelected += new EventHandler<AdapterView.ItemSelectedEventArgs> (ItemSelected);</code></pre>
</li>
<li>
<p>Finally, we'll get the user-selected value by calling <code>GetItemAtPosition</code>:</p>
<pre><code>void ItemSelected (object sender, AdapterView.ItemSelectedEventArgs e)
{
	Spinner spinner = (Spinner)sender;
	button.Text = "Villain: " + spinner.GetItemAtPosition (e.Position);
}</code></pre>
</li>
</ol>
