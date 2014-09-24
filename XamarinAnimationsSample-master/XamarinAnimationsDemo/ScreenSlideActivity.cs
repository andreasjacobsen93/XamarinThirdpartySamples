using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentManager = Android.Support.V4.App.FragmentManager;
using FragmentActivity = Android.Support.V4.App.FragmentActivity;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "ScreenSlideActivity", ParentActivity = typeof(MainActivity))]
    public class ScreenSlideActivity : FragmentActivity
    {
        private ViewPager _viewPager;
        private PagerAdapter _pagerAdapter;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_screen_slide);

            _viewPager = FindViewById(Resource.Id.pager).JavaCast<ViewPager>();
            _pagerAdapter = new ScreenSlidePagerAdapter(SupportFragmentManager);
            _viewPager.Adapter = _pagerAdapter;
            _viewPager.PageSelected += (sender, args) => InvalidateOptionsMenu();
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);

            MenuInflater.Inflate(Resource.Menu.activity_screen_slide, menu);

            menu.FindItem(Resource.Id.action_previous).SetEnabled(_viewPager.CurrentItem > 0);

            var item = menu.Add(Menu.None, Resource.Id.action_next, Menu.None,
                (_viewPager.CurrentItem == _pagerAdapter.Count - 1)
                ? Resource.String.action_finish
                : Resource.String.action_next);

            item.SetShowAsAction(ShowAsAction.IfRoom | ShowAsAction.WithText); 

            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    NavUtils.NavigateUpTo(this, new Intent(this, typeof(MainActivity)));
                    return true;
                case Resource.Id.action_previous:
                    _viewPager.CurrentItem = _viewPager.CurrentItem - 1;
                    return true;
                case Resource.Id.action_next:
                    _viewPager.CurrentItem = _viewPager.CurrentItem + 1;
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }
    }

    public class ScreenSlidePagerAdapter : FragmentStatePagerAdapter
    {
        public ScreenSlidePagerAdapter(FragmentManager fragmentManager) 
            : base(fragmentManager)
        {
        }

        public override int Count
        {
            get { return 5; }
        }

        public override Fragment GetItem(int position)
        {
            return ScreenSlidePageFragment.Create(position);
        }
    }
}