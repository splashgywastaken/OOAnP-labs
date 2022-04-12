namespace Lab4;

public static class Solution {
    private static readonly IDictionary<string, string> Countries = new Dictionary<string, string>();

    public static void Main(string[] args)
    {
        Countries.Add("UA", "Ukraine");
        Countries.Add("RU", "Russia");
        Countries.Add("CA", "Canada");

        ICustomer customer = new Customer();
        IContact contact = new Contact();

        IIncomeData incomeData = new IncomeData();

        IIncomeData incomeDataAdapter = new IncomeDataAdapter(customer, contact);
        
        Console.WriteLine(incomeDataAdapter.GetCompany());
        Console.WriteLine(incomeDataAdapter.GetCountryPhoneCode());
        Console.WriteLine(incomeDataAdapter.GetPhoneNumber());
        Console.WriteLine(incomeDataAdapter.GetCountryCode());
    }

    private class IncomeDataAdapter : IIncomeData
    {
        private readonly ICustomer _customer;
        private readonly IContact _contact;
        
        public IncomeDataAdapter(ICustomer customer, IContact contact)
        {
            this._customer = customer;
            this._contact = contact;
        }

        public string GetCountryCode()
        {
            return Countries.FirstOrDefault(
                x => x.Value == _customer.GetCountryName()
                ).Key;
        }

        public string GetCompany()
        {
            return _customer.GetCompanyName();
        }

        public string GetContactFirstName()
        {
            return
                _contact.GetName().Split(" ").Last();
        }
        
        public string GetContactLastName()
        {
            return
                _contact.GetName().Split(", ").First();
        }

        public int GetCountryPhoneCode()
        {
            string phoneNumber = _contact.GetPhoneNumber();

            return
                int.Parse(phoneNumber.Substring(
                    phoneNumber.IndexOf("+", StringComparison.Ordinal) + 1,
                    phoneNumber.IndexOf("(", StringComparison.Ordinal) - (phoneNumber.IndexOf("+", StringComparison.Ordinal) + 1)
                ));
        }

        public int GetPhoneNumber()
        {
            var phoneNumber = _contact.GetPhoneNumber();
            var phonePartInBrackets = phoneNumber.Substring(
                phoneNumber.IndexOf("(", StringComparison.Ordinal) + 1,
                3
            );
            var phoneLastPart = phoneNumber.Substring(
                phoneNumber.IndexOf(")", StringComparison.Ordinal) + 1, 
                phoneNumber.Length - (phoneNumber.IndexOf(")", StringComparison.Ordinal) + 1)
            );

            return int.Parse(phonePartInBrackets + string.Join("", phoneLastPart.Split("-")));
        }
    }

    private interface IIncomeData {
        string GetCountryCode();            //For example: UA
        string GetCompany();                //For example: JavaRush Ltd.
        string GetContactFirstName();       //For example: Ivan
        string GetContactLastName();        //For example: Ivanov
        int    GetCountryPhoneCode();       //For example: 38
        int    GetPhoneNumber();            //For example: 501234567
    }

    private interface ICustomer {
        string GetCompanyName();            //For example: JavaRush Ltd.
        string GetCountryName();            //For example: Ukraine
    }

    private interface IContact {
        string GetName();                   //For example: Ivanov, Ivan
        string GetPhoneNumber();            //For example: +38(050)123-45-67
    }

    private class Customer : ICustomer
    {
        public string GetCompanyName()      //For example: JavaRush Ltd.
        {
            return "JavaRush Ltd";
        }

        public string GetCountryName()      //For example: Ukraine
        {
            return "Ukraine";
        }
    }

    private class Contact : IContact
    {
        public string GetName()             //For example: Ivanov, Ivan
        {
            return "Ivanov, Ivan";
        }

        public string GetPhoneNumber()      //For example: +38(050)123-45-67
        {
            return "+38(050)123-45-67";
        }
    }

    private class IncomeData : IIncomeData
    {
        public string GetCountryCode()      //For example: UA
        {
            return "UA";
        }

        public string GetCompany()          //For example: JavaRush Ltd.
        {
            return "JavaRush Ltd.";
        }

        public string GetContactFirstName() //For example: Ivan
        {
            return "Ivan";
        }

        public string GetContactLastName()  //For example: Ivanov
        {
            return "Ivanov";
        }

        public int GetCountryPhoneCode()    //For example: 38
        {
            return 38;
        }

        public int GetPhoneNumber()         //For example: 501234567
        {
            return 501234567;
        }
    }
    
}