using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization;
using SocialNetwork.Models;

namespace SocialNetwok.Context
{
    public class Context
    {
        public List<Users> Users;

        public  Context()
        {

            var connectionString = "mongodb://localhost:27017";
            const string databaseName = "social_network";
            const string collectionName = "users";
            DBHelper database = DBHelper.CreateInstance1(connectionString, databaseName);
            Users = database.LoadAllDocuments<Users>("users");




        }
    }
}
