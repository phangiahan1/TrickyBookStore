using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrickyBookStore.Services.GetDate
{
    internal class GetDateService : IGetDateService
    {
        public DateTimeOffset getEndDate(int year, int month)
        {
            DateTimeOffset startDate = new DateTime(year, month, 1);
            DateTimeOffset endDate = startDate.AddMonths(1).AddDays(-1);
            Console.WriteLine("- Start date: "+ endDate.ToString());
            return endDate;
        }

        public DateTimeOffset getStartDate(int year, int month)
        {
            DateTimeOffset startDate = new DateTime(year,month,1);
            Console.WriteLine("- End date: " + startDate.ToString());
            return startDate;
        }
    }
}
