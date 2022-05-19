﻿using System.Collections.Generic;
using TrickyBookStore.Models;

namespace TrickyBookStore.Services.Store
{
    public static class Subscriptions
    {
        public static readonly IEnumerable<Subscription> Data = new List<Subscription>
        {
            new Subscription { Id = 1, SubscriptionType = SubscriptionTypes.Paid, Priority = (int)SubscriptionTypes.Paid,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 50 }
                }
            },
            new Subscription { Id = 2, SubscriptionType = SubscriptionTypes.Free, Priority = (int)SubscriptionTypes.Free,
                PriceDetails = new Dictionary<string, double>
                {
                }
            },
            new Subscription { Id = 3, SubscriptionType = SubscriptionTypes.Premium, Priority = (int)SubscriptionTypes.Premium,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 200 },
                    //{ "PercentageDiscoutNewBook", 0.15 },

                }
            },
            new Subscription { Id = 4, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 75 },
                    //{ "PercentageDiscoutNewBook", 0.15 },
                },
                BookCategoryId = 1
            },            
            new Subscription { Id = 5, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 75 },
                },
                BookCategoryId = 2
            },
            new Subscription { Id = 6, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 75 },
                },
                BookCategoryId = 3
            },
            new Subscription { Id = 7, SubscriptionType = SubscriptionTypes.CategoryAddicted, Priority = (int)SubscriptionTypes.CategoryAddicted,
                PriceDetails = new Dictionary<string, double>
                {
                    { "FixPrice", 75 },
                },
                BookCategoryId = 4
            },
        };
    }
}
