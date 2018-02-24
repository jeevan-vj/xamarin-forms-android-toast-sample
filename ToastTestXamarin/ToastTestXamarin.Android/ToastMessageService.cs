using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ToastTestXamarin.Droid;
using ToastTestXamarin;

[assembly: Xamarin.Forms.Dependency(typeof(ToastMessageService))]
namespace ToastTestXamarin.Droid
{
    public class ToastMessageService : IToastMessageService
    {
        public void ShowToastMessage(string message)
        {
           Toast.MakeText(Android.App.Application.Context, message, ToastLength.Long).Show();
        }
    }
}