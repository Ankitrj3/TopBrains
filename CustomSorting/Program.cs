public class Student
{
    public string? Name{get; set;}
    public int Age{get; set;}
    public double Marks{get; set;}
    public Student(){}

    private List<Student> _student = new List<Student>();
    public void AddStudent(Student students)
    {
        if(_student.Any(s => s.Name == students.Name && s.Age == students.Age && s.Marks == students.Marks))
        {
            Console.WriteLine("Student Already Present......");
            return;
        }
        _student.Add(students);
    }
    public List<Student> CustomSorting()
    {
        return _student.OrderByDescending(s => s.Marks)
                       .ThenBy(k => k.Age)
                       .ToList();
    }
    public void displaySortedList()
    {
        var sorting = CustomSorting();
        foreach (var s in sorting)
        {
            Console.WriteLine("Student Name is "+s.Name+" Student Age is "+s.Age+" Student Marks is "+s.Marks);
        }
    }
}
public class Program
{
    public static void Main()
    {
        Student student = new Student();
        Console.WriteLine("Enter Number of Student you Want to Enter");
        string? N = Console.ReadLine();
        int n = int.Parse(N??"");
        
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter The Name Of Student No "+(i+1));
            string? name = Console.ReadLine();
            Console.WriteLine("Enter The Age Of Student No "+(i+1));
            string? Age1 = Console.ReadLine();
            int age = int.Parse(Age1??"");
            Console.WriteLine("Enter The Marks Of Student No "+(i+1));
            string? Marks1 = Console.ReadLine();
            double marks = double.Parse(Marks1??"");
            Student s = new Student()
            {
                Name = name,
                Age = age,
                Marks = marks
            };
            student.AddStudent(s);
        }
        student.displaySortedList();
    }
}
