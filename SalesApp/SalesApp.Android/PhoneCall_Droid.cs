using System;
using Android.Content;
using SalesApp.Droid;
using SalesApp.views;
using Xamarin.Forms;

[assembly: Dependency(typeof(PhoneCall_Droid))]
namespace SalesApp.Droid
{
    public class PhoneCall_Droid : IPhoneCall
    {
        public void makecall(string phno)
        {
            //try
            //{
            var URI = Android.Net.Uri.Parse(string.Format("tel:{0}", phno));
            var intent = new Intent(Intent.ActionCall, URI);
            Forms.Context.StartActivity(intent);
            //  }

            //catch(Exception e )
            //{

            //}
        }
    }
}

