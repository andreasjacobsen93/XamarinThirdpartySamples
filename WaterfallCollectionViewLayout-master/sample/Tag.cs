using System;
using MonoTouch.UIKit;

namespace WaterfallCollectionViewLayoutDemo
{
	public class Tag
	{
		public string Name { get; set; }
		public UIImage Image { get; set; }

		public override string ToString ()
		{
			return string.Format ("[Tag: Name={0}, Image={1}]", Name, Image);
		}
	}
}