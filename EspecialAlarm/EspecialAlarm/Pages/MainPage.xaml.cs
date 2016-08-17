using System;
using EspecialAlarm.Pages;
using EspecialAlarm.Pages.Stopwatch;
using Xamarin.Forms;
using AlarmClockPage = EspecialAlarm.Pages.Alarm_Clock.AlarmClockPage;

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
			await Navigation.PushAsync(addAlarmClockPage);
		}

		 async void GoToStopwatch(object sender, EventArgs e) {
			var stopwatch = new Main();
			await Navigation.PushModalAsync(stopwatch);
		}
	}
}