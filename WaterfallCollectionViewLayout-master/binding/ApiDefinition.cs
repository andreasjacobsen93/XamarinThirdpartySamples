using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WaterfallCollectionViewLayoutBinding
{
	[Model]
	[BaseType (typeof(UICollectionViewDelegate))]
	public partial interface UICollectionViewDelegateWaterfallLayout
	{
		[Export ("collectionView:layout:heightForItemAtIndexPath:")]
		float CollectionView (UICollectionView collectionView, UICollectionViewWaterfallLayout collectionViewLayout, NSIndexPath indexPath);
	}

	[BaseType (typeof (UICollectionViewLayout))]
	public partial interface UICollectionViewWaterfallLayout 
	{
		[Export ("delegate", ArgumentSemantic.Assign)]
		UICollectionViewDelegateWaterfallLayout Delegate { get; set; }

		[Export ("columnCount")]
		uint ColumnCount { get; set; }

		[Export ("itemWidth")]
		float ItemWidth { get; set; }

		[Export ("sectionInset", ArgumentSemantic.Assign)]
		UIEdgeInsets SectionInset { get; set; }
	}
}

