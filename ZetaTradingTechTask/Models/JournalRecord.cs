using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Hosting.Server;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ZetaTradingTechTask.Models
{
	public class JournalRecord
	{
		public JournalRecord(string type, string queryParameters = "", string bodyParameters = "", string stackTrace = "")
		{
            Id = Guid.NewGuid().GetHashCode();
            Type = type;
            Timestamp = DateTime.Now;
            QueryParameters = queryParameters;
            BodyParameters = bodyParameters;
            StackTrace = stackTrace;
            Data = new JournalRecordData("Internal server error ID = " + Id.ToString());
		}


        [Key]
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        [JsonIgnore]
        public DateTime Timestamp { get; set; }

        [Required]
        [JsonIgnore]
        public string QueryParameters { get; set; }

        [Required]
        [JsonIgnore]
        public string BodyParameters { get; set; }

        [Required]
        [JsonIgnore]
        public string StackTrace { get; set; }

        public JournalRecordData Data { get; set; }
    }
}

