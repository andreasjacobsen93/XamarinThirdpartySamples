using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Animation;
using Android.App;
using Android.Content;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Android.OS;
using Object = Java.Lang.Object;

namespace SwipeRefreshLayoutSample
{
    [Activity(Label = "SwipeRefreshLayout Sample", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Gremlin")]
    public class MainActivity : ActionBarActivity
    {
        private SwipeRefreshLayout _swipeRefreshLayout;
        private ListView _listView;
        private readonly Random _random = new Random();
        private GoatListViewAdapter _adapter;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            _swipeRefreshLayout = FindViewById<SwipeRefreshLayout>(Resource.Id.swipe_container);
            _listView = FindViewById<ListView>(Resource.Id.listView);
            _listView.LayoutTransition = new LayoutTransition();
            _listView.Adapter = _adapter = new GoatListViewAdapter(this);
            AddViews();
            
            _swipeRefreshLayout.Refresh += (sender, args) => AddViews();
        }

        private async void AddViews()
        {
            await Task.Run(async () =>
            {
                for (var i = 0; i < _random.Next(1, 5); i++)
                {
                    RunOnUiThread(() => _adapter.AddGoat(GenerateRandomString(200)));
                    await Task.Delay(300 * i);
                }
            });
            _swipeRefreshLayout.Refreshing = false;
        }

        public string GenerateRandomString(int length)
        {
            const string valid = " bah";
            var res = "";
            while (0 < length--)
                res += valid[_random.Next(valid.Length)];
            return res;
        }
    }

    public class GoatListViewAdapter : BaseAdapter
    {
        private readonly IList<string> _goats = new List<string>();
        private readonly Context _context;

        public GoatListViewAdapter(Context context)
        {
            _context = context;
        }

        public override Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var goat = _goats[position];

            if (convertView == null)
            {
                var inflater = LayoutInflater.FromContext(_context);
                convertView = inflater.Inflate(Resource.Layout.derp, parent, false);
            }

            convertView.FindViewById<TextView>(Resource.Id.itemText).Text = goat;

            return convertView;
        }

        public override int Count
        {
            get { return _goats.Count; }
        }

        public void AddGoat(string whatDoesItSay)
        {
            _goats.Add(whatDoesItSay);
            NotifyDataSetChanged();
        }

        public void AddGoats(IList<string> whatDoTheySay)
        {
            foreach (var goat in whatDoTheySay)
                _goats.Add(goat);

            NotifyDataSetChanged();
        }
    }
}

