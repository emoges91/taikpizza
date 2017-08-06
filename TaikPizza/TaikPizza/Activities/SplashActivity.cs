using System;
using Android.App;
using Android.Content;
using Android.OS;
using TaikPizza.Activities.Authentication;
using TaikPizza.Utility;

namespace TaikPizza.Activities
{
    [Activity(Label = "Splash", MainLauncher = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Splash);

            SplashTimer wavetimer = new SplashTimer(SplashTimer.SPLASH_DISPLAY_LENGTH + 500, 500);
            wavetimer.OnCompleted += Wavetimer_OnCompleted;

            wavetimer.Start();
        }

        private void Wavetimer_OnCompleted(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(LoginActivity)); 
            StartActivity(intent);
            Finish(); 
        }

    }
}