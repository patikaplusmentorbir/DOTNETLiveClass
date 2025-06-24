
using Inheritance.Models;

Mentor mentor = new Mentor()
{
    FirstName = "Sertan",
    LastName = "Bozkuş",
    Salary = 1238712938131321,
    HoursWork = 40
};



Student student = new Student()
{
    FirstName = "Emre",
    LastName = "Yılmaz",
    StudentNumber = "123"
};

// Bir class newlenirken Constructor'ı 1 kez çalışır, ilk önce base class'ın constructor'ı sonra kendi consturctorı.

mentor.CodeIt();
mentor.RecordClassLessons();
Console.WriteLine("--------------");
student.CodeIt();
student.CompleteTasks();
