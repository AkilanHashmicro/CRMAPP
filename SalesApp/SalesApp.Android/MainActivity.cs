using System;
using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Xamarin.Forms;
using Android.Content;
using Android.Telephony;
using Android.Graphics;
using System.Linq;
using System.Diagnostics;
using Android.Support.V4.Content;
using Android.Support.V4.App;
using Android;
using Plugin.AudioRecorder;

//using Plugin.CrossPlatformTintedImage.Android;
//using Android.Graphics.Drawables;
//using Android.Support.V4.Graphics.Drawable;
//using UIKit;


namespace SalesApp.Droid
{
    
    [Activity(Label = "CRM", Icon = "@drawable/iconnew", Theme = "@style/MainTheme", MainLauncher = false, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
      //  AudioRecorderService recorder;
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

           Rg.Plugins.Popup.Popup.Init(this, bundle);
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init(true);

            //var intent = new Intent(ApplicationContext, typeof(PostService));
            //var source = PendingIntent.GetBroadcast(ApplicationContext, 0, intent, 0);

            LoadApplication(new App());
            //    Xamarin.Essentials.Platform.Init(this, savedInstanceState);  


            //if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) != Permission.Granted)
            //{
            //    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio }, 1);
            //}


           // if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) != Permission.Granted &&
           //  ContextCompat.CheckSelfPermission(this, Manifest.Permission.ModifyAudioSettings) != Permission.Granted &&
           //  ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) != Permission.Granted &&
           //  ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != Permission.Granted 
           ////  ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted
            //)

            //{
            //    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio,
            //        Manifest.Permission.ModifyAudioSettings,Manifest.Permission.ReadExternalStorage,
            //        Manifest.Permission.WriteExternalStorage, Manifest.Permission.CaptureAudioOutput,
            //    }, 1000);
            //}

            //else
            //{
            //    int j = 0;
            //}



            //if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) != Permission.Granted &&
            //    ContextCompat.CheckSelfPermission(this, Manifest.Permission.ModifyAudioSettings) != Permission.Granted &&
            //    ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) != Permission.Granted &&
            //    ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != Permission.Granted
            //   // ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted 
            //   )

            //  {
            //    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio,
            //        Manifest.Permission.ModifyAudioSettings,Manifest.Permission.ReadExternalStorage,
            //       // Manifest.Permission.WriteExternalStorage, Manifest.Permission.CaptureAudioOutput,
            //    }, 1000);
            //  }

            //else if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted)
            //{

            //    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.CaptureAudioOutput,
                   
            //       // Manifest.Permission.WriteExternalStorage, Manifest.Permission.CaptureAudioOutput,
            //    }, 1000);
            //}


            if (Build.VERSION.SdkInt >= Build.VERSION_CODES.M)
            {
                if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.RecordAudio) != Permission.Granted &&
              ContextCompat.CheckSelfPermission(this, Manifest.Permission.ModifyAudioSettings) != Permission.Granted &&
              ContextCompat.CheckSelfPermission(this, Manifest.Permission.ReadExternalStorage) != Permission.Granted &&
              ContextCompat.CheckSelfPermission(this, Manifest.Permission.WriteExternalStorage) != Permission.Granted &&
                  ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted
                   )

                {
                    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio,
                    Manifest.Permission.ModifyAudioSettings,Manifest.Permission.ReadExternalStorage,
                       Manifest.Permission.WriteExternalStorage,Manifest.Permission.CaptureAudioOutput
                        }, 1000);
                }

                else
                {
                    ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio,
                    Manifest.Permission.ModifyAudioSettings,Manifest.Permission.ReadExternalStorage,
                        Manifest.Permission.WriteExternalStorage,Manifest.Permission.CaptureAudioOutput 
                }, 1);
                }


            }

            if (ContextCompat.CheckSelfPermission(this, Manifest.Permission.CaptureAudioOutput) != Permission.Granted)
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.RecordAudio,
                    Manifest.Permission.ModifyAudioSettings,Manifest.Permission.ReadExternalStorage,
                        Manifest.Permission.WriteExternalStorage,Manifest.Permission.CaptureAudioOutput
                }, 1);
            }


        }

        public override void OnBackPressed()
        {
            if (Rg.Plugins.Popup.Popup.SendBackPressed(base.OnBackPressed))
            {
                // Do something if there are some pages in the `PopupStack`
            }
            else
            {
                // Do something if there are not any pages in the `PopupStack`
            }
        }
    }
}

