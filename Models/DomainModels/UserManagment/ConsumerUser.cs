using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Models.DomainModels.UserManagment
{
    public class ConsumerUser
    {
        //that is guid
        [BsonId]
        public string id { get; set; }
        public string name { get; set; }
        //Mr./Mis.
        public string title { get; set; }
        public string location { get; set; }
        public string company { get; set; }
        public string tagLine { get; set; }
        public string aboutMe { get; set; }
        //Rating can be GOLD/Platinum etc.
        public string rating { get; set; }
        public string birthDay { get; set; }
        public string personalURL { get; set; }        

        //public List<SocialProfile> SocialProfiles;
        public string faceBook { get; set; }
        public string twitter { get; set; }
        public string linkedIn { get; set; }
        public string instagram { get; set; }

        public string coverPictureURL { get; set; }
        public string profilePictureURL { get; set; }
        public bool isTermsAndConditionsAgreed { get; set; }
        public string termsAndConditionsId { get; set; }

        //business fields

        //public string jobTitle { get; set; }
        //public string reportsTo { get; set; }
        //public string role { get; set; }


        //ProfileType can be set as Personal/Business etc.
        //public string profileType { get; set; }

        //lineType can be set as Postpaid/Prepaid
        //public string lineType { get; set; }

        // on switching userAccount mobile number of consumer user will be 
        //updated here and communication will be done on this mobile number
        public string MobilePhoneNumber { get; set; }
        public DateTime? MobilePhoneNumberChanged { get; set; }
        public string MobileCode { get; set; }
        public DateTime? MobileCodeSent { get; set; }


        public string email { get; set; }
        public bool isAccountVerified { get; set; }
        public string VerificationKey { get; set; }
        public DateTime? VerificationKeySent { get; set; }
        public string HashedPassword { get; set; }


        public DateTime created { get; set; }
        public DateTime LastUpdated { get; set; }
        public bool IsAccountClosed { get; set; }
        public DateTime? AccountClosed { get; set; }
        

        public bool IsLoginAllowed { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? LastFailedLogin { get; set; }
        public int FailedLoginCount { get; set; }               
    }
}
