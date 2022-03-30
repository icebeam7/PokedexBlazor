using Android.App;
using Android.OS;
using Microsoft.Maui;

namespace PokedexBlazor
{
	[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true)]
	public class MainActivity : MauiAppCompatActivity
	{
        protected override void OnCreate(Bundle savedInstanceState)
        {
            Java.Lang.JavaSystem.LoadLibrary("System.Security.Cryptography.Native.OpenSsl");
            base.OnCreate(savedInstanceState);
        }
    }
}