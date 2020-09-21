using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SocialNetwok.Context;
using SocialNetwork.BusinessLogic.Interfaces;
using SocialNetwork.Models;

namespace SocialNetwork.BusinessLogic.Service
{
    class PostsService : IPostsService
    {
        const string connectionString = "mongodb://localhost:27017";
        const string databaseName = "social_network";
        const string collectionName = "posts";
        static DBHelper dbHelper;

        PostsService()
        {
            dbHelper.CreateInstance(connectionString, databaseName);
        }
        public void Create(Posts posts)
        {

            dbHelper.InsertDocument(collectionName, posts);
        }

        public void Delete(Guid id)
        {
            dbHelper.DeleteDocument<Posts>(collectionName, id);
        }

        public List<Posts> GetAllPosts()
        {
            return dbHelper.LoadAllDocuments<Posts>(collectionName);
        }

        public Posts GetPosts(Guid id)
        {
            return dbHelper.LoadDocumentById<Posts>(collectionName, id);
        }

        public void Update(Guid id, Posts posts)
        {
            dbHelper.UpdateDocument(collectionName, id, posts);
        }
    }
}
