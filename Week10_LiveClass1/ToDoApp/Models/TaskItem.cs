namespace ToDoApp.Models
{
    public class TaskItem : BaseClass
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }

        public int CategoryId { get; set; } // Foreign Key
    }
}
