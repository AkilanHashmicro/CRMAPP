using System;

using Xamarin.Forms;

namespace SalesApp.Droid
{
    public class Toast_Android : ContentPage
    {
        public Toast_Android()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

