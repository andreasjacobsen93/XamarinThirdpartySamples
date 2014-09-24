Storyboard Tables
====================

It is possible to use a Storyboard to create custom Table Views. This recipe demonstrates how to create both Dynamic Prototype and Static content for cells in a table using the Storyboard. For a more in-depth guide, visit the [Walkthrough](http://developer.xamarin.com/guides/ios/user_interface/tables/part_5_-_creating_Tables_in_a_Storyboard/).

Recipe
======

To create a Storyboard-based application using a TableView:
<p>Create a new solution in Xamarin Studio using <strong>File > Solution > iOS > iPhone Storyboard > Master-Detail Application<strong>. </p>

![Create Project](/StoryboardTable/Screenshots/image14a.png)
<p>Double-click the <code>.storyboard</code> file to open it in the iOS Designer:</p>
![iOS Designer](/StoryboardTable/Screenshots/image20a.png)

We will modify the storyboard in three steps:
<ol>
    <li><p> First, we will layout the required view controllers and set their properties.</p></li>
        <li><p>Secondly, we will create the UI by dragging and dropping objects onto the view.</p></li>
        <li><p>Finally, we will add the required UIKit class to each view and give various controls a name.</p></li>
</ol>
<p>Once the storyboard is complete, code can be added to run the table.</p>

Layout The View Controllers
===========================

Let's follow these steps to delete the existing Detail view and replace it with a UITableViewController:
<ol>
    <li><p>Select the black bar at the bottom of the Detail View and delete it.</p></li>
    <li><p>Drag a UITableViewController onto the Storyboard from the Object Library.</p></li>
    <li><p>Create a segue from the Master View Controller to the View Controller that was just added. To create the segue, Control+drag from the Detail cell to the newly added UITableViewController. Choose the option Push under Segue Selection</p></li>
    <li><p>Select the new segue you created and give it an identifier to reference this segue in code. Click on the segue and enter “TaskSegue” for the Identifier in the Properties Pad, like this:</p></li>
</ol>

![Segue](/StoryboardTable/Screenshots/image16a.png)

<p>Next, change the following settings:</p>
<ol>
    <li><p>Change the Master View to be <em>Content: Dynamic Prototypes<em> (the View on the Design Surface will be labelled *Prototype Content*).</p></li>
    <li><p>Change the new UITableViewController to be <em>Content: Static Cells</em>.</p></li>
    <li><p>Select the View Controller and type <em>TaskDetailViewController</em> for the Class in the Properties Pad.</p></li>
    <li><p>Finally, enter the StoryboardID as detail, illustrated in the example below.</p></li>
</ol>

![Storyboard ID](/StoryboardTable/Screenshots/image18a.png)

<p>Once we change the Master view's title to "Choreboard", the storyboard design surface should look like this:</p>
![Storyboard ID](/StoryboardTable/Screenshots/image20a.png)

Create the UI
=============
First, select the prototype cell in the Master View Controller and set the Identifier as <em>taskcell</em>, as illustrated below: 
![Storyboard ID](/StoryboardTable/Screenshots/image22a.png)
Next, follow these steps to create a button that will add new tasks:
<ol>
    <li><p>Drag a Bar Button Item from the Toolbox into the navigation bar</p></li>
    <li><p>In the Properties Pad, under Bar Button Item select Identifier: Add (to make it a + plus button).</p></li>
    <li><p>Enter "AddButton" as the Name. This will enable us to refer to it in code at a later stage.</p></li>
</ol>
Now we must build the DetailView. The screenshot below shows the finished UI:
![Storyboard ID](/StoryboardTable/Screenshots/image24a.png)
<p>To build the complete layout, first select the table view and open the Property Pad. Update the following properties as follows:</p>
<ol>
    <li><p>Sections: <strong>2</strong></p></li>
    <li><p>Style: <strong>Grouped</strong></p></li>
    <li><p>Seperator: <strong>None</strong></p></li>
    <li><p>Selection: <strong>No Selection</strong></p></li>
</ol> 
<p>Now, select the top section of the DetailView and under <strong>Properties > Table View Section</strong> change rows to '3', as illustrated below:</p>
![Storyboard ID](/StoryboardTable/Screenshots/image29.png)
<p>For each cell in Section 1 open the Properties Pad and set:</p>
<ol>
    <li><p>Style: <strong>Custom</strong></p></li>
    <li><p>Identifier: <strong>choose a unique identifier for each cell (eg. “title”, “notes”, “done”).</strong></p></li>
    <li><p>Drag the required controls to produce the layout shown in the screenshot (place UILabel, UITextField and UISwitch on the correct cells, and set the labels appropriately, ie. Title, Notes and          Done).</p></li>
    <li><p>Selection: <strong>No Selection</strong></p></li>
</ol>

<p>In the second section, set the number of Rows to 1 and grab the bottom resize handle to make it taller. Select the cell in the Properties pad and set:</p>

<ol>
    <li><p>Identifier: <strong>to a unique value in the Property Pad(eg. “save”)</strong>.</p></li>
    <li><p>Background: <strong>Clear Color</strong></p></li>
    <li><p>Drag two buttons onto the cell and set their titles appropriately (i.e. Save and Delete).</p></li>
</ol>

<p>The last step in creating our Storyboard is giving each of our controls a name under <strong>Identity > Name</strong>. Name these as follows: </p>

<ol>
    <li><p>Title UITextField: <strong>TitleText</strong></p></li>
    <li><p>Notes UITextField: <strong>NotesText</strong></p></li>
    <li><p>UISwitch: <strong>DoneSwitch</strong></p></li>
    <li><p>Delete UIButton: <strong>DeleteButton</strong></p></li>
    <li><p>Save UIButton: <strong>SaveButton</strong></p></li>
</ol>

Adding Code
===========

Our storyboard is now complete, now we must add code to run the application.

<p>First, create a Chores class and add the following code:</p>

<pre><code>public class Chore {

    public Chore ()
    {
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Notes { get; set; }
    public bool Done { get; set; }
  }</code></pre>

<p>Next, create a <code>RootTableSource</code> class that inheirits from <code>UITableViewSource</code>. Populate the class with the following code:</p>

<pre><code> 
public class RootTableSource : UITableViewSource {

    // there is NO database or storage of Tasks in this example, just an in-memory List<>
    Chore[] tableItems;
    string cellIdentifier = "taskcell"; // set in the Storyboard

    public RootTableSource (Chore[] items)
    {
      tableItems = items; 
    }
    public override int RowsInSection (UITableView tableview, int section)
    {
      return tableItems.Length;
    }
    public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
    {
      // in a Storyboard, Dequeue will ALWAYS return a cell, 
      UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
      // now set the properties as normal
      cell.TextLabel.Text = tableItems[indexPath.Row].Name;
      if (tableItems[indexPath.Row].Done) 
        cell.Accessory = UITableViewCellAccessory.Checkmark;
      else
        cell.Accessory = UITableViewCellAccessory.None;
      return cell;
    }
    public Chore GetItem(int id) {
      return tableItems[id];
    }
  }</code></pre>
  
<p>Next, replace the code in the <code>MasterViewController</code> with the following code: </p>

<pre><code>using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
namespace StoryboardTable
{
	public partial class MasterViewController : UITableViewController
	{
		List<Chore> chores;

		public MasterViewController (IntPtr handle) : base (handle)
		{
			Title = "ChoreBoard";

			// Custom initialization
			chores = new List<Chore> {
			new Chore() {Name="Groceries", Notes="Buy bread, cheese, apples", Done=false},
			new Chore() {Name="Devices", Notes="Buy Nexus, Galaxy, Droid", Done=false}
		};

		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "TaskSegue") { // set in Storyboard
				var navctlr = segue.DestinationViewController as TaskDetailViewController;
				if (navctlr != null) {
					var source = TableView.Source as RootTableSource;
					var rowPath = TableView.IndexPathForSelectedRow;
					var item = source.GetItem(rowPath.Row);
					navctlr.SetTask (this, item); // to be defined on the TaskDetailViewController
				}
			}
		}

		public void CreateTask () 
		{
			// first, add the task to the underlying data
			var newId = chores[chores.Count - 1].Id + 1;
			var newChore = new Chore(){Id=newId};
			chores.Add (newChore);

			// then open the detail view to edit it
			var detail = Storyboard.InstantiateViewController("detail") as TaskDetailViewController;
			detail.SetTask (this, newChore);
			NavigationController.PushViewController (detail, true);
		}

		public void SaveTask (Chore chore)
		{
			var oldTask = chores.Find(t => t.Id == chore.Id);
			oldTask = chore;
			NavigationController.PopViewControllerAnimated(true);
		}

		public void DeleteTask (Chore chore) 
		{
			var oldTask = chores.Find(t => t.Id == chore.Id);
			chores.Remove (oldTask);
			NavigationController.PopViewControllerAnimated(true);
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		#region View lifecycle

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			AddButton.Clicked += (sender, e) => {
				CreateTask ();
			};
		}
			

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			// bind every time, to reflect deletion in the Detail view
			TableView.Source = new RootTableSource(chores.ToArray ());
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}

		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}

		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}

		#endregion


	}
}
</code></pre>

