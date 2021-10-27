using modele.Core;
using modele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modele.Services
{
    class UserService
    {
        UserRepository ur = new UserRepository();
        public void Add()        
        {            
            User user = new User();
            user.Name = Console.ReadLine();
            user.LastName = Console.ReadLine();
            user.Age = int.Parse(Console.ReadLine());
            user.DateOfBirth = DateTime.Parse(Console.ReadLine());
            ur.Add(user);
        }

        public void ShowUsers()
        {            
            var userList = ur.GetUsers();
            foreach(var user in userList)
            {
                Console.WriteLine(user.Name +" "+user.LastName+" "+user.Age+" "+user.DateOfBirth);
            }              
        }
    }
}