using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EspecialAlarm.Pages.Stopwatch
{

	public partial class Main : ContentPage
	{
		readonly System.Diagnostics.Stopwatch _stopwatch;

		public Main()
		{
			
			InitializeComponent();
			_stopwatch = new System.Diagnostics.Stopwatch();
			InfiniteLoop();
		}

		private void ChangeState(object sender, EventArgs e)
		{
			if (StartPause.Text == "Start")
			{
				StartPause.Text = State.Pause.ToString();
				_stopwatch.Start();
			}
			else
			{
				StartPause.Text = State.Start.ToString();
				_stopwatch.Stop();
			}
		}

		private void StopState(object sender, EventArgs e)
		{
			_stopwatch.Reset();
		}

		private async void InfiniteLoop()
		{
			while (true)
			{
				var secounds = _stopwatch.Elapsed.Seconds.ToString();
				var minutes = _stopwatch.Elapsed.Minutes.ToString();
				var hours = _stopwatch.Elapsed.Hours.ToString();
				TimerState.Text = $"{hours}:{minutes}:{secounds}";
				await Task.Delay(250);
			}
		}
	}

	enum State
	{
		Pause = 0,
		Start = 1
	};

}
