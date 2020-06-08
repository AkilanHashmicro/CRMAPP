﻿using System;
using SalesApp;
using SalesApp.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomPicker), typeof(CustomPickerRenderer))]
namespace SalesApp.Droid
{
    public class CustomPickerRenderer : PickerRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Picker> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                //GradientDrawable gd = new GradientDrawable();
                //gd.SetColor(global::Android.Graphics.Color.Transparent);
                //this.Control.SetBackgroundDrawable(gd);
                //this.Control.SetRawInputType(InputTypes.TextFlagNoSuggestions);
                //Control.SetHintTextColor(ColorStateList.ValueOf(global::Android.Graphics.Color.White));

                // this.Control.InputType = InputTypes.TextFlagNoSuggestions;

                Control.SetBackgroundColor(Android.Graphics.Color.Argb(0, 0, 0, 0));
                Control.ShowSoftInputOnFocus = false;

            }

            //else if ((e.NewElement as CustomEntry).Is) 
            //{
            //    Control.KeyboardType = UIKeyboardType.EmailAddress;
            //}


        }
    }
}