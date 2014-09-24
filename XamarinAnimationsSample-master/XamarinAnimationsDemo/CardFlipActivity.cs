using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Fragment = Android.App.Fragment;
using FragmentManager = Android.App.FragmentManager;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "CardFlipActivity", ParentActivity = typeof(MainActivity))]
    public class CardFlipActivity : Activity, FragmentManager.IOnBackStackChangedListener
    {
        private bool _showingBack;

        private Handler _handler = new Handler();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_card_flip);

            if (bundle == null)
            {
                FragmentManager
                    .BeginTransaction()
                    .Add(Resource.Id.container, new CardFrontFragment())
                    .Commit();
            }
            else
            {
                _showingBack = FragmentManager.BackStackEntryCount > 0;
            }

            FragmentManager.AddOnBackStackChangedListener(this);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            var item = menu.Add(Menu.None, Resource.Id.action_flip, Menu.None,
                _showingBack ? Resource.String.action_photo : Resource.String.action_info);
            item.SetIcon(_showingBack
                ? Resource.Drawable.ic_action_photo
                : Resource.Drawable.ic_action_info);
            item.SetShowAsAction(ShowAsAction.IfRoom);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    NavUtils.NavigateUpTo(this, new Intent(this, typeof(MainActivity)));
                    return true;
                case Resource.Id.action_flip:
                    FlipCard();
                    return true;
            }


            return base.OnOptionsItemSelected(item);
        }

        private void FlipCard()
        {
            if (_showingBack)
            {
                FragmentManager.PopBackStack();
                return;
            }


            _showingBack = true;

            FragmentManager.BeginTransaction()
                .SetCustomAnimations(Resource.Animator.card_flip_right_in, Resource.Animator.card_flip_right_out,
                    Resource.Animator.card_flip_left_in, Resource.Animator.card_flip_left_out)
                .Replace(Resource.Id.container, new CardBackFragment())
                .AddToBackStack(null)
                .Commit();

            _handler.Post(InvalidateOptionsMenu);
        }

        public void OnBackStackChanged()
        {
            _showingBack = FragmentManager.BackStackEntryCount > 0;

            InvalidateOptionsMenu();
        }

        public class CardFrontFragment : Fragment
        {
            public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
            {
                return inflater.Inflate(Resource.Layout.fragment_card_front, container, false);
            }
        }

        public class CardBackFragment : Fragment
        {
            public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
            {
                return inflater.Inflate(Resource.Layout.fragment_card_back, container, false);
            }
        }
    }
}