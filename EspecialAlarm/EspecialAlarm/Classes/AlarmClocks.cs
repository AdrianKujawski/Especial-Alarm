using System;
using System.Collections.Generic;
using System.Diagnostics;

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
				_dateTimes.Add(new TimeSpan(8,0,0));
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

		public static void ReplaceItem(TimeSpan oldTime, TimeSpan newTime)
		{
			var matchTime = _dateTimes.FindIndex(p => p.Equals(oldTime));
			_dateTimes.RemoveAt(matchTime);
			_dateTimes.Insert(matchTime, newTime);
		}

	}
}