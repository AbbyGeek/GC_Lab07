using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace GC_Lab07
{
    class Program
    {
        static void Main(string[] args)
        {
            /// declare string (username?) that calls method to verify. Parameters are Regex shit and the message "What is your FIRST name
            /// write out Hi name!

            Console.WriteLine(NameVer());

            Console.WriteLine(EmailVer());

            Console.WriteLine(PhoneVer());
            
            Console.WriteLine(BdayVer());

            Console.ReadLine();
            /// (readline code is just so program doesn't quit automatically upon completion)
           
        }

        public static string NameVer() /// does it need to be the same name variable as above?
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string name = Console.ReadLine();
                String NameParameters = @"^[A-Z][a-zA-Z]{0,29}$";

                if (Regex.IsMatch(name, NameParameters))
                {
                    return "Hello, " + name;
                }
                else
                {
                    Console.WriteLine("You are wrong. Try again");
                }
            }
        }
        public static string EmailVer()
        {
            while (true)
            {
                Console.Write("Enter your email: ");
                string email = Console.ReadLine();
                String EmailParameters = @"^[A-zA-Z0-9]{5,30}@[a-zA-Z0-9]{5,10}\.[a-zA-Z0-9]{2,3}$";

                if (Regex.IsMatch(email, EmailParameters))
                {
                    return "Spammin' time!";
                }
                else
                {
                    Console.WriteLine("You are wrong. Try again");
                }
            }
        }

        public static string PhoneVer()
        {
            while (true)
            {
                Console.Write("Enter your phone number: ");
                string phone = Console.ReadLine();
                String PhoneParameters = @"^\d{3}-\d{3}-\d{4}$";

                if (Regex.IsMatch(phone, PhoneParameters))
                {
                    return "Spammin' time!";
                }
                else
                {
                    Console.WriteLine("You are wrong. Try again");
                }
            }
        }

        public static string BdayVer()
        {
            while (true)
            {
                Console.Write("Enter your Birthday (dd/mm/yyyy): ");
                string bday = Console.ReadLine();
                String BdayParameters = @"^\d{2}/\d{2}/\d{4}$";

                if (Regex.IsMatch(bday, BdayParameters))
                {
                    return "So old.... gross";
                }
                else
                {
                    Console.WriteLine("You are wrong. Try again");
                }
            }
        }


        /// public static string verifymethod with parameters regex and message string.
        /// 
        /// Console write what the message is (name, email, phone, etc (the second parameter in the method)
        /// set string info to whatever is entered
        /// 
        ///while loop  for when regex is NOT matching 
        ///(use IsMatch to check. Regex.IsMatch() is kindof like int.TryParse() )
        /// While it doesn't match, punish the user. repeat the message
        /// reset user infor to a new ReadLine()
        /// 
        ///
    }
}
            