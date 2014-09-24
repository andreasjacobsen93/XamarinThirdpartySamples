using System;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using WaterfallCollectionViewLayout;

namespace WaterfallCollectionViewLayoutDemo
{
	public class WaterfallCollectionViewController : UICollectionViewController
	{
		List<Tag> data;

		static NSString CELL_IDENTIFIER = new NSString ("WATERFALL_CELL");

		public WaterfallCollectionViewController (UICollectionViewLayout layout, List<Tag> tags): base (layout)
		{
			data = tags;

			CollectionView.BackgroundColor = UIColor.FromPatternImage (UIImage.FromFile ("Background.png"));
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			CollectionView.RegisterClassForCell (typeof (WaterfallCell), CELL_IDENTIFIER);

			View.AddSubview (CollectionView);
		}

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			UpdateLayout ();
		}

		// Important: Make sure your UpdateLayout () is similar to this. Call UpdateLayout () whenever something
		// changes, like the view appearing or an orientation change.
		private void UpdateLayout ()
		{
			var layout = (PBCollectionViewWaterfallLayout)CollectionView.CollectionViewLayout;
			layout.ColumnCount = (int)(CollectionView.Bounds.Size.Width / Constants.CellWidth);
			layout.ItemWidth = Constants.CellWidth;
		}

		public override int NumberOfSections (UICollectionView collectionView)
		{
			return 1;
		}

		public override int GetItemsCount (UICollectionView collectionView, int section)
		{
			return data.Count;
		}

		public override void ItemSelected (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = data [indexPath.Row];
			var message = string.Format ("You clicked on {0}!", cell.Name);

			new UIAlertView ("Clicked", message, null, "Okay", null).Show ();
		}


		public override UICollectionViewCell GetCell (UICollectionView collectionView, NSIndexPath indexPath)
		{
			var cell = (WaterfallCell) collectionView.DequeueReusableCell (CELL_IDENTIFIER, indexPath);
			var tag = data[indexPath.Row];

			cell.PopulateCell (tag.Name, tag.Image);

			return cell;
		}
	}
}

