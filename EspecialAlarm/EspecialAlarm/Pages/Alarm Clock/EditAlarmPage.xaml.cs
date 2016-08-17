using System;
using EspecialAlarm.Classes;
using Xamarin.Forms;

namespace EspecialAlarm.Pages.Alarm_Clock
{
	public partial class EditAlarmPage : ContentPage
	{
		private readonly TimeSpan _checkedTime;

		public EditAlarmPage(TimeSpan time)
		{
			InitializeComponent();
			_checkedTime = time;
		}

		private async void OnEditButtonClicked(object sender, EventArgs e)
		{
			var editPage = new SetAlarmClockPage(_checkedTime);
			await Navigation.PushAsync(editPage);
			Navigation.RemovePage(this);
		}

		private async void OnDeleteButtonClicked(object sender, EventArgs e)
		{
			if (_checkedTime != null)
				AlarmClocks.RemoveAlarmClock(_checkedTime);
			await Navigation.PopAsync();
		}
	}
}