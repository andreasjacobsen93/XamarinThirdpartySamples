using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.Media;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Com.Dolby.Dap;

namespace DolbyTest2
{
    class DolbyListener : Java.Lang.Object, MediaPlayer.IOnCompletionListener, IOnDolbyAudioProcessingEventListener 
    {
        MediaPlayer mPlayer;
        static DolbyAudioProcessing mDolbyAudioProcessing;

        Context context;

        public bool isEnabled
        {
            get { if (mDolbyAudioProcessing == null) return false; return mDolbyAudioProcessing.Enabled; }
        }

        public bool isPlaying
        {
            get { if (mPlayer == null) return false; return mPlayer.IsPlaying; }
        }

        public void PlayStop()
        {
            PlayStop(Resource.Raw.sage);
        }
        public void PlayStop (int Resource)
        {
            if (mPlayer == null)
            {
                try
                {
                    mPlayer = MediaPlayer.Create(context, Resource);
                    if (mPlayer != null)
                    {
                        mPlayer.Start();

                    }
                }
                catch
                {

                }
            }
            else
            {
                mPlayer.Stop();
                mPlayer.Release();
                mPlayer = null;

            }
        }

        public bool EnableDolby(bool enabled)
        {
            if (mDolbyAudioProcessing == null)
                return false;

            mDolbyAudioProcessing.Enabled = enabled;
            return true;
        }


        public DolbyListener(Context context)
        {
            this.context = context;

            InitAudio();
        }

        public void InitAudio()
        {
            if (mDolbyAudioProcessing != null)
                return;

            mDolbyAudioProcessing = DolbyAudioProcessing.GetDolbyAudioProcessing(context, DolbyAudioProcessing.PROFILE.Music, this);

            if (mDolbyAudioProcessing == null)
            {

                return;
            }
        }

        public void OnCompletion(MediaPlayer mp)
        {
        
        }

        public void OnDolbyAudioProcessingClientConnected()
        {
            Log.Info("DolbyListener", "OnDolbyAudioProcessingClientConnected");
        }

        public void OnDolbyAudioProcessingClientDisconnected()
        {
            Log.Info("DolbyListener", "OnDolbyAudioProcessingClientDisconnected");
        }

        public void OnDolbyAudioProcessingEnabled(bool p0)
        {
            Log.Info("DolbyListener", "OnDolbyAudioProcessingEnabled");
        }

        public void OnDolbyAudioProcessingProfileSelected(DolbyAudioProcessing.PROFILE profile)
        {
            Log.Info("DolbyListener", "OnDolbyAudioProcessingProfileSelected");
        }

        public void SetDolbyProfile(DolbyAudioProcessing.PROFILE profile)
        {
            if (isEnabled == false)
            {
                if (EnableDolby(true) == false)
                    return;
            }

            mDolbyAudioProcessing.SetProfile(profile);
        }

        public void Stop ()
        {
            if (isEnabled == true)
                mDolbyAudioProcessing.SuspendSession(); 

        }
        public void Restart ()
        {
            if (isEnabled == true)
                mDolbyAudioProcessing.RestartSession();
        }
    }
}