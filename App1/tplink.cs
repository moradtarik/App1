using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;

namespace App1
{
    [Activity(Label = "tplink")]
    public class tplink : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.tplink);

            WebView webView = FindViewById<WebView>(Resource.Id.webView1);
            Button button = FindViewById<Button>(Resource.Id.button1);

            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl("http://192.168.1.1/login_security.html");


            button.Click += delegate
            {
                var intent = new Intent(this, typeof(Activity1));
                StartActivity(intent);

            };
            // Create your application here
        }
    }
}