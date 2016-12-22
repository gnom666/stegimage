using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace App2.Droid
{
    [Activity(Label = "App2", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        public string GetTextFromClipBoard()
        {
            var clipboardmanager = (ClipboardManager)GetSystemService(Context.ClipboardService);
            var item = clipboardmanager.PrimaryClip.GetItemAt(0);
            var text = item.Text;
            return text;
        }

        public void SetTextToClipBoard(string text)
        {
            var clipboardmanager = (ClipboardManager)GetSystemService(Context.ClipboardService);
            ClipData clip = ClipData.NewPlainText("label", text);
            clipboardmanager.PrimaryClip = clip;
        }
    }
}

