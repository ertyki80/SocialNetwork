
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Models;

namespace SocialNetwork.BusinessLogic.Interfaces
{
    interface IUserService
    {
        Users GetUser(Guid id);
        List <Users> GetAllUsers();
        void Create(Users user);
        void Update(Guid id, Users user);
        void Delete(Guid id);
    }
}
