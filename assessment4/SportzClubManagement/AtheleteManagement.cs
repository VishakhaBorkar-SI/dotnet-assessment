using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    internal class AtheleteManagement
    {
        int athleteId;
        String firstName;
        String lastName;
        int age;
        string sport;
        DateTime Date;
        static List<AtheleteManagement> Athletes = new List<AtheleteManagement>();
        Program Program = new Program();

        public AtheleteManagement() { }
        public AtheleteManagement(int AthleteId, string firstName, string lastName, int age, string sport, DateTime date)
        {
            this.athleteId = AthleteId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.sport = sport;
            this.Date = date;
        }



        public void Create_Athelte(string firstName, string lastName, int age, string sport, DateTime date)
        {
            if (Athletes.Count == 0) { athleteId = 1; }
            else { athleteId = Athletes.Last().athleteId + 1; }

            AtheleteManagement athelete = new AtheleteManagement(athleteId, firstName, lastName, age, sport, date);
            Athletes.Add(athelete);

            Console.WriteLine($"The Player with first name : {firstName} have athelete id : {athleteId} ");

        }


        public void display(int Id)
        {
            foreach (AtheleteManagement ath in Athletes)
            {

                if (Id == ath.athleteId)
                {

                    Console.WriteLine("The details of the Athlete is ");
                    Console.WriteLine($"Athelete Id of the player is : {ath.athleteId} \t First Name of the Athlete is : {ath.firstName} \t Last name of Athlete is : {ath.lastName} \n Age of the athelete is : {ath.age} \t The sport played is : {ath.sport} \t registration date of the player is : {ath.Date}");
                    return;
                }

            }
            Console.WriteLine("Athelete didn't found ");
            Console.WriteLine("Do you want to add the athelete ");
            Console.WriteLine("If yes Press y if no press n");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y' && choice == 'Y')
            {
                Program.InteractiveConsole();
            }
            else { return; }

        }
        public void RemoveAthelete(int id)
        {
            foreach (AtheleteManagement ath in Athletes)
            {

                if (id == ath.athleteId)
                {
                    Athletes.Remove(ath);
                    Console.WriteLine($"Player removed with {id} and name : {ath.firstName} {ath.lastName}");
                    return;
                }
            }
            Console.WriteLine("Athelete didn't found ");
            Console.WriteLine("Do you want to add the athelete ");
            Console.WriteLine("If yes Press y if no press n");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'y' && choice == 'Y')
            {
                Program.InteractiveConsole();
            }
            else { return; }


        }

        public void Update_Athelete(int Id)
        {
            foreach (AtheleteManagement ath in Athletes)
            {
                if (Id == ath.athleteId)
                {
                    Console.WriteLine("what you want to update ");
                    Console.WriteLine("Press 1 to update first Name of athelete ");
                    Console.WriteLine("Press 2 to update last Name of athelete ");
                    Console.WriteLine("Press 3 to update age of athelete");
                    Console.WriteLine("Press 4 to update sport");
                    int Choice = Convert.ToInt32(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the new first name");
                            string first_name = Console.ReadLine();
                            ath.firstName = first_name;
                            Console.WriteLine("Successfully update first name");
                            break;
                        case 2:
                            Console.WriteLine("Enter the new last name");
                            string last_name = Console.ReadLine();
                            ath.lastName = last_name;
                            Console.WriteLine("Successfully update last name");
                            break;
                        case 3:
                            Console.WriteLine("Enter the new Age ");
                            int Age = Convert.ToInt32(Console.ReadLine());
                            ath.age = Age;
                            Console.WriteLine($"Successfully update age to {ath.age}");
                            break;
                        case 4:
                            Console.WriteLine("Enter the new sport");
                            string New_sport = Console.ReadLine();
                            ath.sport = New_sport;
                            Console.WriteLine($"Successfully update sport to {ath.sport}");
                            break;


                    }

                }
            }
        }
    }
}
