using System.Diagnostics;
using EspecialAlarm.Pages;
using Xamarin.Forms;

namespace EspecialAlarm
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new MainPage();
		}

		protected override void OnStart()
		{
			// Handle when your app start
			Debug.WriteLine("Start");
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
			Debug.WriteLine("Sleep");
		}

		protected override void OnResume()
		{
			Debug.WriteLine("Resume");
			// Handle when your app resumes
		}
	}
}