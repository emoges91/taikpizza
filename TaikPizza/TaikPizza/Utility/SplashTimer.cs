using System;
using Android.Content;
using Android.OS;

namespace TaikPizza.Utility
{
    public class SplashTimer : CountDownTimer
    {
        private long millisActual;
        public static int SPLASH_DISPLAY_LENGTH = 2000;

      

        public SplashTimer(long millisInFuture, long countDownInterval)
             : base(millisInFuture, countDownInterval)
        {
            millisActual = millisInFuture;
        }

        public event EventHandler OnCompleted;

        public override void OnFinish()
        {
            OnCompleted?.Invoke(this, null);
        }

        public override void OnTick(long millisUntilFinished)
        {
            // v start showing the tick after 3 seconds.
            if (millisUntilFinished <= millisActual)
            {
                //i = i + 500;
                //double nPercentage = ((i / SPLASH_DISPLAY_LENGTH) * 100);
                //percentage.setText("" + nPercentage + "%");
            }
        }

    }
}

