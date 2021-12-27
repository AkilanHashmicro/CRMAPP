using System;
using SalesApp.Droid;
using SalesApp.views;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(Toast_Android))]
namespace SalesApp.Droid
{
    public class Toast_Android : Toast
    {
        public void Show(string message)
        {
            Android.Widget.Toast.MakeText(Android.App.Application.Context, message, Android.Widget.ToastLength.Long).Show();
        }
    }
}

