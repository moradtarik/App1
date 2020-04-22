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
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.layout1);
           
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            WebView webView = FindViewById<WebView>(Resource.Id.webView1);
            EditText edit = FindViewById<EditText>(Resource.Id.editText1);
            button1.Click += delegate
            {
                var intent = new Intent(this, typeof(nokia));
                StartActivity(intent);
            };
            button2.Click += delegate
            {
                var intent = new Intent(this, typeof(dlink));
                StartActivity(intent);

            };
            button3.Click += delegate
            {
                var intent = new Intent(this, typeof(tplink));
                StartActivity(intent);

            }; button4.Click += delegate
            {
                webView.Settings.JavaScriptEnabled = true;
               

            };
            // Create your application here


        }
    }
}