using System;
namespace ZetaTradingTechTask.Models
{
	public class JournalRecordData
	{
		public JournalRecordData(string message)
		{
			Message = message;
		}

		public string Message { get; set; }
	}
}

