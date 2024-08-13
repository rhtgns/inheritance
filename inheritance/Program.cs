
using inheritance;

class BaseKisi
{
    static void Main(string[] args)
    {

        Student student = new Student
        {
            Name = "Rohat",
            SurName = "Gunes",
            StudentNo = 509
        };
        Teacher teacher = new Teacher
        {
            Name = "leyla",
            SurName = "Şen",
            TeacherSalary = 32000
        };

        Console.WriteLine("ogrencı  bilgileri");
        student.ReadNameSurnameStudent();
        teacher.ReadTeacherInfo();


    }

    }