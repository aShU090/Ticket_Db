using Apttus.Assignment.MovieTicket.Enum;
using System;

namespace Apttus.Assignment.MovieTicket
{
    public interface IPerson
    {
        String Name { get; set; }
        int Age { get; set; }
        Gender gender { get; set; }
    }
}