using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "LayoutChanges Activity", ParentActivity = typeof(MainActivity))]
    public class LayoutChangeActivity : Activity
    {
        private ViewGroup _containerView;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_layout_changes);

            _containerView = FindViewById<ViewGroup>(Resource.Id.container);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);

            MenuInflater.Inflate(Resource.Menu.activity_layout_changes, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    NavUtils.NavigateUpTo(this, new Intent(this, typeof(MainActivity)));
                    return true;
                case Resource.Id.action_add_item:
                    FindViewById(Android.Resource.Id.Empty).Visibility = ViewStates.Gone;
                    AddItem();
                    return true;
            }
            
            return base.OnOptionsItemSelected(item);
        }

        private void AddItem()
        {
            var newView = (ViewGroup) LayoutInflater.From(this).Inflate(
                Resource.Layout.list_item_example, _containerView, false);

            newView.FindViewById<TextView>(Android.Resource.Id.Text1).Text =
                Countries[_random.Next(0, Countries.Length - 1)];


            var button = newView.FindViewById(Resource.Id.delete_button);
            button.Tag = newView;
            button.Click += (s, e) =>
            {
                var bt = (View)s;
                var removeView = (ViewGroup)bt.Tag;
                _containerView.RemoveView(removeView);

                if (_containerView.ChildCount == 0)
                    FindViewById(Android.Resource.Id.Empty).Visibility = ViewStates.Visible;
            };

            _containerView.AddView(newView, 0);
        }

        private readonly Random _random = new Random();

        private static readonly string[] Countries =
        {
            "Belgium", "France", "Italy", "Germany", "Spain",
            "Austria", "Russia", "Poland", "Croatia", "Greece",
            "Ukraine",
        }; 
    }
}