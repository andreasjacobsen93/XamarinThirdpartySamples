using System;
using System.Drawing;
using System.Collections.Generic;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WaterfallCollectionViewLayout
{
	public abstract class PBCollectionViewDelegateWaterfallLayout : UICollectionViewDelegate
	{
		public PBCollectionViewDelegateWaterfallLayout (List<float> cellHeights) { }

		public abstract float HeightForItem (UICollectionView collectionView, PBCollectionViewWaterfallLayout collectionViewLayout, NSIndexPath indexPath);
	}
}

