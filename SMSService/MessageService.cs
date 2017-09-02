using System;

namespace Apttus.SMSService
{
    public class MessageService
    {
        public void OnbookedTicket(object source, BookingTicketArgs e)
        {
            Console.WriteLine("messaging:Congratulation ,Your ticket has been confirmed");
            Console.WriteLine("Members going to movie..............");
            var PersonList = e.ticketBook.list;
            foreach (var list in PersonList)
            {
                Console.WriteLine("Name:" + list.Name + "    Age: " + list.Age + "    Gender:" + list.gender);
            }
            Console.WriteLine("........................");
            Console.WriteLine("Your Total Price is:    " + e.ticketBook.Price);
        }
    }
}