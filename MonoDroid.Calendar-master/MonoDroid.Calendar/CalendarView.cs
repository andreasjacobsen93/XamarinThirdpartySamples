/*
 * Ported C# code:
 * Copyright (C) 2012 Tomasz Cielecki <tomasz@ostebaronen.dk>
 * 
 * Original Java code: https://code.google.com/p/android-calendar-view/source/browse/trunk/src/com/exina/android/calendar/CalendarView.java
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

using Android.Widget;
using Android.Graphics.Drawables;
using Android.Util;
using Android.Content;
using Android.Graphics;

namespace MonoDroid.Calendar
{
    public class CalendarView : ImageView
    {
        private static int WEEK_TOP_MARGIN = 74;
        private static int WEEK_LEFT_MARGIN = 40;
        private static int CELL_WIDTH = 58;
        private static int CELL_HEIGH = 53;
        private static int CELL_MARGIN_TOP = 92;
        private static int CELL_MARGIN_LEFT = 39;
        private static float CELL_TEXT_SIZE;

        private const String TAG = "CalendarView"; 
        private DateTime mRightNow;
        private Drawable mWeekTitle = null;
        private Cell mToday = null;
        private Cell[,] mCells = new Cell[6,7];
        //private OnCellTouchListener mOnCellTouchListener = null;
        MonthDisplayHelper mHelper;
        Drawable mDecoration = null;

        public CalendarView(Context context) : this(context, null) { }

        public CalendarView(Context context, IAttributeSet attrs) : this(context, attrs, 0) { }

        public CalendarView(Context context, IAttributeSet attrs, int defStyle) : base(context, attrs, defStyle)
        {

            mDecoration = context.Resources.GetDrawable(Resource.Drawable.typeb_calendar_today);
            InitCalendarView();
        }

        private void InitCalendarView()
        {
            mRightNow = DateTime.Now;
            // prepare static vars

            WEEK_TOP_MARGIN = (int)Resources.GetDimension(Resource.Dimension.week_top_margin);
            WEEK_LEFT_MARGIN = (int)Resources.GetDimension(Resource.Dimension.week_left_margin);

            CELL_WIDTH = (int)Resources.GetDimension(Resource.Dimension.cell_width);
            CELL_HEIGH = (int)Resources.GetDimension(Resource.Dimension.cell_height);
            CELL_MARGIN_TOP = (int)Resources.GetDimension(Resource.Dimension.cell_margin_top);
            CELL_MARGIN_LEFT = (int)Resources.GetDimension(Resource.Dimension.cell_margin_left);

            CELL_TEXT_SIZE = (int)Resources.GetDimension(Resource.Dimension.cell_text_size);
            // set background
            SetImageResource(Resource.Drawable.background);
            mWeekTitle = Resources.GetDrawable(Resource.Drawable.calendar_week);

            mHelper = new MonthDisplayHelper(mRightNow.Year, mRightNow.Month);
        }

        private class _calendar
        {
            public int day;
            public bool thisMonth;
            public _calendar(int d, bool b)
            {
                day = d;
                thisMonth = b;
            }
            public _calendar(int d) : this(d, false) { }
        }

        private class GrayCell : Cell {
            public GrayCell(int dayOfMon, Rect rect, float s) : base(dayOfMon,rect,s)
            {
                mPaint.Color = Color.LightGray;
            }
        }
        
        private class RedCell : Cell {
            public RedCell(int dayOfMon, Rect rect, float s) : base(dayOfMon,rect,s)
            {
                mPaint.Color = Color.Argb(221, 211, 0, 0);
            }    
        }

        private void InitCells() 
        {
            _calendar[,] tmp = new _calendar[6,7];

            for (int i = 0; i < tmp.GetUpperBound(0); i++)
            {
                int[] n = mHelper.GetDigitsForRow(i);
                for(int d=0; d<n.Length; d++)
                {
                    if(mHelper.IsWithinCurrentMonth(i, d))
                        tmp[i,d] = new _calendar(n[d], true);
                    else
                        tmp[i,d] = new _calendar(n[d]);        
                }
            }

            DateTime today = DateTime.Now;
            int thisDay = 0;
            mToday = null;
            if(mHelper.Year == today.Year && mHelper.Month == today.Month)
                thisDay = today.Day;

            // build cells
            Rect Bound = new Rect(CELL_MARGIN_LEFT, CELL_MARGIN_TOP, CELL_WIDTH+CELL_MARGIN_LEFT, CELL_HEIGH+CELL_MARGIN_TOP);

            int bound0 = mCells.GetUpperBound(0);
            int bound1 = mCells.GetUpperBound(1);
            for (int week = 0; week < bound0; week++)
            {
                for (int day = 0; day < bound1; day++)
                {
                        if(tmp[week,day].thisMonth) {
                                if(day==0 || day==6 )
                                        mCells[week,day] = new RedCell(tmp[week,day].day, new Rect(Bound), CELL_TEXT_SIZE);
                                else 
                                        mCells[week,day] = new Cell(tmp[week,day].day, new Rect(Bound), CELL_TEXT_SIZE);
                        } else {
                                mCells[week,day] = new GrayCell(tmp[week,day].day, new Rect(Bound), CELL_TEXT_SIZE);
                        }
                                
                        Bound.Offset(CELL_WIDTH, 0); // move to next column 
                                
                        // get today
                        if(tmp[week,day].day==thisDay && tmp[week,day].thisMonth) {
                                mToday = mCells[week,day];
                                mDecoration.SetBounds(mToday.Bounds.Left, mToday.Bounds.Top, mToday.Bounds.Right, mToday.Bounds.Bottom);
                        }
                }
                Bound.Offset(0, CELL_HEIGH); // move to next row and first column
                Bound.Left = CELL_MARGIN_LEFT;
                Bound.Right = CELL_MARGIN_LEFT+CELL_WIDTH;
            }
        }

        protected override void OnLayout(bool changed, int left, int top, int right, int bottom)
        {
            Rect re = Drawable.Bounds;
            WEEK_LEFT_MARGIN = CELL_MARGIN_LEFT = (right - left - re.Width()) / 2;
            mWeekTitle.SetBounds(WEEK_LEFT_MARGIN, WEEK_TOP_MARGIN, WEEK_LEFT_MARGIN + mWeekTitle.MinimumWidth, WEEK_TOP_MARGIN + mWeekTitle.MinimumHeight);
            InitCells();
            base.OnLayout(changed, left, top, right, bottom);
        }

        public void SetTimeInMillis(long milliseconds)
        {
            mRightNow = new DateTime(milliseconds * 10000);
            InitCells();
            Invalidate();
        }

        public int Year
        {
            get { return mHelper.Year; }
        }

        public int Month
        {
            get { return mHelper.Month; }
        }

        public void NextMonth()
        {
            mHelper.NextMonth();
            InitCells();
            Invalidate();
        }

        public void PreviousMonth()
        {
            mHelper.PreviousMonth();
            InitCells();
            Invalidate();
        }

        public bool FirstDay(int day)
        {
            return day == 1;
        }

        public bool LastDay(int day)
        {
            return mHelper.NumberOfDaysInMonth == day;
        }

        public void GoToday()
        {
            DateTime cal = DateTime.Now;
            mHelper = new MonthDisplayHelper(cal.Year, cal.Month);
            InitCells();
            Invalidate();
        }

        public DateTime Date
        {
            get { return mRightNow; }
        }
    }
}
