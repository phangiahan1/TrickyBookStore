using System.Collections.Generic;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store
{
    public static class Subscriptions
    {
        public static readonly Dictionary<SubscriptionTypes, Dictionary<string, double>> PriceDetailsPlan = new Dictionary<SubscriptionTypes, Dictionary<string, double>>
        {
            {
                SubscriptionTypes.Free, 
                new Dictionary<string, double> 
                {
                    { "SubscriptionCost", 0 },
                    { "LimitBookWithDiscount", 0 },
                    { "DiscoutNewBook", 0 },
                    { "DiscoutOldBook", 0.1 },
                    { "ReadCost", 0.9 }
                }
            },
            {
                SubscriptionTypes.Paid,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 50 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscoutNewBook", 0.05 },
                    { "DiscoutOldBook", 0 },
                    { "ReadCost", 0.05 }
                }
            },
            {
                SubscriptionTypes.CategoryAddicted,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscoutNewBook", 0.15 },
                    { "DiscoutOldBook", 0 },
                    { "ReadCost", 0 }
                }
            },
            {
                SubscriptionTypes.Premium,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 200 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscoutNewBook", 0.15 },
                    { "DiscoutOldBook", 0 },
                    { "ReadCost", 0 }
                }
            }
        };
       public static readonly IEnumerable<Subscription> Data = new List<Subscription>
        {
            new Subscription { Id = 1, SubscriptionType = SubscriptionTypes.Paid, Priority = (int)SubscriptionTypes.Paid,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.Paid]
            },
            new Subscription { Id = 2, SubscriptionType = SubscriptionTypes.Free, Priority = (int)SubscriptionTypes.Free,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.Free]
            },
            new Subscription { Id = 3, SubscriptionType = SubscriptionTypes.Premium, Priority = (int)SubscriptionTypes.Premium,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.Premium]
            },
            new Subscription { Id = 4, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.CategoryAddicted],
                BookCategoryId = 1
            },            
            new Subscription { Id = 5, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.CategoryAddicted],
                BookCategoryId = 2
            },
            new Subscription { Id = 6, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.CategoryAddicted],
                BookCategoryId = 3
            },
            new Subscription { Id = 7, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = PriceDetailsPlan[SubscriptionTypes.CategoryAddicted],
                BookCategoryId = 4
            },
        };
    }
}
