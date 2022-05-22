﻿using System;
using System.Collections.Generic;
using System.Linq;
using TrickyBookStore.Models;
using TrickyBookStore.Services.Subscriptions;

namespace TrickyBookStore.Services.Customers
{
    internal class CustomerService : ICustomerService
    {
        ISubscriptionService SubscriptionService { get; }
        IList<Customer> allCustomers = (IList<Customer>)Store.Customers.Data;

        public CustomerService(ISubscriptionService subscriptionService)
        {
            SubscriptionService = subscriptionService;
        }

        public Customer GetCustomerById(long id)
        {
            Customer customer = new Customer();
            try
            {
                customer = allCustomers.FirstOrDefault(customerItem => customerItem.Id == id);
                if (customer.SubscriptionIds == null)
                {
                    customer.SubscriptionIds.Add((int)SubscriptionTypes.Free);
                }
                return customer;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public IList<Subscription> GetSubscriptions(Customer customer)
        {
            try
            {
                int[] subscriptionIds = customer.SubscriptionIds.ToList().ToArray();
                IList<Subscription> subscriptions = SubscriptionService.GetSubscriptions(subscriptionIds);

                foreach (Subscription subscription in subscriptions)
                {
                    return subscriptions;
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            return SubscriptionService.GetSubscriptions(2);
        }
    }
}
