using System;
using EspecialAlarm.Pages.Alarm_Clock;
using Xamarin.Forms;

namespace EspecialAlarm.Classes
{
	internal class AlarmFrame
	{
		private TimeSpan _alarm;

		public AlarmFrame(TimeSpan alarm)
		{
			_alarm = alarm;
			CreateFrameLayout();
		}

		public Frame mainLayout { get; private set; }

		private void CreateFrameLayout()
		{
			var alarmTimeText = _alarm.ToString().Remove(5);

			StackLayout frameContainer = new StackLayout
			{
				Orientation = StackOrientation.Horizontal
			};

			var alarmText = new Label {
				HorizontalOptions = LayoutOptions.StartAndExpand,
				VerticalOptions = LayoutOptions.Center,
				FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
				Text = alarmTimeText
			};
			frameContainer.Children.Add(alarmText);

			var switcher = new Switch {
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center
			};
			frameContainer.Children.Add(switcher);

			var optionButton = new Button {
				HorizontalOptions = LayoutOptions.End,
				VerticalOptions = LayoutOptions.Center,
				Text = "Options"
			};
			optionButton.Clicked += OnOptionButtonClicked;
			frameContainer.Children.Add(optionButton);

			mainLayout = new Frame
			{
				BackgroundColor = Color.Accent,
				VerticalOptions = LayoutOptions.StartAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Content = frameContainer
			};
		}

		private async void OnOptionButtonClicked(object sender, EventArgs e)
		{
			var editAlarmPage = new EditAlarmPage(_alarm);
			await Application.Current.MainPage.Navigation.PushAsync(editAlarmPage);
		}
	}
}