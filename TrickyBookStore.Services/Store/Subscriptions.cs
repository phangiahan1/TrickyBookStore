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
                    { "DiscountNewBook", 0 },
                    { "DiscountOldBook", 0.1 }
                }
            },
            {
                SubscriptionTypes.Paid,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 50 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.05 },
                    { "DiscountOldBook", 0.95 }
                }
            },
            {
                SubscriptionTypes.CategoryAddicted,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                }
            },
            {
                SubscriptionTypes.Premium,
                new Dictionary<string, double>
                {
                    { "SubscriptionCost", 200 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                }
            }
        };
       public static readonly IEnumerable<Subscription> Data = new List<Subscription>
        {
            new Subscription { Id = 1, SubscriptionType = SubscriptionTypes.Paid, Priority = 2,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 50 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.05 },
                    { "DiscountOldBook", 0.95 }
                }
            },
            new Subscription { Id = 2, SubscriptionType = SubscriptionTypes.Free, Priority = 1,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 0 },
                    { "LimitBookWithDiscount", 0 },
                    { "DiscountNewBook", 0 },
                    { "DiscountOldBook", 0.1 }
                }
            },
            new Subscription { Id = 3, SubscriptionType = SubscriptionTypes.Premium, Priority = 4,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 200 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                }
            },
            new Subscription { Id = 4, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                },
                BookCategoryId = 1
            },            
            new Subscription { Id = 5, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                },
                BookCategoryId = 2
            },
            new Subscription { Id = 6, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                },
                BookCategoryId = 3
            },
            new Subscription { Id = 7, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = 3,
                PriceDetails = new Dictionary<string, double>
                {
                    { "SubscriptionCost", 75 },
                    { "LimitBookWithDiscount", 3 },
                    { "DiscountNewBook", 0.15 },
                    { "DiscountOldBook", 1 }
                },
                BookCategoryId = 4
            },
        };
    }
}
