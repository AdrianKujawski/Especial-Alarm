using System;
using EspecialAlarm.Pages;
using EspecialAlarm.Pages.Stopwatch;
using Xamarin.Forms;

namespace EspecialAlarm
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		async private void OnAlarmClockButtonClicked(object sender, EventArgs e)
		{
			var addAlarmClockPage = new AlarmClockPage();
			await Navigation.PushModalAsync(addAlarmClockPage);
		}

		 async void GoToStopwatch(object sender, EventArgs e) {
			var stopwatch = new Main();
			await Navigation.PushModalAsync(stopwatch);
		}
	}
}