namespace Exercises;
using Exercises.Entities;


class Program
{
    static void Main(string[] args)
    {
        // Create Student objects
        Student student1 = new Student("An", 8.5);
        Student student2 = new Student("Binh", 7.0);
        Student student3 = new Student("Cuong", 4.5);
        Student student4 = new Student("Dung", 9.0);

        // Create Student array
        Student[] students = { student1, student2, student3, student4 };

        student1.DisplayInfo();
        
        // Get information of student1
       // Console.WriteLine("Name: " + student1.GetName());
       // Console.WriteLine("Score: " + student1.GetScore());
        //Console.WriteLine("Passed: " + student1.IsPassed());
      //  Console.WriteLine("Classification: " + student1.GetClassification());

        Console.WriteLine();

        // Get total students
        Console.WriteLine("Total students: " + Student.GetTotalStudents());

        // Find top student
        Student topStudent = Student.FindTopStudent(students);

        Console.WriteLine("Top student: " + topStudent.GetName());
        Console.WriteLine("Top score: " + topStudent.GetScore());

        Console.WriteLine();

        // Calculate average score
        double average = Student.CalculateAverageScore(students);

        Console.WriteLine("Average score: " + average);
    }
}