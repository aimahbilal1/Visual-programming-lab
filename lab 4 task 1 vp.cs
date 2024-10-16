using System;

public class Person
{
    public string Name { get; set; }

    public Person()
    {
        Name = null; 
    }
    public Person(string name)
    {
        Name = name;
    }
    public void DisplayPersonInfo()
    {
        Console.WriteLine($"Name: {Name}");
    }
}
public enum Department
{
    ComputerScience,
    Mathematics,
    Physics,
    Chemistry
}

public class Student : Person
{
    public string RegNo { get; set; }
    public int Age { get; set; }
    public Department Program { get; set; }

    public Student() : base()
    {
        RegNo = null; 
        Age = 0;      
        Program = Department.ComputerScience; 
    }
    public Student(string name, string regNo, int age, Department program) : base(name)
    {
        RegNo = regNo;
        Age = age;
        Program = program;
    }
    public void DisplayStudentInfo()
    {
        Console.WriteLine($"Name: {Name}, RegNo: {RegNo}, Age: {Age}, Program: {Program}");
    }
}

public class Program
{
    public static void Main()
    {
        Person person1 = new Person("John Doe");
        person1.DisplayPersonInfo();
        Student student1 = new Student("Alice", "S1234", 20, Department.Mathematics);
        student1.DisplayStudentInfo();

        Student student2 = new Student();
        student2.DisplayStudentInfo();
    }
}
