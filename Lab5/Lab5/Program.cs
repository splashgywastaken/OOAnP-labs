using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab4
{

    public static class Solution
    {
        private static readonly IDictionary<string, string> Countries = new Dictionary<string, string>();

        public static void Main(string[] args)
        {
            Countries.Add("UA", "Ukraine");
            Countries.Add("RU", "Russia");
            Countries.Add("CA", "Canada");

            ICustomer customer = new Customer();
            IContact contact = new Contact();

            IIncomeData incomeData = new IncomeData();

            ICustomer customerIncomeDataAdapter = new IncomeDataAdapter(incomeData);
            IContact contactIncomeDataAdapter = new IncomeDataAdapter(incomeData);

            Console.WriteLine(customerIncomeDataAdapter.GetCompanyName());
            Console.WriteLine(Countries[customerIncomeDataAdapter.GetCountryName()]);
            Console.WriteLine(contactIncomeDataAdapter.GetName());
            Console.WriteLine(contactIncomeDataAdapter.GetPhoneNumber());

        }

        private class IncomeDataAdapter : ICustomer, IContact
        {
            private readonly IIncomeData _incomeData;
            
            public IncomeDataAdapter(IIncomeData incomeData)
            {
                _incomeData = incomeData;
            }

            public string GetCompanyName()
            {
                return _incomeData.GetCompany();
            }

            public string GetCountryName()
            {
                return _incomeData.GetCountryCode();
            }

            public string GetName()
            {
                return _incomeData.GetContactLastName() + ", " + _incomeData.GetContactFirstName();
            }

            public string GetPhoneNumber()
            {
                return
                    "+" + _incomeData.GetCountryPhoneCode() + _incomeData.GetPhoneNumber();
            }
        }

        private interface IIncomeData
        {
            string GetCountryCode(); //For example: UA
            string GetCompany(); //For example: JavaRush Ltd.
            string GetContactFirstName(); //For example: Ivan
            string GetContactLastName(); //For example: Ivanov
            int GetCountryPhoneCode(); //For example: 38
            int GetPhoneNumber(); //For example: 501234567
        }

        private interface ICustomer
        {
            string GetCompanyName(); //For example: JavaRush Ltd.
            string GetCountryName(); //For example: Ukraine
        }

        private interface IContact
        {
            string GetName(); //For example: Ivanov, Ivan
            string GetPhoneNumber(); //For example: +38(050)123-45-67
        }

        private class Customer : ICustomer
        {
            public string GetCompanyName() //For example: JavaRush Ltd.
            {
                return "JavaRush Ltd";
            }

            public string GetCountryName() //For example: Ukraine
            {
                return "Ukraine";
            }
        }

        private class Contact : IContact
        {
            public string GetName() //For example: Ivanov, Ivan
            {
                return "Ivanov, Ivan";
            }

            public string GetPhoneNumber() //For example: +38(050)123-45-67
            {
                return "+38(050)123-45-67";
            }
        }

        private class IncomeData : IIncomeData
        {
            public string GetCountryCode() //For example: UA
            {
                return "UA";
            }

            public string GetCompany() //For example: JavaRush Ltd.
            {
                return "JavaRush Ltd.";
            }

            public string GetContactFirstName() //For example: Ivan
            {
                return "Ivan";
            }

            public string GetContactLastName() //For example: Ivanov
            {
                return "Ivanov";
            }

            public int GetCountryPhoneCode() //For example: 38
            {
                return 38;
            }

            public int GetPhoneNumber() //For example: 501234567
            {
                return 501234567;
            }
        }

    }
}