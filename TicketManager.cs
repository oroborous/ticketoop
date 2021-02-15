using System;
using System.Collections.Generic;
using System.Linq;
using TicketOOP.Models;

namespace TicketOOP
{
    public class TicketManager
    {
        // properties
        private readonly TicketFile _ticketFile;

        // constructors
        public TicketManager()
        {
            _ticketFile = new TicketFile();
        }

        // methods
        public void Process(char selection)
        {
            switch (selection)
            {
                case 'C':
                    CreateTicket();
                    break;
                case 'R':
                    ShowTickets(_ticketFile.Contents);
                    break;
                case 'Q':
                    break;
            }
        }

        private void ShowTickets(List<Ticket> tickets)
        {
            foreach (var ticket in tickets.Take(10)) Console.WriteLine(ticket.ToString());
        }

        private void CreateTicket()
        {
            var ticket = AskForTicketDetails();
            AddTicketToFile(ticket);
        }

        private Ticket AskForTicketDetails()
        {
            Console.Write("Enter Id: ");
            var id = Console.ReadLine();
            Console.Write("Enter Name: ");
            var name = Console.ReadLine();

            return new Ticket {Id = id, Name = name};
        }

        private void AddTicketToFile(Ticket ticket)
        {
            if (!IsTicketInFile(ticket))
                _ticketFile.WriteFile(ticket);
            else
            {
                Console.WriteLine("* Error: Entry already exists");
            }
        }

        private bool IsTicketInFile(Ticket ticket)
        {
            return _ticketFile.Contents.Contains(ticket);
        }

        private void SampleCode()
        {
            string myString = "Ford";

            List<string> stringList = new List<string>();
            stringList.Add("Chevy");
            stringList.Add("Pontiac");

            var isInList = stringList.Contains(myString);
        }
    }
}