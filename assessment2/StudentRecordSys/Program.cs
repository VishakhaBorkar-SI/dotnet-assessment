using System;
using System.Collections.Generic;
namespace StudentRecordSys
{
    

    class Student
    {
        private string name;
        private int age;
        private string gender;
        private string studentId;
        private List<string> courseEnrollment = new List<string>();

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public List<string> CourseEnrollment
        {
            get { return courseEnrollment; }
            set { courseEnrollment = value; }
        }

        public double GPA
        {
            get
            {
                // Assume grades are represented as integers: A=4, B=3, C=2, D=1, F=0
                if (courseEnrollment.Count == 0)
                    return 0.0;

                int totalGrades = 0;
                foreach (string courseGrade in courseEnrollment)
                {
                    switch (courseGrade)
                    {
                        case "A":
                            totalGrades += 4; 
                            break;
                        case "B": 
                            totalGrades += 3; 
                            break;
                        case "C": 
                            totalGrades += 2; 
                            break;
                        case "D": 
                            totalGrades += 1; 
                            break;
                        case "F": 
                            totalGrades += 0; 
                            break;
                    }
                }
                return (double)totalGrades / courseEnrollment.Count;
            }
        }
    }

    class School
    {
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void DisplayStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Gender: {student.Gender}, Student ID: {student.StudentId}, GPA: {student.GPA:F2}");
                Console.Write("Course Enrollment: ");
                if (student.CourseEnrollment.Count == 0)
                    Console.WriteLine("None");
                else
                    Console.WriteLine(string.Join(", ", student.CourseEnrollment));
            }
        }

        public double CalculateOverallGPA()
        {
            if (students.Count == 0)
                return 0.0;

            double totalGPA = 0;
            foreach (var student in students)
            {
                totalGPA += student.GPA;
            }
            return totalGPA / students.Count;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();

            while (true)
            {
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Calculate Overall GPA");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student student = new Student();
                        Console.Write("Enter Name: ");
                        student.Name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        student.Age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Gender: ");
                        student.Gender = Console.ReadLine();
                        Console.Write("Enter Student ID: ");
                        student.StudentId = Console.ReadLine();
                        Console.Write("Enter Course Enrollment (comma-separated): ");
                        student.CourseEnrollment = new List<string>(Console.ReadLine().Split(','));
                        school.AddStudent(student);
                        break;
                    case 2:
                        school.DisplayStudents();
                        break;
                    case 3:
                        double overallGPA = school.CalculateOverallGPA();
                        Console.WriteLine($"Overall GPA of the school: {overallGPA:F2}");
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }
    }
}