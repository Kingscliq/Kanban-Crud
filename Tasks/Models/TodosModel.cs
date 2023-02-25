using System;
namespace Tasks.Models
{
	public class TodosModel
	{
		public String title { get; set; }
        public string description { get; set; }
		public Boolean isCompleted { get; set; }


        public TodosModel(string title,  string description)
        {
			this.description = description;
			this.title = title;
        }
        public TodosModel(string title, string description, Boolean isCompleted)
			:this(title, description)
		{
			this.isCompleted = isCompleted ;
		}
    }
}

