using System;

public class Student
{
    private string name;
    private byte age;

    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidStudentDataException("Имя не может быть пустым, чел");
            }
            name = value;
        }
    }

    public byte Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 100)
            {
                throw new InvalidStudentDataException("Ты чё, типа вампир или в негативном мире?");
            }
            age = value;
        }
    }
}

public class Group
{
    private string groupName;
    private int courseNumber;

    public string GroupName
    {
        get { return groupName; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new InvalidGroupDataException("У твоей группы название немое или ты писать не умеешь?");
            }
            groupName = value;
        }
    }

    public int CourseNumber
    {
        get { return courseNumber; }
        set
        {
            if (value < 1 || value > 10)
            {
                throw new InvalidGroupDataException("Ты точно понимаешь, что такое числа от 1 до 10?");
            }
            courseNumber = value;
        }
    }
}

public class InvalidStudentDataException : Exception
{
    public InvalidStudentDataException(string message) : base(message)
    {
    }
}

public class InvalidGroupDataException : Exception
{
    public InvalidGroupDataException(string message) : base(message)
    {
    }
}
class Program
{
    static void Main(string[] args)
    {
        try
        {
            Student student = new Student();
            student.Name = "Alex";
            student.Age = 25;
        }
        catch (InvalidStudentDataException ex)
        {
            Console.WriteLine($"Инвалид ошибка ужс: {ex.Message}");
        }

        Console.ReadLine();
    }
}
