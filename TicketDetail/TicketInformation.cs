using Apttus.Assignment.MovieTicket;
using Apttus.MovieTicket.DAL;
using System;
using System.Collections.Generic;

namespace Apttus.MovieTicket.TicketDetail
{
    public class TicketInformation
    {
        private static void Main(string[] args)
        {
            Ticket ticket = new Ticket();
            List<Persons> value = new List<Persons>();
            IDataAccessor data = new DataAccessor();

            int ticketprice;
            string y = "y";

            // list of member in family
            Dictionary<string, Persons> person = new Dictionary<string, Persons>();
            Console.WriteLine("Member in the family ");
            Console.WriteLine("");
            Console.WriteLine("{0}\t {1}\t {2}", "Name", "Age", "Gender");
            Console.WriteLine("------------------------------------------------------");
            var PersonsInfo = data.GetMembersDetails();
            foreach (var temp in PersonsInfo)
            {
                Console.WriteLine("{0}\t {1}\t {2}", temp.Name, temp.Age, temp.gender);
            }

            for (int j = 0; j < PersonsInfo.Count; j++)
            {
                person.Add(PersonsInfo[j].Name, PersonsInfo[j]);
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("How many ticket you want:");
            var member = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            for (int i = 0; i < member; i++)
            {
                Console.WriteLine("Enter the member name");
                var fetch = Console.ReadLine();
                value.Add(person[fetch]);
            }

            // check for discount
            Console.WriteLine("do you want discount y or n");
            if (Console.ReadLine() == y)
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            else
            {
                ticketprice = ticket.GetTotalCost(value);
            }
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Total cost of ticket is: " + ticketprice);
            Console.ReadLine();
        }
    }
}