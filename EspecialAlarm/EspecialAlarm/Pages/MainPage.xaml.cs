using System;
using EspecialAlarm.Pages;
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
	}
}