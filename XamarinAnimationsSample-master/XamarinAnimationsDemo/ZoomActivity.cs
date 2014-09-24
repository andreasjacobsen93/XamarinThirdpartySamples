using Android.Animation;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Views.Animations;
using Android.Widget;

namespace XamarinAnimationsDemo
{
    [Activity(Label = "Zoom Activity", ParentActivity = typeof(MainActivity))]
    public class ZoomActivity : FragmentActivity
    {
        private Animator _currentAnimator;

        private int _shortAnimationDuration;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.activity_zoom);

            var thumb1View = FindViewById(Resource.Id.thumb_button_1);
            thumb1View.Click += (s, e) => ZoomImageFromThumb(thumb1View, Resource.Drawable.image1);

            var thumb2View = FindViewById(Resource.Id.thumb_button_2);
            thumb2View.Click += (s, e) => ZoomImageFromThumb(thumb2View, Resource.Drawable.image2);

            _shortAnimationDuration = Resources.GetInteger(Android.Resource.Integer.ConfigShortAnimTime);
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {
                case Android.Resource.Id.Home:
                    NavUtils.NavigateUpTo(this, new Intent(this, typeof(MainActivity)));
                    return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void ZoomImageFromThumb(View thumbView, int imageResId)
        {
            var expandedImageView = FindViewById<ImageView>(Resource.Id.expanded_image);
            expandedImageView.SetImageResource(imageResId);

            var startBounds = new Rect();
            var finalBounds = new Rect();
            var globalOffset = new Point();

            thumbView.GetGlobalVisibleRect(startBounds);
            FindViewById(Resource.Id.container).GetGlobalVisibleRect(finalBounds, globalOffset);
            startBounds.Offset(-globalOffset.X, -globalOffset.Y);
            finalBounds.Offset(-globalOffset.X, -globalOffset.Y);

            float startScale;
            if (((float) finalBounds.Width() / finalBounds.Height())
                .CompareTo((float) startBounds.Width() / startBounds.Height()) < 0)
            {
                startScale = (float) startBounds.Height() / finalBounds.Height();
                var startWidth = startScale * finalBounds.Width();
                var deltaWidth = (startWidth - startBounds.Width()) / 2;
                startBounds.Left -= (int) deltaWidth;
                startBounds.Right += (int) deltaWidth;
            }
            else
            {
                startScale = (float) startBounds.Width() / finalBounds.Width();
                var startHeight = startScale * finalBounds.Height();
                var deltaHeight = (startHeight - startBounds.Height()) / 2;
                startBounds.Top -= (int) deltaHeight;
                startBounds.Bottom += (int)deltaHeight;
            }

            thumbView.Alpha = 0f;
            expandedImageView.Visibility = ViewStates.Visible;

            expandedImageView.PivotX = 0f;
            expandedImageView.PivotY = 0f;

            var set = new AnimatorSet();
            set.Play(ObjectAnimator.OfFloat(expandedImageView, View.X, startBounds.Left, finalBounds.Left))
                .With(ObjectAnimator.OfFloat(expandedImageView, View.Y, startBounds.Top, finalBounds.Top))
                .With(ObjectAnimator.OfFloat(expandedImageView, View.ScaleXs, startScale, 1f))
                .With(ObjectAnimator.OfFloat(expandedImageView, View.ScaleYs, startScale, 1f));
            set.SetDuration(_shortAnimationDuration);
            set.SetInterpolator(new DecelerateInterpolator());
            set.AddListener(new AnimatorListener(this));
            set.Start();
            _currentAnimator = set;

            expandedImageView.Click += (s, e) =>
            {
                if (_currentAnimator != null)
                    _currentAnimator.Cancel();

                var animSet = new AnimatorSet();
                animSet.Play(ObjectAnimator.OfFloat(expandedImageView, View.X, startBounds.Left))
                    .With(ObjectAnimator.OfFloat(expandedImageView, View.Y, startBounds.Top))
                    .With(ObjectAnimator.OfFloat(expandedImageView, View.ScaleXs, startScale))
                    .With(ObjectAnimator.OfFloat(expandedImageView, View.ScaleYs, startScale));
                animSet.SetDuration(_shortAnimationDuration);
                animSet.SetInterpolator(new DecelerateInterpolator());
                animSet.AnimationEnd += (sender, args) =>
                {
                    thumbView.Alpha = 1f;
                    expandedImageView.Visibility = ViewStates.Gone;
                    _currentAnimator = null;
                };
                animSet.AnimationCancel += (sender, args) =>
                {
                    thumbView.Alpha = 1f;
                    expandedImageView.Visibility = ViewStates.Gone;
                    _currentAnimator = null;
                };
            };
        }

        public class AnimatorListener : Java.Lang.Object, Animator.IAnimatorListener
        {
            private readonly ZoomActivity _activity;

            public AnimatorListener(ZoomActivity activity)
            {
                _activity = activity;
            }

            public void OnAnimationCancel(Animator animation)
            {
                _activity._currentAnimator = null;
            }

            public void OnAnimationEnd(Animator animation)
            {
                _activity._currentAnimator = null;
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