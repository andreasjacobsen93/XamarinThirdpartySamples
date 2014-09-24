using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace WaterfallCollectionViewLayoutDemo
{
	public class WaterfallCell : UICollectionViewCell
	{
		public UITextField DisplayLabel { get; set; }
		public UIImageView PlaceholderImage { get; set; }

		[Export ("initWithFrame:")]
		public WaterfallCell (RectangleF frame) : base (frame)
		{
			DisplayLabel = new UITextField () 
			{
				BackgroundColor = UIColor.White,
				Font = UIFont.FromName ("SourceSansPro-Bold", 15f),
				Frame = new RectangleF (0, 0, 129, 18),
				TextAlignment = UITextAlignment.Center,
				TextColor = UIColor.LightGray
			};

			PlaceholderImage = new UIImageView () 
			{
				AutoresizingMask = UIViewAutoresizing.FlexibleHeight,
				Frame = new RectangleF (0, DisplayLabel.Bounds.Height, 0, 0)
			};

			ContentView.Add (DisplayLabel);
			ContentView.Add (PlaceholderImage);
		}

		public void PopulateCell (string title, UIImage image)
		{
			DisplayLabel.Text = "# " + title.ToUpper ();
			PlaceholderImage.Image = image;

			PlaceholderImage.Frame = new RectangleF (0, DisplayLabel.Bounds.Height,  129, image.Size.Height);
		}
	}
}

