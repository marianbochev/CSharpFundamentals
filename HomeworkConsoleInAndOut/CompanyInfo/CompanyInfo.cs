using System;
namespace CompanyInfo
{
    class CompanyInfo
    {
        static void Main()
        {
            //input
            string companyName = Console.ReadLine();
            string companyAdress = Console.ReadLine();
            string companyNumber = Console.ReadLine();
            string faxNumber = Console.ReadLine();
            string webAdress = Console.ReadLine();
            string managerFirstName = Console.ReadLine();
            string managerLastName = Console.ReadLine();
            string age = Console.ReadLine();
            string managerPhoneNumber = Console.ReadLine();

            //output
            Console.WriteLine(companyName);
            Console.WriteLine("Address: " + companyAdress);
            Console.WriteLine("Tel. " + companyNumber);
            if (faxNumber == "")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: " + faxNumber);
            }
            Console.WriteLine("Web site: " + webAdress);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3}) ", managerFirstName, managerLastName, age, managerPhoneNumber);

        }
    }
}

