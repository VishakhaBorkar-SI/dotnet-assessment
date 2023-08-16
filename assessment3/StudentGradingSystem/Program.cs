using System;
namespace StudentGradingSystem
{
   

    class Student
    {
        public string Name { get; set; }
        public int[] Grades { get; set; }

        public Student(string name, int numberOfGrades)
        {
            Name = name;
            Grades = new int[numberOfGrades];
        }

        public double CalculateAverageGrade()
        {
            int sum = 0;
            foreach (int grade in Grades)
            {
                sum += grade;
            }
            return (double)sum / Grades.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Student Grading System");
            Console.WriteLine("----------------------");

            Console.Write("Enter the name of the student: ");
            string name = Console.ReadLine();

            Console.Write("Enter the number of grades to be entered: ");
            int numberOfGrades = 0;

            try
            {
                numberOfGrades = Convert.ToInt32(Console.ReadLine());
                if (numberOfGrades <= 0)
                {
                    throw new Exception("Number of grades must be a positive integer.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input! Please enter a numeric value.");
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            Student student = new Student(name, numberOfGrades);

            for (int i = 0; i < numberOfGrades; i++)
            {
                try
                {
                    Console.Write($"Enter grade {i + 1}: ");
                    int grade = Convert.ToInt32(Console.ReadLine());

                    if (grade < 0 || grade > 100)
                    {
                        throw new Exception("Invalid input! Grade must be between 0 and 100.");
                    }

                    student.Grades[i] = grade;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter a numeric value.");
                    i--; // Retry for the same index to re-enter the grade
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    i--; // Retry for the same index to re-enter the grade
                }
            }

            Console.WriteLine($"\nStudent: {student.Name}");
            Console.WriteLine($"Grades: {string.Join(", ", student.Grades)}");
            Console.WriteLine($"Average Grade: {student.CalculateAverageGrade()}");
        }
    }

}
