using System;

using Android.App;
using Android.Content;
using Android.Widget;
using Android.OS;

namespace MonoDroid.DatePickerSample
{
    [Activity(Label = "DatePicker Sample", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private TextView dateDisplay;
        private Button pickDate;
        private DateTime date;

        const int DATE_DIALOG_ID = 0;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get the views from the layout
            dateDisplay = FindViewById<TextView>(Resource.Id.dateDisplay);
            pickDate = FindViewById<Button>(Resource.Id.pickDate);

            // Set Click event to show a the DatePicker dialog
            pickDate.Click += delegate { ShowDialog(DATE_DIALOG_ID); };

            date = DateTime.Today;

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            dateDisplay.Text = date.ToString("d");
        }

        void OnDateSet(object sender, DatePickerDialog.DateSetEventArgs e)
        {
            this.date = e.Date;
            UpdateDisplay();
        }

        protected override Dialog OnCreateDialog(int id)
        {
            switch (id)
            {
                case DATE_DIALOG_ID:
                    return new DatePickerDialog(this, OnDateSet, date.Year, date.Month - 1, date.Day);
            }
            return null;
        }
    }
}

