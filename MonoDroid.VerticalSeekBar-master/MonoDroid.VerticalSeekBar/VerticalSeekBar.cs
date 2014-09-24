using System;
using Android.Content;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace MonoDroid.VerticalSeekbar
{
    public delegate void VerticalSeekBarStartTrackingTouchEventHandler(object sender, SeekBar.StartTrackingTouchEventArgs args);
    public delegate void VerticalSeekBarStopTrackingTouchEventHandler(object sender, SeekBar.StopTrackingTouchEventArgs args);

    /// <summary>
    /// Loosely based on implementation from http://stackoverflow.com/questions/4892179/how-can-i-get-a-working-vertical-seekbar-in-android
    /// </summary>
    public class VerticalSeekBar : SeekBar
    {
        #region ctor

        protected VerticalSeekBar(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer)
        { }

        public VerticalSeekBar(Context context) 
            : base(context)
        { }

        public VerticalSeekBar(Context context, IAttributeSet attrs) 
            : base(context, attrs)
        { }

        public VerticalSeekBar(Context context, IAttributeSet attrs, int defStyle) 
            : base(context, attrs, defStyle)
        { }

        #endregion

        #region fields

        private int _min;

        #endregion

        #region properties

        public int Min
        {
            get { return _min; }
            set
            {
                if (Min > Progress)
                    Progress = Min;
                _min = value;
                OnSizeChanged(Width, Height, 0, 0);
            }
        }

        public override int Progress
        {
            get
            {
                return base.Progress <= Min ? Min : base.Progress;
            }
            set
            {
                if (value <= Min)
                    base.Progress = Min;
                else if (value >= Max)
                    base.Progress = Max;
                else
                    base.Progress = value;

                OnSizeChanged(Width, Height, 0, 0);
            }
        }

        #endregion

        #region events

        public new event VerticalSeekBarStartTrackingTouchEventHandler StartTrackingTouch;
        public new event VerticalSeekBarStopTrackingTouchEventHandler StopTrackingTouch;

        #endregion

        public override void Draw(Android.Graphics.Canvas canvas)
        {
            canvas.Rotate(-90);
            canvas.Translate(-Height, 0);
            base.OnDraw(canvas);
        }

        protected override void OnMeasure(int widthMeasureSpec, int heightMeasureSpec)
        {
            base.OnMeasure(heightMeasureSpec, widthMeasureSpec);
            SetMeasuredDimension(MeasuredHeight, MeasuredWidth);
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(h, w, oldh, oldw);
        }

        public override bool OnTouchEvent(MotionEvent e)
        {
            if (!Enabled)
                return false;

            switch (e.Action)
            {
                case MotionEventActions.Down:
                    if (null != StartTrackingTouch)
                        StartTrackingTouch(this, new StartTrackingTouchEventArgs(this));
                    Selected = true;
                    Pressed = true;
                    Progress = Max - (int)(Max * e.GetY() / Height);
                    break;
                case MotionEventActions.Move:
                    Progress = Max - (int)(Max * e.GetY() / Height);
                    break;
                case MotionEventActions.Up:
                    if (null != StopTrackingTouch)
                        StopTrackingTouch(this, new StopTrackingTouchEventArgs(this));
                    Selected = false;
                    Pressed = false;
                    Progress = Max - (int)(Max * e.GetY() / Height);
                    break;
                case MotionEventActions.Cancel:
                    Selected = false;
                    Pressed = false;
                    break;
            }

            return true;
        }
    }
}