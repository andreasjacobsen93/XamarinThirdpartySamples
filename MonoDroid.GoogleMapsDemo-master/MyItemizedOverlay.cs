using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.GoogleMaps;
using Android.Graphics.Drawables;

namespace MonoDroid.GoogleMapsDemo
{
    [Register("com/google/android/maps/ItemizedOverlay", DoNotGenerateAcw = true)]
    abstract class FixedItemizedOverlay : ItemizedOverlay
    {

        [Register("<init>", "(Landroid/graphics/drawable/Drawable;)V", "")]
        public FixedItemizedOverlay(Android.Graphics.Drawables.Drawable defaultMarker)
            : base(defaultMarker)
        {
        }

        [Register("createItem", "(I)Lcom/google/android/maps/OverlayItem;", "GetCreateItemHelper")]
        protected abstract OverlayItem CreateItem(int index);

        static Delegate cb_CreateItem;
        static Delegate GetCreateItemHelper()
        {
            if (cb_CreateItem == null)
                cb_CreateItem = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, int, IntPtr>)_CreateItem);

            return cb_CreateItem;
        }

        static IntPtr _CreateItem(IntPtr env, IntPtr __self, int index)
        {
            FixedItemizedOverlay self = Java.Lang.Object.GetObject<FixedItemizedOverlay>(__self, JniHandleOwnership.DoNotTransfer);
            OverlayItem value = self.CreateItem(index);
            return JNIEnv.ToJniHandle(value);
        }
    }

    class MyItemizedOverlay : FixedItemizedOverlay
    {
        private List<OverlayItem> overlayItems = new List<OverlayItem>();
        private Context context;

        public MyItemizedOverlay(Context context, Drawable drawable)
            : base(BoundCenterBottom(drawable))
        {
            this.context = context;
            Populate();
        }

        public override int Size()
        {
            return overlayItems.Count;
        }

        public void AddItem(GeoPoint p, string title, string snippet)
        {
            OverlayItem item = new OverlayItem(p, title, snippet);
            overlayItems.Add(item);
            Populate();
        }

        public List<OverlayItem> OverlayItems
        {
            get { return overlayItems; }
        }

        protected override bool OnTap(int index)
        {
            OverlayItem item = (OverlayItem)overlayItems.ElementAt(index);
            AlertDialog.Builder dialog = new AlertDialog.Builder(context);
            dialog.SetTitle(item.Title);
            dialog.SetMessage(item.Snippet);
            dialog.Show();
            return true;
        }

        protected override OverlayItem CreateItem(int index)
        {
            return overlayItems.ElementAt(index);
        }
    }
}