using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwork.Models;

namespace SocialNetwork.BusinessLogic.Interfaces
{
    public interface IPostsService
    {
        Posts GetPosts(Guid id);
        List<Posts> GetAllPosts();
        void Create(Posts user);
        void Update(Guid id, Posts user);
        void Delete(Guid id);

    }
}
