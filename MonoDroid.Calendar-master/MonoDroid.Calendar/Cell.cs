/*
 * Ported C# code:
 * Copyright (C) 2012 Tomasz Cielecki <tomasz@ostebaronen.dk>
 * 
 * Original Java code: https://code.google.com/p/android-calendar-view/source/browse/trunk/src/com/exina/android/calendar/Cell.java
 * Copyright (C) 2011 Chris Gao <chris@exina.net>
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using Android.Graphics;

namespace MonoDroid.Calendar
{
    public class Cell
    {
        private const string TAG = "Cell";
        private Rect mBound = null;
        private int mDayOfMonth = 1;
        protected Paint mPaint = new Paint(PaintFlags.AntiAlias | PaintFlags.SubpixelText);
        private int dx, dy;

        public Cell(int dayOfMon, Rect rect, float textSize, bool bold)
        {
            mDayOfMonth = dayOfMon;
            mBound = rect;
            mPaint.TextSize = textSize;
            mPaint.Color = Color.Black;

            if (bold)
                mPaint.FakeBoldText = true;

            dx = (int) mPaint.MeasureText(string.Format("{0}", mDayOfMonth)) / 2;
            dy = (int) (-mPaint.Ascent() + mPaint.Descent()) / 2;
        }

        public Cell(int dayOfMon, Rect rect, float textSize): this(dayOfMon, rect, textSize, false) { }

        public int DayOfMonth
        {
            get { return mDayOfMonth; }
        }

        public bool HitTest(int x, int y)
        {
            return mBound.Contains(x, y);
        }

        public Rect Bounds
        {
            get { return mBound; }
        }

        public override string  ToString()
        {
 	        return string.Format("{0}({1})", mDayOfMonth, mBound.ToString());
        }

        protected void Draw(Canvas canvas)
        {
            canvas.DrawText(string.Format("{0}", mDayOfMonth), (mBound.CenterX() - dx), (mBound.CenterY() + dy), mPaint);
        }
    }
}
