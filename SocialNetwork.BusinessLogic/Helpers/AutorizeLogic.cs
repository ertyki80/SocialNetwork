using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwok.Context;
using SocialNetwork.BusinessLogic.Service;
using SocialNetwork.Models;

namespace SocialNetwork.BusinessLogic.Helpers
{
    public class AutorizeLogic
    {
        public bool UserRecognition = false;

        private Users _currentUser;

        public bool Login(string email, string password)
        {
            

               var context = new Context();
               var user = context.Users.Find(c => c.Email == email && c.Password == password);
                UserRecognition = user != null;
                user.IsActive = true;
                _currentUser = user;
                return UserRecognition;
            
        }

        public Users GetUser()
        {
            return _currentUser;

        }

        public void Registration(string first  , string last, string password, string email, string phone,
             string Registered, string about = "")
        {
            var context = new Context();
            var userService = new UserService();
            var newUser = new Users()
            {
                Name = new Name(){First = first,Last = last},
                About = "",
                Email = email,
                Friends = new Friend[]{},
                IsActive = false,
                Password = password,
                Phone = phone,
                Registered = "",


            };

            userService.Create(newUser);



        }
    }
}
