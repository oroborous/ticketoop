using System;
using System.Collections.Generic;
using TicketOOP.Models;

namespace TicketOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            var userRequest = menu.GetUserInput();

            Ticket ticket = new Ticket() { Id = "6", Name="Joe" };
            ticket.Equals(new Ticket() { Id="3", Name="Bob"});

            TicketManager ticketManager = new TicketManager();
            while (userRequest != 'Q')
            {
                ticketManager.Process(userRequest);
                userRequest = menu.GetUserInput();
            }
        }
    }
}
