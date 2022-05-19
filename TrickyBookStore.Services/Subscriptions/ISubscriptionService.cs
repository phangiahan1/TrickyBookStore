using System.Collections.Generic;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Subscriptions
{
    public interface ISubscriptionService
    {
        Subscription GetSubscription(int id);
        IList<Subscription> GetSubscriptions(params int[] ids);
    }
}
