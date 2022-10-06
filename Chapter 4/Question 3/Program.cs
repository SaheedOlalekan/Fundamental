using System;

namespace Question_3
{
    class Program
    {
        static void Main(string[] args)
        {
                // 3. A given company has name, address, phone number, fax number, web 
                // site and manager. The manager has name, surname and phone number.
                // Write a program that reads information about the company and its 
                // manager and then prints it on the console.

                Console.Write("Enter the Company name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the Company adddress: ");
                string address = Console.ReadLine();
                Console.Write("Enter the Company phone number: ");
                string phone = Console.ReadLine();
                Console.Write("Enter the Company fax number: ");
                string fax = Console.ReadLine();
                Console.Write("Enter the Company web site: ");
                string web = Console.ReadLine();
                Console.Write("Enter the Manager's name: ");
                string firstName = Console.ReadLine();  
                Console.Write("Enter the Manager's surname: ");
                string surName = Console.ReadLine();
                Console.Write("Enter the Manager's phone number: ");
                string phoneNumber = Console.ReadLine();
                Console.WriteLine("The Comapany name is {0}, located at {1}." +
                 " You can contact the Company through these medium: " +
                 "Phone Number: {2}, Fax: {3}, Website: {4}. The Company's Manager's first name is {5} {6}." +
                 " Contact Manager through {7}", name, address, phone, fax, web, firstName, surName, phoneNumber);
                
        }
    }
}
