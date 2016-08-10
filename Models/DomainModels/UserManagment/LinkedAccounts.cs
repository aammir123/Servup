using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.DomainModels.UserManagment
{
    public class LinkedAccounts
    {
        //this field will be mobile number in case of consumer 
        //and email in case of SP both can add multiple accounts
        [BsonId]
        public string userAccount { get; set; }
        
        // Can be a Voice/Device/Machine in case of consumer and 
        //in case of SP it will be Device default
        public string accountType { get; set; }

        //operator will be tagged in case of consumer user, could be Mobilink,Telenor etc
        public string accountOperator { get; set; }
        
        //Prepaid/Postpaid will be populated in case of consumer user
        public string connectionType { get; set; }

        public DateTime created { get; set; }
        public bool isPrimary { get; set; }
        public string parentUserId { get; set; }
    }
}
