using System;
using System.Linq;
using DBEntityFramework.Classes;

namespace DBEntityFramework
{
    public static class ShekelTestService
    {
        public static CustomersGroups[] GetGroupsWithCustomers()
        {
            using (var context = new ShekelTestEntities())
            {
                var customersGroups = context.FactoriesToCustomer.Select(fc =>
                    new CustomersGroups
                    {
                        Customer = context.Customers.FirstOrDefault(c => c.customerId.Equals(fc.customerId)),
                        Group = context.Groups.FirstOrDefault(g => g.groupCode.Equals(fc.groupCode))
                    }).ToArray();

                return customersGroups;
            }
        }

        public static void AddCustomerToDb(
            string customerId, string name, string address, string phone,
            int factoryCode, int groupCode)
        {
            using (var context = new ShekelTestEntities())
            {
                var customer = new Customers()
                {
                    customerId = customerId,
                    name = name,
                    address = address,
                    phone = phone
                };
                var factoriesToCustomer = new FactoriesToCustomer()
                {
                    customerId = customerId,
                    factoryCode = factoryCode,
                    groupCode = groupCode
                };
                context.Customers.Add(customer);
                context.FactoriesToCustomer.Add(factoriesToCustomer);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static void AddGroupToDb(int groupCode, string groupName)
        {
            using (var context = new ShekelTestEntities())
            {
                var group = new Groups()
                {
                    groupCode = groupCode,
                    groupName = groupName
                };
                context.Groups.Add(group);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static void AddFactoryToDb(int groupCode, int factoryCode, string factoryName)
        {
            using (var context = new ShekelTestEntities())
            {
                var factory = new Factories()
                {
                    groupCode = groupCode,
                    factoryCode = factoryCode,
                    factoryName = factoryName
                };
                context.Factories.Add(factory);
                try
                {
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }
            }
        }

        public static Factories[] GetFactories()
        {
            using (var context = new ShekelTestEntities())
            {
                return context.Factories.ToArray();
            }
        }

        public static Customers[] GetCustomers()
        {
            using (var context = new ShekelTestEntities())
            {
                return context.Customers.ToArray();
            }
        }

        public static Groups[] GetGroups()
        {
            using (var context = new ShekelTestEntities())
            {
                return context.Groups.ToArray();
            }
        }
    }
}
