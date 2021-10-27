using modele.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modele.Core
{
    public class UserRepository
    {
        List<User> userList = new List<User>();
        public void Add(User user)
        {
            userList.Add(user);
        }
        public List<User> GetUsers()
        {
            return userList;
        }
    }
}
