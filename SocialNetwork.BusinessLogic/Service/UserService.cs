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
    public class UserService : IUserService
    {

        const string connectionString = "mongodb://localhost:27017";
        const string databaseName = "social_network";
        const string collectionName = "users";

        static DBHelper dbHelper;

        UserService()
        {
            dbHelper.CreateInstance(connectionString, databaseName);
        }

        public void Create(Users user)
        {

            dbHelper.InsertDocument(collectionName,user);

        }

        public void Delete(Guid id)
        {
            dbHelper.DeleteDocument<Users>(collectionName,id);
        }

        public List<Users> GetAllUsers()
        {
            return dbHelper.LoadAllDocuments<Users>(collectionName);
        }

        public Users GetUser(Guid id)
        {
            return dbHelper.LoadDocumentById<Users>(collectionName, id);
        }

        public void Update(Guid id, Users user)
        {
            dbHelper.UpdateDocument(collectionName,id,user);
        }
    }
}
