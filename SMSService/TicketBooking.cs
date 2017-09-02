using System;

namespace Apttus.SMSService
{
    public class TicketBooking
    {
        public delegate void BookingTicketHandler(object source, BookingTicketArgs args);

        public event BookingTicketHandler bookedTicket;

        public void BookingTicket(TicketBook ti)
        {
            Console.WriteLine("Booking ticket......");
            OnbookedTicket(ti);
        }

        protected virtual void OnbookedTicket(TicketBook ti)
        {
            bookedTicket?.Invoke(this, new BookingTicketArgs { ticketBook = ti });
        }
    }
}