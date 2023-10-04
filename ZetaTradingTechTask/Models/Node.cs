using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ZetaTradingTechTask.Models
{
	public class Node
	{
        [Key]
        public int NodeId { get; set; }

        [Required]
        public string Name { get; set; }

        [ForeignKey("ParentNode")]
        public int? ParentNodeId { get; set; }

        [JsonIgnore]
        public virtual ICollection<Node> ChildNodes { get; set; }

        public Node(string name)
        {
            Name = name;
            ChildNodes = new List<Node>();
        }
    }
}

