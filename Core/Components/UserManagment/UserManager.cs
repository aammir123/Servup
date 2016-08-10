using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using Infrastructure.Repository;
using Infrastructure.Mapping;
using Models.ViewModels.UserManagment;
using Models.DomainModels.UserManagment;

namespace Core.Components.UserManagement
{
    public class UserManager
    {
        
        UserManagementMapping umm = new UserManagementMapping();
        ServupContext ctx = new ServupContext();
        public string CreateUser(UserRegisterationModel rum)
        {
            if(rum.isTermsAndConditionsAgreed)
            {                
                // add user existance checks

                ConsumerUser cu = umm.MapConsumerUser(rum);
                LinkedAccounts lu = umm.MapLinkedUser(rum, cu);

                
                ctx.linkedUsers.InsertOne(lu);
                ctx.users.InsertOne(cu);

                return "OK";
            }

            return "KO";
        }

        public string GeneratePIN(string mobileNumber)
        {
            
            if (ctx.userPINs.AsQueryable().Where(b => b.userAccount == mobileNumber).Count()>0)
            {
                ctx.userPINs.DeleteOneAsync<UserPIN>(b => b.userAccount == mobileNumber);
            }
            ctx.userPINs.InsertOne(umm.MapUserPIN(mobileNumber));

            //sms call

            return "OK";
        }

        public bool VerifyPIN(string mobileNumber,string PIN)
        {
            if (ctx.userPINs.AsQueryable().Where(b => b.userAccount == mobileNumber && b.pin == PIN).Count() > 0)
                return true;
            else
                return false;
        }
    }
}
