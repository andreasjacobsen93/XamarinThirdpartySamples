using Android.Animation;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "Crossfade Activity", ParentActivity = typeof(MainActivity))]
    public class CrossfadeActivity : Activity
    {
        private bool _contentLoaded;
        private View _contentView;
        private View _loadingView;
        private int _shortAnimationDuration;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_crossfade);

            _contentView = FindViewById(Resource.Id.content);
            _loadingView = FindViewById(Resource.Id.loading_spinner);

            _contentView.Visibility = ViewStates.Gone;

            _shortAnimationDuration = Resources.GetInteger(Android.Resource.Integer.ConfigShortAnimTime);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            base.OnCreateOptionsMenu(menu);

            MenuInflater.Inflate(Resource.Menu.activity_crossfade, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    NavUtils.NavigateUpTo(this, new Intent(this, typeof(MainActivity)));
                    return true;
                case Resource.Id.action_toggle:
                    _contentLoaded = !_contentLoaded;
                    ShowContentOrLoadingIndicator(_contentLoaded);
                    return true;
            }


            return base.OnOptionsItemSelected(item);
        }

        private void ShowContentOrLoadingIndicator(bool contentLoaded)
        {
            var showView = contentLoaded ? _contentView : _loadingView;
            var hideView = _contentLoaded ? _loadingView : _contentView;

            showView.Alpha = 0f;
            showView.Visibility = ViewStates.Visible;

            showView.Animate()
                .Alpha(1f)
                .SetDuration(_shortAnimationDuration)
                .SetListener(null);

            hideView.Animate()
                .Alpha(0f)
                .SetDuration(_shortAnimationDuration)
                .SetListener(new AnimatorListener(hideView));
        }

        private class AnimatorListener : Java.Lang.Object, Animator.IAnimatorListener
        {
            private readonly View _hideView;

            public AnimatorListener(View hideView)
            {
                _hideView = hideView;
            }

            public void OnAnimationCancel(Animator animation)
            {
                
            }

            public void OnAnimationEnd(Animator animation)
            {
                _hideView.Visibility = ViewStates.Gone;
            }

            public void OnAnimationRepeat(Animator animation)
            {
                
            }

            public void OnAnimationStart(Animator animation)
            {
                
            }
        }
    }
}