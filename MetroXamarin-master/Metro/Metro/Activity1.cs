using System;
using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Locations;
using Android.OS;
using Android.Util;
using Android.Widget;
using Model;
using Newtonsoft.Json.Linq;

namespace Metro
{
    [Activity(Label = "Track", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        private LocationManager m_locationManager = null;

        private string m_MetroServiceUrl = "http://m.dk/feeds/transitInfoMobile.ashx/mobile";
        private string m_RtcServiceUrl = "http://m.dk//services/RealTimeConnections.ashx";

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            GetMetroInformation();
        }

        private void GetMetroInformation()
        {
            HttpServiceHelper.GetAppSettings(m_MetroServiceUrl, String.Empty, OnServiceSuccess);
        }

        private void OnServiceSuccess(string jsonResult)
        {
            var result = jsonResult;

            if (String.IsNullOrEmpty(result))
                return;

            try
            {
                var transitInfo = JsonSerializer.Deserialize<TransitInfo>(jsonResult);

                WriteStationInfoToDatabase(transitInfo.StationInfo);

                RunOnUiThread(() =>
                    {
                        PopulateSpinner(transitInfo.StationInfo);
                    });
            }
            catch (Exception ex)
            {
                Log.Error("Track", ex.ToString());
            }
        }

        private void WriteStationInfoToDatabase(List<StationInfo> stationInfo)
        {
        }

        private void PopulateSpinner(IEnumerable<StationInfo> stationInfo)
        {
            if (stationInfo == null)
                return;

            var spinner = FindViewById<Spinner>(Resource.Id.spinner1);

            spinner.ItemSelected += spinner_ItemSelected;

            var stationNames = from x in stationInfo select x.Name.Replace('+', ' ');

            var adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleSpinnerDropDownItem, stationNames.ToArray());
            adapter.SetDropDownViewResource(Android.Resource.Layout.SimpleDropDownItem1Line);
            spinner.Adapter = adapter;
        }

        private void spinner_ItemSelected(object sender, AdapterView.ItemSelectedEventArgs e)
        {
            var id = e.Id;

            HttpServiceHelper.GetAppSettings(string.Format("{0}?stationId={1}", m_RtcServiceUrl, id), null, OnRtcServiceSuccess);
        }

        private void OnRtcServiceSuccess(string jsonResult)
        {
            var connections = ParseTimeConnections(jsonResult);

            RunOnUiThread(() =>
                {
                    var connectionListView = FindViewById<ListView>(Resource.Id.listView1);
                    var tracks = from x in connections.Tracks select string.Format("{0}\n{1}", x.Direction, string.Join(" <--->", x.Times));
                    var adapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, tracks.ToArray());
                    connectionListView.Adapter = adapter; 
                });
        }

        private StationTracks ParseTimeConnections(string jsonResult)
        {
            int baseMetroId = 8603300;
            int baseId = 1;
            string id = (baseId + baseMetroId).ToString();
            char[] separators = new char[] { ',' };
         
            var stationTrack = new StationTracks()
                {
                     StationId = baseId,
                     Tracks = new List<Track>()
                };

            JObject jsonObject = JObject.Parse(jsonResult);

            var jToken = jsonObject[id];

            var metros = jToken["M"].Children();

            foreach (var metro in metros)
            {
                var track = new Track
                    {
                        Name = (string) metro["name"],
                        Direction = (string) metro["direction"],
                        Times = new List<string>()
                    };

                foreach (var time in ((string)metro["time"]).Split(separators))
                {
                    track.Times.Add(time);
                }

                stationTrack.Tracks.Add(track);
            }

            return stationTrack;
        }
    }
}

