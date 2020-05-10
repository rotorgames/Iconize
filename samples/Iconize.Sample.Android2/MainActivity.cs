using Android.App;
using Android.OS;

namespace Iconize.Sample.Android2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            // SetContentView(Resource.Layout.activity_main);

            
            ToolbarResource = Resource.Layout.Toolbar;
            TabLayoutResource = Resource.Layout.Tabs;
            Plugin.Iconize.Iconize.Init(Resource.Id.Toolbar, Resource.Id.Tabs);
            

            LoadApplication(new App());
            
        }
        
    }
}