using System;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using WaterfallCollectionViewLayout;

namespace WaterfallCollectionViewLayoutDemo
{
	public class WaterfallDelegate : PBCollectionViewDelegateWaterfallLayout
	{
		List<float> cellHeights;

		public WaterfallDelegate (List<float> cellHeights) : base (cellHeights)
		{
			this.cellHeights = cellHeights;
		}

		// Important: The only method that the delegate *has* to override. Just return the value the cell's height, which you have usually calculated
		// beforehand.
		public override float HeightForItem (UICollectionView collectionView, PBCollectionViewWaterfallLayout collectionViewLayout, NSIndexPath indexPath)
		{
			return cellHeights [indexPath.Row];
		}
	}
}

