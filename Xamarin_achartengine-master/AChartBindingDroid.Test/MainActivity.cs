using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AChartEngine.Model;
using AChartEngine.Renderer;
using Android.Graphics;
using AChartEngine;
using AChartEngine.Chart;

namespace AChartBindingDroid.Test
{
    [Activity(Label = "AChartBindingDroid.Test", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private string[] mMonth = new string[] {
        "Jan", "Feb" , "Mar", "Apr", "May", "Jun",
        "Jul", "Aug" , "Sep", "Oct", "Nov", "Dec"
    };

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);

            // Getting reference to the button btn_chart
            Button btnChart = FindViewById<Button>(Resource.Id.btn_chart);

            btnChart.Click += (s,e) => {
                openChart();
            };


        }

        private void openChart()
        {
            int[] x = { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] income = { 2000, 2500, 2700, 3000, 2800, 3500, 3700, 3800 };
            int[] expense = { 2200, 2700, 2900, 2800, 2600, 3000, 3300, 3400 };

            // Creating an  XYSeries for Income
            XYSeries incomeSeries = new XYSeries("Income");
            // Creating an  XYSeries for Expense
            XYSeries expenseSeries = new XYSeries("Expense");
            // Adding data to Income and Expense Series
            for (int i = 0; i < x.Length; i++)
            {
                incomeSeries.Add(i, income[i]);
                expenseSeries.Add(i, expense[i]);
            }

            // Creating a dataset to hold each series
            XYMultipleSeriesDataset dataset = new XYMultipleSeriesDataset();
            // Adding Income Series to the dataset
            dataset.AddSeries(incomeSeries);
            // Adding Expense Series to dataset
            dataset.AddSeries(expenseSeries);

            // Creating XYSeriesRenderer to customize incomeSeries
            XYSeriesRenderer incomeRenderer = new XYSeriesRenderer();
            incomeRenderer.Color = Color.Rgb(130,130,230);
            incomeRenderer.FillPoints = true ;
            incomeRenderer.LineWidth = 2;
            incomeRenderer.DisplayChartValues = true;

            // Creating XYSeriesRenderer to customize expenseSeries
            XYSeriesRenderer expenseRenderer = new XYSeriesRenderer();
            expenseRenderer.Color = Color.Rgb(220, 80, 80);
            expenseRenderer.FillPoints = true ;
            expenseRenderer.LineWidth = 2;
            expenseRenderer.DisplayChartValues = true;

            // Creating a XYMultipleSeriesRenderer to customize the whole chart
            XYMultipleSeriesRenderer multiRenderer = new XYMultipleSeriesRenderer();
            multiRenderer.XLabels = 0;
            multiRenderer.ChartTitle = "Income vs Expense Chart";
            multiRenderer.XTitle= "Year 2012";
            multiRenderer.YTitle="Amount in Dollars";
            multiRenderer.ZoomButtonsVisible = true;
            multiRenderer.BackgroundColor = Color.Transparent;
            for (int i = 0; i < x.Length; i++)
            {
                multiRenderer.AddXTextLabel(i, mMonth[i]);
            }

            // Adding incomeRenderer and expenseRenderer to multipleRenderer
            // Note: The order of adding dataseries to dataset and renderers to multipleRenderer
            // should be same
            multiRenderer.AddSeriesRenderer(incomeRenderer);
            multiRenderer.AddSeriesRenderer(expenseRenderer);

            // Creating an intent to plot bar chart using dataset and multipleRenderer
            Intent intent = ChartFactory.GetBarChartIntent(this, dataset, multiRenderer, BarChart.Type.Default);

            // Start Activity
            StartActivity(intent);

        }
    }
}

