using System;
using System.ComponentModel.DataAnnotations;

namespace Tasks.Models
{
	public class TodosModel
	{
        [Key]
        public string Id { get; set; }
        [Required]
        public String title { get; set; }
        [Required]
        public string description { get; set; }

		public Boolean isCompleted { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

