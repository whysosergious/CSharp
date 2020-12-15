using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Graphics;
using Android.Graphics.Drawables;
using System;
using System.Collections.Generic;

namespace firstXamarinApp {
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]

    public class MainActivity : AppCompatActivity {
        public int i = 1;
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);

            button8.Click += (o, e) => {
                i++;
                button8.Text = i.ToString();
                button8.SetBackgroundColor(color: Color.Red);
                //Device.StartTimer(TimeSpan.FromSeconds(0.25), () => {
                //    button1.background = Color.Red;
                //    return false;
                //});
            };
            button7.Click += (o, e) => {
                i++;
                button7.Text = i.ToString();
                button7.Background.SetColorFilter(Android.Graphics.Color.Red, Android.Graphics.PorterDuff.Mode.Multiply);
                //Device.StartTimer(TimeSpan.FromSeconds(0.25), () => {
                //    button1.background = Color.Red;
                //    return false;
                //});
            };


        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults) {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
}