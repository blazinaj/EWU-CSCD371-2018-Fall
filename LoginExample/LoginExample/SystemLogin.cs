using System;

namespace LoginExample
{
    public class Application
    {

        private static Person[] credentials =
        {
            new Person("Inigo.Montoya", "password"),
            new Person("Princess.Buttercup", "AnyBodyWantAPeanut")
        };
        

        public static bool Login(string username, string password)
        {
            if (password == "password")
                return true;
            else
                return false;
        }
    }
}