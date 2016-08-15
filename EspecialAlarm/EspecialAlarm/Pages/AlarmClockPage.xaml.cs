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
					string alarmTimeText = alarm.ToString().Remove(5);

					var frameContainer = new StackLayout
					{
						Orientation = StackOrientation.Horizontal
					};

					var frameLayout = new Frame()
					{
						BackgroundColor = Color.Accent,
						VerticalOptions = LayoutOptions.StartAndExpand,
						HorizontalOptions = LayoutOptions.FillAndExpand,
						Content = frameContainer
					};

					var alarmText = new Label
					{
						HorizontalOptions = LayoutOptions.StartAndExpand,
						VerticalOptions = LayoutOptions.Center,
						Text = alarmTimeText
					};
					frameContainer.Children.Add(alarmText);

					var switcher = new Switch
					{
						HorizontalOptions = LayoutOptions.EndAndExpand,
						VerticalOptions = LayoutOptions.Center,
					};
					frameContainer.Children.Add(switcher);

					alarmLayout.Children.Add(frameLayout);
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