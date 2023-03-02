using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tasks.Models
{
	public class TodosModel
	{
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Required]
        public String title { get; set; }
        [Required]
        public string description { get; set; }

        public Boolean isCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}

