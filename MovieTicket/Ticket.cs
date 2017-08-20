using System.Collections.Generic;

namespace Apttus.Assignment.MovieTicket
{
    public class Ticket
    {
        public int Discount;

        public int GetCostOfTicket()
        {
            return 1000;
        }

        public int GetDiscount()
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
    }
}