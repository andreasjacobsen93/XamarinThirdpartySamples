using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Media;

namespace DolbyTest2
{
    [Activity(Label = "DolbyTest2", MainLauncher = true, Icon = "@drawable/icon")]
    public class Activity1 : Activity
    {
        Button btnPlay;
        Button btnDolbyMusic, btnDolbyGame, btnDolbyVoice, btnDolbyMovie, btnDolbyOff;

        DolbyListener dbListener;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            dbListener = new DolbyListener(this);

            InitControls();
        }

        protected override void OnRestart()
        {
            base.OnRestart();

            if (dbListener != null)
                dbListener.Restart();
        }

        protected override void OnStop()
        {
            base.OnStop();

            if (dbListener != null)
                dbListener.Stop();
        }

        void InitControls()
        {
            btnPlay = FindViewById<Button>(Resource.Id.buttonPlay);
            btnPlay.Click += btnPlay_Click;

            btnDolbyMusic = FindViewById<Button>(Resource.Id.buttonMusic);
            btnDolbyMusic.Click += btnDolbyMusic_Click;

            btnDolbyGame = FindViewById<Button>(Resource.Id.buttonGame);
            btnDolbyGame.Click += btnDolbyGame_Click;

            btnDolbyVoice = FindViewById<Button>(Resource.Id.buttonVoice);
            btnDolbyVoice.Click += btnDolbyVoice_Click;

            btnDolbyMovie = FindViewById<Button>(Resource.Id.buttonMovie);
            btnDolbyMovie.Click += btnDolbyMovie_Click;

            btnDolbyOff = FindViewById<Button>(Resource.Id.buttonOff);
            btnDolbyOff.Click += btnDolbyOff_Click;
        }

        void btnDolbyOff_Click(object sender, EventArgs e)
        {
            dbListener.EnableDolby(false);
        }

        void btnDolbyMovie_Click(object sender, EventArgs e)
        {
            dbListener.SetDolbyProfile(Com.Dolby.Dap.DolbyAudioProcessing.PROFILE.Movie);
        }

        void btnDolbyVoice_Click(object sender, EventArgs e)
        {
            dbListener.SetDolbyProfile(Com.Dolby.Dap.DolbyAudioProcessing.PROFILE.Voice);
        }

        void btnDolbyGame_Click(object sender, EventArgs e)
        {
            dbListener.SetDolbyProfile(Com.Dolby.Dap.DolbyAudioProcessing.PROFILE.Game);
        }

        void btnDolbyMusic_Click(object sender, EventArgs e)
        {
            dbListener.SetDolbyProfile(Com.Dolby.Dap.DolbyAudioProcessing.PROFILE.Music);
        }

        void btnPlay_Click(object sender, EventArgs e)
        {
            dbListener.PlayStop();

            
        }
    }
}

