using System;

namespace Apttus.SMSService
{
    public class BookingTicketArgs : EventArgs
    {
        public TicketBook ticketBook { get; set; }
    }
}