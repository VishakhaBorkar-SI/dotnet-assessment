using System.Xml.Serialization;
namespace SportzClubManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.InteractiveConsole();

        }
        public void InteractiveConsole()
        {
            int choice;
            do
            {
                Console.WriteLine("_______________________OPERATIONS_______________________________________________________");
                Console.WriteLine("Press 1 for Athlete related operations ");
                Console.WriteLine("Press 2 for Event Related Operations");
                Console.WriteLine("Press 3 for Performance Realated operations");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("_______________________Athtle Related operations____________________________");
                        Console.WriteLine("Press 1 to Add Athelete");
                        Console.WriteLine("Press 2 to view Athlete details");
                        Console.WriteLine("Press 3 to Update Athlete Detials ");
                        Console.WriteLine("press 4 to Remove athlete ");
                        int Choice = Convert.ToInt32(Console.ReadLine());
                        AtheleteManagement athelete = new AtheleteManagement();
                        switch (Choice)

                        {
                            case 1:
                                Console.WriteLine("Enter the First Name of the Athlete ");
                                string first_name = Console.ReadLine();
                                Console.WriteLine("Enter the Last Name if the Athlete ");
                                string last_name = Console.ReadLine();
                                Console.WriteLine("Enter the Age of the Athlete ");
                                int age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Sport of the Athlete ");
                                string sport = Console.ReadLine();
                                Console.WriteLine("Enter the RegistrationDate  of the Athlte ");
                                DateTime Date = Convert.ToDateTime(Console.ReadLine());

                                athelete.Create_Athelte(first_name, last_name, age, sport, Date);

                                break;
                            case 2:
                                Console.WriteLine("Enter the Athlete Id for whome you want to see the details");
                                int athleteid = Convert.ToInt32(Console.ReadLine());
                                athelete.display(athleteid);
                                break;

                            case 3:
                                Console.WriteLine("Enter the Athelete Id whose detail want to update ");
                                int Athelete_ID = Convert.ToInt32(Console.ReadLine());
                                athelete.Update_Athelete(Athelete_ID);
                                break;
                            case 4:
                                Console.WriteLine("Enter the Athlete Id whose details need to be removod");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                athelete.RemoveAthelete(Id);
                                break;
                        }
                        break;
                    case 2:
                        Console.WriteLine("_______________________Event Related operations____________________________");
                        Console.WriteLine("Press 1 to Add Event");
                        Console.WriteLine("Press 2 to view Event Details");
                        Console.WriteLine("Press 3 to Update Event Details");
                        Console.WriteLine("press 4 to Remove Event");
                        int ChoiceEvent = Convert.ToInt32(Console.ReadLine());
                        EventManagement eventManagement = new EventManagement();
                        switch (ChoiceEvent)
                        {
                            case 1:
                                Console.WriteLine("Enter the name of the Event ");
                                string Event_name = Console.ReadLine();
                                Console.WriteLine("Enter the Event type ");
                                string Event_type = Console.ReadLine();
                                Console.WriteLine("Enter the Event Date ");
                                DateTime date = Convert.ToDateTime(Console.ReadLine());
                                eventManagement.CreateEvent(Event_name, Event_type, date);
                                break;
                            case 2:
                                Console.WriteLine("Enter the eventId whose details you want to see");
                                int EventId = Convert.ToInt32(Console.ReadLine());
                                eventManagement.ViewEvent(EventId);
                                break;
                            case 3:
                                Console.WriteLine("Enter the EventId whose details want to update");
                                int id = Convert.ToInt32(Console.ReadLine());
                                eventManagement.EventUpdate(id);
                                break;
                            case 4:
                                Console.WriteLine("Enter the event Id whose details want to delete");
                                int Id = Convert.ToInt32(Console.ReadLine());
                                eventManagement.RemoveEvents(Id);
                                break;
                        }
                        break;

                    case 3:
                        PerformanceManagement performanceManagement = new PerformanceManagement();
                        Console.WriteLine("Press 1 to Add Athelete Performance ");
                        Console.WriteLine("Press 2 to view Athelete Performance ");
                        int Choicemaker = Convert.ToInt32(Console.ReadLine());
                        switch (Choicemaker)
                        {
                            case 1:
                                Console.WriteLine("Enter the Athlete Id of the Athlete ");
                                int id = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Event ID of the Event");
                                int Eid = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Score of the Athlete in the event");
                                int score = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the date and time");
                                DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
                                performanceManagement.CreatePerformance(id, Eid, score, dateTime);
                                break;
                            case 2:
                                Console.WriteLine("Enter the Athlete Id of the Athlete ");
                                int Aid = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter the Event ID of the Event");
                                int eid = Convert.ToInt32(Console.ReadLine());
                                performanceManagement.View(Aid, eid);
                                break;
                        }
                        break;
                }

            }
            while (choice != 0);
        }
    }
}