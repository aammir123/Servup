using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Models.DomainModels.UserManagment;

namespace Infrastructure.Repository
{
    public class ServupContext
    {
        private IMongoDatabase db;
        public ServupContext()
        {
            MongoClientSettings settings = new MongoClientSettings();
            settings.Server = new MongoServerAddress("localhost", 27017);
            MongoClient client = new MongoClient(settings);
            db = client.GetDatabase("Servup");
        }

        public IMongoCollection<LinkedAccounts> linkedUsers
        {
            get
            {
                return db.GetCollection<LinkedAccounts>("ReferenceLinkedUsers");
            }
        }

        public IMongoCollection<ConsumerUser> users
        {
            get
            {
                return db.GetCollection<ConsumerUser>("ReferenceUsers");
            }
        }

        public IMongoCollection<UserPIN> userPINs
        {
            get
            {
                return db.GetCollection<UserPIN>("ReferenceUserPINs");
            }
        }
    }
}
