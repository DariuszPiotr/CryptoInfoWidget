using Android.App;
using Android.Widget;
using Android.OS;

namespace CryptoInfoWidget
{
    [Activity(Label = "CryptoInfoWidget", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

           Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate { button.Text = "dasdasd"; };

        }
    }
}

