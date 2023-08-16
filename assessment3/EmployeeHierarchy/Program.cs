namespace EmployeeHierarchy
{
    using System;

    abstract class Employee
    {
        public string Name { get; set; }
        public string EmployeeID { get; set; }
        public decimal Salary { get; set; }

        public abstract decimal CalculateBonus();

        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Employee ID: {EmployeeID}");
            Console.WriteLine($"Salary: ${Salary}");
        }
    }

    class Manager : Employee
    {
        public override decimal CalculateBonus()
        {
            // Managers get a 15% bonus based on their salary
            return Salary * 0.15;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }

    class Developer : Employee
    {
        public override decimal CalculateBonus()
        {
            // Developers get a 10% bonus based on their salary
            return Salary * 0.10;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }

    class SalesPerson : Employee
    {
        public override decimal CalculateBonus()
        {
            // Salespersons get a 12% bonus based on their salary
            return Salary * 0.12;
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Bonus: ${CalculateBonus()}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "John Doe",
                EmployeeID = "M001",
                Salary = 50000
            };

            Developer developer = new Developer
            {
                Name = "Jane Smith",
                EmployeeID = "D001",
                Salary = 60000
            };

            SalesPerson salesPerson = new SalesPerson
            {
                Name = "Bob Johnson",
                EmployeeID = "S001",
                Salary = 45000
            };

            Console.WriteLine("Manager Details:");
            manager.DisplayDetails();

            Console.WriteLine("\nDeveloper Details:");
            developer.DisplayDetails();

            Console.WriteLine("\nSalesPerson Details:");
            salesPerson.DisplayDetails();

            Console.ReadLine();
        }
    }

}