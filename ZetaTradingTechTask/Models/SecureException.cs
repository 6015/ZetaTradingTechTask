using System;
using System.ComponentModel.DataAnnotations;

namespace ZetaTradingTechTask.Models
{
	public class SecureException : JournalRecord
	{
		public SecureException(string message) : base("Secure")
		{
            Data = new JournalRecordData(message);
        }

		[Required]
		public new string Type => "Secure";

	}
}

