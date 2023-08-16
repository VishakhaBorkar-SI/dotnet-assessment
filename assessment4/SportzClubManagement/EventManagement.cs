using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportzClubManagement
{
    internal class EventManagement
    {
        int EventId;
        string EventName;
        string EventType;
        DateTime EventDate;
        static List<EventManagement> Events = new List<EventManagement>();
        Program program = new Program();
        public EventManagement() { }
        public EventManagement(int eventId, string eventName, string eventType, DateTime eventDate)
        {
            this.EventId = eventId;
            this.EventName = eventName;
            this.EventType = eventType;
            this.EventDate = eventDate;
        }
        public void CreateEvent(string eventName, string eventType, DateTime eventDate)
        {
            if (Events.Count == 0) { EventId = 1; }
            else { EventId = Events.Last().EventId + 1; }
            EventManagement eventManagement = new EventManagement(EventId, eventName, eventType, eventDate);
            Events.Add(eventManagement);
            Console.WriteLine($"The Event with {EventName} have EventId : {EventId}");
        }
        public void ViewEvent(int Id)
        {
            foreach (EventManagement eventManagement in Events)
            {
                if (eventManagement.EventId == Id)
                {
                    Console.WriteLine("The Detail of the Event is : ");
                    Console.WriteLine($"Event Id : {eventManagement.EventId} \t Event Name : {eventManagement.EventName} \n Event type : {eventManagement.EventType} \t Event Date : {eventManagement.EventDate}");
                    return;
                }
            }
            Console.WriteLine("Event Doesn't exist .........");
            Console.WriteLine("Do you want to add the Event ");
            Console.WriteLine("Press Y for yes and N for no");
            char choice = Convert.ToChar(Console.Read());
            if (choice == 'Y' || choice == 'y')
            {
                program.InteractiveConsole();
            }
            else { return; }
        }
        public void RemoveEvents(int eventId)
        {
            foreach (EventManagement eventManagement in Events)
            {
                if (eventManagement.EventId == eventId)
                {
                    Events.Remove(eventManagement);
                    return;
                }

            }
            Console.WriteLine("Event Doesn't exist .........");
            Console.WriteLine("Do you want to add the Event ");
            Console.WriteLine("Press Y for yes and N for no");
            char choice = Convert.ToChar(Console.Read());
            if (choice == 'Y' || choice == 'y')
            {
                program.InteractiveConsole();
            }
            else { return; }

        }
        public void EventUpdate(int eventid)
        {
            foreach (EventManagement eventmanagment in Events)
            {
                if (eventid == eventmanagment.EventId)
                {
                    Console.WriteLine("what you want to update ");
                    Console.WriteLine("Press 1 to update Event name ");
                    Console.WriteLine("Press 2 to update Event type ");
                    Console.WriteLine("Press 3 to update Event date");

                    int Choice = Convert.ToInt32(Console.ReadLine());
                    switch (Choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the new Event name");
                            string Event_Name = Console.ReadLine();
                            eventmanagment.EventName = Event_Name;
                            Console.WriteLine("Successfully updated Event Name");
                            break;
                        case 2:
                            Console.WriteLine("Enter the new Event type");
                            string Event_type = Console.ReadLine();
                            eventmanagment.EventType = Event_type;
                            Console.WriteLine("Successfully updated Event type");
                            break;
                        case 3:
                            Console.WriteLine("Enter the new Event date");
                            DateTime date = Convert.ToDateTime(Console.ReadLine());
                            eventmanagment.EventDate = date;
                            Console.WriteLine($"Successfully update age to {eventmanagment.EventDate}");
                            break;



                    }

                }
            }
        }
    }
}
