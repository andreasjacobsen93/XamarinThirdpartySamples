using System;
using Android.Content;
using Android.Graphics;
using Android.Graphics.Drawables;
using Android.Runtime;
using Android.Util;
using Android.Widget;

namespace XamarinAnimationsDemo
{
    public class TouchHighlightImageButtom : ImageButton
    {
        private Drawable _foregroundDrawable;
        private readonly Rect _cachedBounds = new Rect();

        protected TouchHighlightImageButtom(IntPtr javaReference, JniHandleOwnership transfer) 
            : base(javaReference, transfer)
        {
        }

        public TouchHighlightImageButtom(Context context) 
            : this(context, null)
        {
        }

        public TouchHighlightImageButtom(Context context, IAttributeSet attrs) 
            : this(context, attrs, 0)
        {
        }

        public TouchHighlightImageButtom(Context context, IAttributeSet attrs, int defStyle) 
            : base(context, attrs, defStyle)
        {
            Init();
        }

        private void Init()
        {
            SetBackgroundColor(Color.Black);
            SetPadding(0, 0, 0, 0);

            var a = Context.ObtainStyledAttributes(new[] {Android.Resource.Attribute.SelectableItemBackground});
            _foregroundDrawable = a.GetDrawable(0);
            _foregroundDrawable.SetCallback(this);

            a.Recycle();
        }

        protected override void DrawableStateChanged()
        {
            base.DrawableStateChanged();

            if (_foregroundDrawable.IsStateful)
                _foregroundDrawable.SetState(GetDrawableState());

            Invalidate();
        }

        protected override void OnDraw(Canvas canvas)
        {
            base.OnDraw(canvas);

            _foregroundDrawable.Bounds = _cachedBounds;
            _foregroundDrawable.Draw(canvas);
        }

        protected override void OnSizeChanged(int w, int h, int oldw, int oldh)
        {
            base.OnSizeChanged(w, h, oldw, oldh);

            _cachedBounds.Set(0, 0, w, h);
        }
    }
}