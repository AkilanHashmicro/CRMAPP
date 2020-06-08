
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace SalesApp.Droid
{
    [Activity(Theme = "@style/Theme.Splash",  
        MainLauncher=true,  
        NoHistory = true)] 
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);


            base.OnCreate(savedInstanceState);
         //   System.Threading.Thread.Sleep(3000);
            StartActivity(typeof(MainActivity));
            // Create your application here
        }
    }
}
