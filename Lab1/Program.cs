using Lab1Library;

class Program
{
    static void Main(string[] args)
    {
        StudentsData studentsData = new StudentsData();
        studentsData.Add(new Student("Andrejs", "Martinciks", "1", "DDBD", "gmail1@gmail.com"));
        studentsData.Add(new Student("Pavel", "Stivens", "2", "DDBI", "gmail2@gmail.com"));

        studentsData.Save();
        studentsData.Load();

        foreach (var student in studentsData.Students)
        {
            Console.WriteLine(student);
        }
    }
}

