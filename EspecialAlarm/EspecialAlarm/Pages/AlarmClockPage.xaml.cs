using System;
using EspecialAlarm.Classes;
using Xamarin.Forms;

namespace EspecialAlarm.Pages
{
	public partial class AlarmClockPage
	{
		public AlarmClockPage()
		{
			InitializeComponent();
			LoadAlarmClocks();
			LoadAddAlarmClockButton();
		}

		private async void OnAddAlarmButtonClicked(object sender, EventArgs e)
		{
			var setAlarmClockPage = new SetAlarmClockPage();
			await Navigation.PushModalAsync(setAlarmClockPage);
		}

		private void LoadAlarmClocks()
		{
			if (AlarmClocks.GetAlarmList() != null)
			{
				StackLayout alarmLayout = new StackLayout
				{
					VerticalOptions = LayoutOptions.StartAndExpand
				};

				foreach (var alarm in AlarmClocks.GetAlarmList())
				{
					var frame = new Frame
					{
						BackgroundColor = Color.Accent,
						VerticalOptions = LayoutOptions.StartAndExpand,
						Content = new Label
						{
							VerticalOptions = LayoutOptions.Center,
							HorizontalOptions = LayoutOptions.Start,
							Text = alarm.ToString()
						}
					};
					alarmLayout.Children.Add(frame);
				}

				var scroll = new ScrollView
				{
					Content = alarmLayout
				};

				stack.Children.Add(scroll);
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

			stack.Children.Add(addAlarmClockButton);
		}

		protected override void OnAppearing()
		{
			//TO DO
			//Nie działa na Androidzie
			InitializeComponent();
			LoadAlarmClocks();
			LoadAddAlarmClockButton();
		}
	}
}