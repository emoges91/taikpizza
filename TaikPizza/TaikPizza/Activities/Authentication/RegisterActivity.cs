
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace TaikPizza.Activities.Authentication
{
    [Activity(Label = "RegisterActivity")]
    public class RegisterActivity : Activity
    {
        #region properties 
        private Button signUpButton;
        private EditText mailEditText;
        private EditText passwordEditText;
        private EditText nameEditText;
        private EditText lastNameEditText;
        private EditText telephoneEditText;
        private EditText passwordConfirmEditText;
        #endregion

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Register);

            FindViews();
            HandleEvents();
        }

        #region FindViews
        private void FindViews()
        {
            signUpButton = FindViewById<Button>(Resource.Id.signUpButton);
            mailEditText = FindViewById<EditText>(Resource.Id.mailEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            passwordConfirmEditText = FindViewById<EditText>(Resource.Id.passwordConfirmEditText);
            nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            lastNameEditText = FindViewById<EditText>(Resource.Id.lastNameEditText);
            telephoneEditText = FindViewById<EditText>(Resource.Id.telephoneEditText);
        }
        #endregion

        #region HandleEvents
        private void HandleEvents()
        {
            signUpButton.Click += SignUpButton_Click;
        }

        private void SignUpButton_Click(object sender, System.EventArgs e)
        {
            var intent = new Intent(this, typeof(LoginActivity));
            intent.PutExtra("UserID", 1);
            StartActivity(intent);

            Finish();
        }
        #endregion

        public override void OnBackPressed()
        {
            var intent = new Intent(this, typeof(LoginActivity));
            StartActivity(intent);
            Finish();
            base.OnBackPressed();
        }
    }
}