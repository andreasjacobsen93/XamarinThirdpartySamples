How to Truncate and Wrap Text in a UILabel
=========================================

It is possible to change how text appears when it is too long for a given <code>UILabel</code>   This recipe illustrates the possible ways to truncate text using <code>UILineBreakMode</code>. 

![UILabel Example](/UILabelExample/Screenshots/UILabelScreenshot.png)

Recipe
=====

<ol>

      <li><p><code>CharacterWrap</code> sets the text in the UILabel to wrap at the first character that doesn't fit. We can set a <code>UILabel</code> to this mode with the following line of code:</p>
      
      <pre><code>CharWrapLabel.LineBreakMode = UILineBreakMode.CharacterWrap;</code></pre>
      <p>We can put this, and all other <code>UILabel</code> manipulations inside the <code>ViewDidLoad</code> method of the <code>ViewController</code>, or whatever method you are using to manipulate the UI element.</p>
      </li>
      
      <li><p><code>Clip</code> mode has the text which does not fit to remain unrendered. We can set a  <code>UILabel</code> to this mode with the following line of code:</p>
      
      <pre><code>ClipLabel.LineBreakMode = UILineBreakMode.Clip;</code></pre>
      </li>
      
      <li><p><code>HeadTruncation</code> mode has the <code>UILabel</code> show the end of the text and truncates the head to an ellipse. We can set a  <code>UILabel</code> to this mode with the following line of code:</p>
      
      <pre><code>HeadLabel.LineBreakMode = UILineBreakMode.HeadTruncation;</code></pre>
      </li>
      
      <li><p><code>MiddleTruncation</code> mode has the <code>UILabel</code> show the start and end of the text and truncates the middle to an ellipse. We can set a  <code>UILabel</code> to this mode with the following line of code:</p>
      
      <pre><code>MiddleLabel.LineBreakMode = UILineBreakMode.MiddleTruncation;</code></pre>
      </li>
      
      <li><p><code>TailTruncation</code> mode has the <code>UILabel</code> show the start of the text and truncates the end to an ellipse. We can set a  <code>UILabel</code> to this mode with the following line of code:</p>
      
      <pre><code>TailLabel.LineBreakMode = UILineBreakMode.TailTruncation;</code></pre>
      </li>
      
      <li><p><code>WordWrap</code> mode has the <code>UILabel</code> wrap the first word that does not fit. We can set a  <code>UILabel</code> to this mode with the following line of code:</p>
       
      <pre><code>TailLabel.LineBreakMode = UILineBreakMode.WordWrap;</code></pre>
      </li>
		
		
</ol>
