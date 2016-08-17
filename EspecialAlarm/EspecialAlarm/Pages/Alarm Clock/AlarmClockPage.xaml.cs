using System;
using System.Collections.Generic;
using EspecialAlarm.Classes;
using Xamarin.Forms;

namespace EspecialAlarm.Pages.Alarm_Clock
{
	public partial class AlarmClockPage
	{
		private List<AlarmFrame> _listOfAlarmFrames;

		private async void OnAddAlarmButtonClicked(object sender, EventArgs e)
		{
			var setAlarmClockPage = new SetAlarmClockPage();
			await Navigation.PushAsync(setAlarmClockPage);
		}

		private void LoadAlarmClocks()
		{
			if (AlarmClocks.GetAlarmList() != null)
			{
				var alarmLayout = new StackLayout
				{
					VerticalOptions = LayoutOptions.StartAndExpand
				};

				foreach (var alarm in AlarmClocks.GetAlarmList())
				{
					var alarmFrame = new AlarmFrame(alarm);
					_listOfAlarmFrames.Add(alarmFrame);
					alarmLayout.Children.Add(alarmFrame.mainLayout);
				}

				var scroll = new ScrollView
				{
					Content = alarmLayout
				};

				MainLayout.Children.Add(scroll);
			}
		}

		private void LoadAddAlarmClockButton()
		{
			var addAlarmClockButton = new Button
			{
				Text = "Add Alarm",
				HorizontalOptions = LayoutOptions.Center
			};
			addAlarmClockButton.Clicked += OnAddAlarmButtonClicked;

			MainLayout.Children.Add(addAlarmClockButton);
		}

		protected override void OnAppearing()
		{
			InitializeComponent();
			InitializeListOfAlarmFrame();
			LoadAlarmClocks();
			LoadAddAlarmClockButton();
		}

		private void InitializeListOfAlarmFrame()
		{
			if (_listOfAlarmFrames == null)
				_listOfAlarmFrames = new List<AlarmFrame>();
		}
	}
}