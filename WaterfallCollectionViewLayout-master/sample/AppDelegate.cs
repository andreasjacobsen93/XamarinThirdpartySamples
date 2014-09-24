using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using WaterfallCollectionViewLayout;

namespace WaterfallCollectionViewLayoutDemo
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		// Important: Remember to keep class-level references to your objects,
		// or they may be garbage collected when they fall out of scope.
		List<float> cellHeights;
		PBCollectionViewDelegateWaterfallLayout collectionViewDelegate;
		PBCollectionViewWaterfallLayout collectionViewLayout;
		WaterfallCollectionViewController collectionViewController;
		List<Tag> tags;

		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			SetupLayout ();

			collectionViewController = new WaterfallCollectionViewController (collectionViewLayout, tags);
			window.RootViewController = collectionViewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}

		// Sets up the layout for use by WaterfallCollectionViewController
		private void SetupLayout ()
		{
			PopulateTags ();
			CalculateCellHeights ();

			collectionViewDelegate = new WaterfallDelegate (cellHeights);

			collectionViewLayout = new PBCollectionViewWaterfallLayout () 
			{
				ColumnCount = 2,
				ItemWidth = 129,
				Delegate = collectionViewDelegate,
				SectionInset = new UIEdgeInsets (9, 9, 9, 9)
			};
		}

		// Represents sample data that would normally be pulled via a local database or
		// web service.
		private void PopulateTags ()
		{
			tags = new List<Tag> ();
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock1.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock2.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock3.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock1.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock2.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock3.png") });
			tags.Add (new Tag { Name = "Test", Image = UIImage.FromFile ("Stock1.png") });
		}

		// Important: This method calculates the heights of each cell, which, if not done correctly
		// will cause significant issues in drawing cells. Depending on your UICollectionViewCell, you
		// may just end up adding static content (that never changes) heights with dynamic heights calculated
		// from the data used to populate the cells.
		private void CalculateCellHeights ()
		{
			cellHeights = new List<float> ();

			foreach (var tag in tags) 
			{
				var height = tag.Image.Size.Height;
				cellHeights.Add (height);
			}
		}
	}
}