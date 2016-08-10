using Infrastructure.Crypto;
using Infrastructure.Integrations.Twillio;
using Models.DomainModels.UserManagment;
using Models.ViewModels.UserManagment;
using System;

namespace Infrastructure.Mapping
{
    public class UserManagementMapping
    {
        ICrypto crypto = new DefaultCrypto();
        public ConsumerUser MapConsumerUser(UserRegisterationModel rum)
        {
            ConsumerUser cu = new ConsumerUser();
            cu.id = Guid.NewGuid().ToString();
            cu.MobilePhoneNumber = rum.mobileNumber;
            cu.HashedPassword = crypto.HashPassword(rum.password, 1);
            cu.email = rum.email;
            cu.isTermsAndConditionsAgreed = rum.isTermsAndConditionsAgreed;
            cu.termsAndConditionsId = GetTermsAndConditionsId();
            return cu;
        }

        public LinkedAccounts MapLinkedUser(UserRegisterationModel urm, ConsumerUser cu)
        {
            TwillioService ts = new TwillioService();

            LinkedAccounts lu = new LinkedAccounts();
            lu.userAccount = urm.mobileNumber;
            lu.accountType = "Device";
            lu.accountOperator = ts.GetOperator(urm.mobileNumber);
            lu.created = DateTime.Now;
            lu.isPrimary = true;
            lu.parentUserId = cu.id;
            return lu;
        }

        public UserPIN MapUserPIN(string mobileNumber)
        {
            return new UserPIN {userAccount=mobileNumber, pin = crypto.GenerateNumericCode(4), created = DateTime.Now};
        }

        public string GetTermsAndConditionsId()
        {
            //do call terms and conditions lookup service here
            return "1";
        }

    }
}
