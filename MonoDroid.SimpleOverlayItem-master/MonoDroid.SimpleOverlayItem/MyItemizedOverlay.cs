using System.Collections.Generic;
using System.Linq;

using Android.Content;
using Android.GoogleMaps;
using Android.Graphics.Drawables;
using Android.Graphics;

namespace MonoDroid.SimpleOverlayItem
{
    class MyItemizedOverlay : ItemizedOverlay
    {
        private List<OverlayItem> overlayItems = new List<OverlayItem>();
        private Context context;

        public MyItemizedOverlay(Context context, Drawable drawable)
            //http://mono-for-android.1047100.n5.nabble.com/BoundCenterBottom-and-BoundCenter-on-ItemizedOverlay-return-Drawable-with-wrong-bounds-td5082774.html
            : base(/*BoundCenterBottom(*/drawable/*)*/) 
        {
            this.context = context;
            Populate();
        }

        public override int Size() 
        {
            //Always call Populate() when modifying the overlayItems, otherwise this will throw exceptions.
            return overlayItems.Count;
        }

        public void AddOverlayItem(OverlayItem item)
        {
            overlayItems.Add(item);
            Populate();
        }

        public void RemoveOverlayItem(OverlayItem item)
        {
            overlayItems.Remove(item);
            Populate();
        }

        public void ClearOverlayItems()
        {
            overlayItems.Clear();
            Populate();
        }

        public List<OverlayItem> OverlayItems
        {
            //Remember to call Populate() if modifying this list.
            get { return overlayItems; }
        }

        protected override Java.Lang.Object CreateItem(int index)
        {
            return overlayItems.ElementAt(index);
        }
    }
}