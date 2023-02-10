using Android.Content.PM;
using Avalonia.Android;

namespace XamlControlGallery.Android;

[Activity(Label = "@string/app_name", Theme = "@style/MyTheme.NoActionBar", LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.ScreenSize)]
public class MainActivity : AvaloniaMainActivity
{
}
