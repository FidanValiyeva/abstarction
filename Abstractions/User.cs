using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions
{
    internal class User
    {


        public double Id;
        public string FullName;
        public string Email;
        public string Password;

        public User(double id, string fullName, string email, string password)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            Password = password;
        }
        public void PasswordChecker()
        {
            if (Password.Length < 8)

            {
                Console.WriteLine(true);

            }
            else
            {
                Console.WriteLine(false);

            }


            foreach (char c in Password)
            {
                if (char.IsUpper(c))
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }           
            }

            foreach (char c in Password)
            {
                if (char.IsLower(c))
                {
                    Console.WriteLine(true);
                }
                else
                { Console.WriteLine(false); }

            }
            foreach (char c in Password)
            {
                if (char.IsDigit(c))

                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }
            }
             
            
            void ShowInfo()
            
            {
                Console.WriteLine($" Id:{Id},FullName:{FullName},Email:{Email}");
            }





        }
    }
}