<p>Next, replace the <code>TaskDetailViewController</code> with the following code:</p>

<pre><code>
using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.CodeDom.Compiler;
namespace StoryboardTable
{
	partial class TaskDetailViewController : UITableViewController
	{
		Chore currentTask {get;set;}
		public MasterViewController Delegate {get;set;} // will be used to Save, Delete later

		public TaskDetailViewController (IntPtr handle) : base (handle)
		{
				
		}

		// when displaying, set-up the properties
		public override void ViewDidLoad()
		{
			base.ViewDidLoad ();

			SaveButton.TouchUpInside += (sender, e) => {
				currentTask.Name = TitleText.Text;
				currentTask.Notes = NotesText.Text;
				currentTask.Done = DoneSwitch.On;
				Delegate.SaveTask(currentTask);
			};
			DeleteButton.TouchUpInside += (sender, e) => {
				Delegate.DeleteTask(currentTask);
			};
		}

		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			TitleText.Text = currentTask.Name;
			NotesText.Text = currentTask.Notes;
			DoneSwitch.On = currentTask.Done;
		}

		// this will be called before the view is displayed
		public void SetTask (MasterViewController d, Chore task) {
			Delegate = d;
			currentTask = task;
		}
	}
}
</code></pre>

When run, the app should look as follows:
![Screenshots](/StoryboardTable/Screenshots/image28a.png)

