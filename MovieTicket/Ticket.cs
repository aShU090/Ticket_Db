using Apttus.MovieTicket.DAL;
using Apttus.SMSService;
using System;
using System.Collections.Generic;

namespace Apttus.Assignment.MovieTicket
{
    public class Ticket
    {
        public int Discount;

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

        private int GetCostOfTicket()
        {
            return 1000;
        }

        private int GetDiscount()
        {
            int TicketCost = GetCostOfTicket();
            Discount = ((TicketCost * 30) / 100);
            return Discount;
        }

        public int GetTotalCost(List<Persons> per)
        {
            int cost;
            int TotalCost = 0;
            int TicketCost = GetCostOfTicket();
            List<int> cos = new List<int>();

            foreach (var temp in per)
            {
                if (temp.Age > 60)
                {
                    var dis = GetDiscount();
                    cost = TicketCost - dis;
                }
                else

                {
                    cost = TicketCost;
                }

                cos.Add(cost);
            }

            for (int j = 0; j < cos.Count; j++)
            {
                TotalCost += cos[j];
            }
            return TotalCost;
        }

        public bool IsJointFamily(IDataAccessor data)
        {
            var list = data.GetMembersDetails();
            if (list.Count > 5)
            {
                return true;
            }
            return false;
        }
    }
}