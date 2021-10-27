using modele.Services;
using System;

namespace modele
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Co chcesz zrobic? ");
                Console.WriteLine("1.Dodaj uzytkownika ");
                Console.WriteLine("2.Wyswietl");
                int sw;
                sw = int.Parse(Console.ReadLine());

                UserService us = new UserService();
                switch (sw)
                {
                    case 1:
                        us.Add();
                        break;
                    case 2:
                        us.ShowUsers();
                        break;
                }

            }

        }
    }
}
//dodac,wywal,wyswietl