namespace ToDoApp.Models
{

    // Category ekleme işlemleri sırasında view ile controller arasında veri taşıyacak olan model.
    public class CategoryAddViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
