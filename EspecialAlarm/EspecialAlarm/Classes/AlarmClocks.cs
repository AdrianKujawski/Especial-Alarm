using System;
using System.Collections.Generic;

namespace EspecialAlarm.Classes
{
	public class AlarmClocks
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

		public static void RemoveAlarmClock(TimeSpan checkedTime)
		{
			_dateTimes.Remove(checkedTime);
		}

		public static List<TimeSpan> GetAlarmList()
		{
			return _dateTimes;
		}

	}
}