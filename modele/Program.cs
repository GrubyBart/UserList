using modele.Services;
using System;

namespace modele
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            UserService us = new UserService();

            us.Add();
            us.ShowUsers();



        }
    }
}
//dodac,wywal,wyswietl