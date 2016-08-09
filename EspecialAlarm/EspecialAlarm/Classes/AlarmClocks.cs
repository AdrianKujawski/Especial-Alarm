using System;
using System.Collections.Generic;

namespace EspecialAlarm.Classes
{
	public static class AlarmClocks
	{
		private static List<TimeSpan> _dateTimes;

		static AlarmClocks()
		{
			if (_dateTimes == null)
			{
				_dateTimes = new List<TimeSpan>();
				AddAlarmClock(new TimeSpan(17,32,00));
				AddAlarmClock(new TimeSpan(6,30,00));
			}

		}

		public static void AddAlarmClock(TimeSpan time)
		{
			_dateTimes.Add(time);
		}

		public static void RemoveAlarmClock(int i)
		{
			_dateTimes.RemoveAt(i);
		}

		public static List<TimeSpan> GetAlarmList()
		{
			return _dateTimes;
		}
	}
}