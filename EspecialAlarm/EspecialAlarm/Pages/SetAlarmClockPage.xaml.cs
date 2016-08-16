using System;
using System.Diagnostics;
using System.Dynamic;
using System.Threading.Tasks;
using EspecialAlarm.Classes;
using Xamarin.Forms;

namespace EspecialAlarm.Pages
{
	public partial class SetAlarmClockPage : ContentPage
	{

		public SetAlarmClockPage()
		{
			InitializeComponent();
			SetTimeToCurrent();
		}

		private async void OnCancelButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopModalAsync();
		}

		private async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			ConfirmNewAlarm();
			await Navigation.PopModalAsync();
		}

		private void SetTimeToCurrent()
		{
			var hh = DateTime.Now.Hour;
			var mm = DateTime.Now.Minute;
			timePicker.Time = new TimeSpan(hh, mm, 0);
		}

		private void ConfirmNewAlarm()
		{
			TimeSpan time = timePicker.Time;
			Debug.WriteLine(time.ToString());
			AlarmClocks.AddAlarmClock(time);
		}
	}
}