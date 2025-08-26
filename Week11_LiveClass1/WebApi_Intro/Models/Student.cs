namespace WebApi_Intro.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        public bool IsActive { get; set; } // Öğrenci eğitime devam ediyor mu bilgisi.
        public bool IsDeleted { get; set; } // Soft Delete işlemi için.
    }
}
