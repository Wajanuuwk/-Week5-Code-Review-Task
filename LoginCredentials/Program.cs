using System;

namespace LoginCredentials
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Login Form
             * login: user
             * password: user1234
             * Create a program that asks user's login credentials
             * Check if the user entered correct login and password
             * If the login and password are correct display 'Welcome'
             * If the login or password are incorrect dispay 'try again'
             
             */
            Console.WriteLine("Login:");
            string userName = Console.ReadLine();
            Console.WriteLine("Password:");
            string password = Console.ReadLine();

            if(userName != "user" || password != "user1234")
            {
                Console.WriteLine("Try again");
            }
            else
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
