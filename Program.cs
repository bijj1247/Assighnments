using System;

class Student
{
    string studentName;
    string rollNumber;
    int[] marks;

    // Constructor
    public Student(string name, string roll, int[] marks)
    {
        this.studentName = name;
        this.rollNumber = roll;
        this.marks = marks;
    }

    public double CalculateAverage()
    {
        int sum = 0;
        foreach (int mark in marks)
        {
            sum += mark;
        }
        return sum / 5.0;
    }

    public string CalculateGrade()
    {
        double avg = CalculateAverage();
        if (avg >= 90) return "A+";
        else if (avg >= 80) return "A";
        else if (avg >= 70) return "B";
        else if (avg >= 60) return "C";
        else if (avg >= 50) return "D";
        else return "Fail";
    }

    public override string ToString()
    {
        string marksList = "";
        foreach (int m in marks)
        {
            marksList += m + " ";
        }
        return "Student Name: " + studentName +"\nRoll Number: " + rollNumber +"\nMarks: " + marksList +"\nAverage: " + CalculateAverage() +"\nGrade: " + CalculateGrade();
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Enter Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Enter Roll Number: ");
        string roll = Console.ReadLine();

        int[] marks = new int[5];

        Console.WriteLine("Enter marks for 5 subjects:");

        for (int i = 0; i < 5; i++)
        {
            Console.Write("Subject " + (i + 1) + ": ");
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        Student s = new Student(name, roll, marks);

        Console.WriteLine("Student Report");
        Console.WriteLine(s);
    }
}