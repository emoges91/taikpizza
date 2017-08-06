using System;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using TaikPizza.Activities.Orders;

namespace TaikPizza.Activities.Authentication
{
    [Activity(Label = "Iniciar Sesion", MainLauncher = true)]
    public class LoginActivity : Activity
    {
        #region properties 
        private Button loginButton;
        private Button signUpButton; 
        private EditText mailEditText;
        private EditText passwordEditText;
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Login);

            FindViews();
            HandleEvents();
        }

        #region FindViews
        private void FindViews()
        {
            loginButton = FindViewById<Button>(Resource.Id.loginButton);
            signUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            mailEditText = FindViewById<EditText>(Resource.Id.mailEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
        }
        #endregion

        #region HandleEvents
        private void HandleEvents()
        {
            loginButton.Click += LoginButton_Click;
            signUpButton.Click += SignUpButton_Click;
        }
        #endregion

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(RegisterActivity)); 
            intent.PutExtra("UserID", 1);
            StartActivity(intent);
            Finish();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(QuickOrderActivity));
            intent.PutExtra("UserID", 1);
            StartActivity(intent);
            Finish();
        }
    }
}