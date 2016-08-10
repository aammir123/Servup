using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DomainModels.UserManagment
{
    public class UserProfile
    {
        //will be in 00923008423238 format
        public string mobileNumber { get; set; }
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
        public bool isTermsAndConditionsAgreed { get; set; }

        //public List<SocialProfile> SocialProfiles;
        public string faceBook { get; set; }
        public string twitter { get; set; }
        public string linkedIn { get; set; }
        public string instagram { get; set; }

        public string coverPictureURL { get; set; }
        public string profilePictureURL { get; set; }

    }
}
