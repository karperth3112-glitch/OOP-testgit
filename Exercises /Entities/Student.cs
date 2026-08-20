namespace Exercises.Entities;

public class Student
{
    public string name;
    public double score;
    public static int totalStudent;

    // Constructor
    public Student(string name, double score)
    {
        this.name = name;
        this.score = score;
        totalStudent++;
    }

    // Instance Method
    public string GetName()
    {
        return name;
    }

    public double GetScore()
    {
        return score;
    }

    public bool IsPassed()
    {
        if (score >= 5.0)
            return true;
        else
            return false;
    }

    public string GetClassification()
    {
        string result = "";

        if (score >= 8.0)
            result = "Excellent";
        else if (score >= 6.5)
            result = "Good";
        else if (score >= 5.0)
            result = "Average";
        else
            result = "Weak";

        return result;
    }

    // Static Method
    public static int GetTotalStudents()
    {
        return totalStudent;
    }

    // Thêm vào class Student
    public void DisplayInfo()
    {
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Score: " + GetScore());
        Console.WriteLine("Passed: " + IsPassed());
        Console.WriteLine("Classification: " + GetClassification());
    }
    
    public static Student FindTopStudent(Student[] students)
    {
        Student topStudent = students[0];

        for (int i = 1; i < students.Length; i++)
        {
            if (students[i].score > topStudent.score)
            {
                topStudent = students[i];
            }
        }

        return topStudent;
    }

    public static double CalculateAverageScore(Student[] students)
    {
        double sum = 0;

        for (int i = 0; i < students.Length; i++)
        {
            sum += students[i].score;
        }

        double average = sum / students.Length;

        return average;
    }
}