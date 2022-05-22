using System;
using System.Collections.Generic;
using TrickyBookStore.Models;

// KeepIt
namespace TrickyBookStore.Services.Payment
{
    public interface IPaymentService
    {
        //double GetTotalDiscount(IList<Subscription> customerSubscriptions, IList<Book> customerBooks);
        double GetTotalBeforeDiscount(IList<Book> customerBooks);
        double GetPaymentAmount(long customerId, DateTimeOffset fromDate, DateTimeOffset toDate);
    }
}
