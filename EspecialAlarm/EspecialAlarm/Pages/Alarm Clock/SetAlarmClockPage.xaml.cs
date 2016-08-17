using System;
using EspecialAlarm.Classes;
using Xamarin.Forms;

namespace EspecialAlarm.Pages
{
	public partial class SetAlarmClockPage : ContentPage
	{
		public SetAlarmClockPage()
		{
			InitializeComponent();
			CreateDoneButton();
			SetTimeToCurrent();
		}

		public SetAlarmClockPage(TimeSpan alarm)
		{
			InitializeComponent();
			CreateEditButton(alarm);
			SetTimeToCurrent(alarm);
		}

		private async void OnCancelButtonClicked(object sender, EventArgs e)
		{
			await Navigation.PopAsync();
		}

		private async void OnDoneButtonClicked(object sender, EventArgs e)
		{
			ConfirmNewAlarm();
			await Navigation.PopAsync();
		}

		private async void OnEditButtonClicked(object sender, TimeSpan time)
		{
			ConfirmEdit(time);
			await Navigation.PopAsync();
		}

		private void SetTimeToCurrent()
		{
			var hh = DateTime.Now.Hour;
			var mm = DateTime.Now.Minute;
			timePicker.Time = new TimeSpan(hh, mm, 0);
		}

		private void SetTimeToCurrent(TimeSpan time)
		{
			var hh = time.Hours;
			var mm = time.Minutes;
			timePicker.Time = new TimeSpan(hh, mm, 0);
		}

		private void ConfirmNewAlarm()
		{
			var time = timePicker.Time;
			AlarmClocks.AddAlarmClock(time);
		}

		private void ConfirmEdit(TimeSpan alarm)
		{
			//TO DO
			AlarmClocks.ReplaceItem(alarm, timePicker.Time);
		}

		private void CreateDoneButton()
		{
			var doneButton = new Button
			{
				Text = "Done"
			};
			doneButton.Clicked += OnDoneButtonClicked;
			grid.Children.Add(doneButton, 1, 0);
		}

		private void CreateEditButton(TimeSpan time)
		{
			var editButton = new Button
			{
				Text = "Edit"
			};
			editButton.Clicked += (sender, args) => OnEditButtonClicked(editButton, time);
			grid.Children.Add(editButton, 1, 0);
		}
	}
}