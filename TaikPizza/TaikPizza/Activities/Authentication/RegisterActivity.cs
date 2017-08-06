﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace TaikPizza.Activities.Authentication
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Register);
        }

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(LoginActivity)); 
            StartActivity(intent);
            Finish();
            base.OnBackPressed();
        }
    }
}