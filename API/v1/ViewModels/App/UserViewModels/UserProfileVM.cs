using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.App.UserViewModel
{
    /// <summary>
    /// 
    /// </summary>
    public class UserProfileVM
    {
        public string name { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public string organization { get; set; }
        public string aboutMe { get; set; }
        public string email { get; set; }
        public DateTime dob { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string userFacebookProfile { get; set; }
        public string userLinkedInProfile { get; set; }
        public string userTwitterProfile { get; set; }
        public string userInstagramProfile { get; set; }
        public string userProfilePicURL { get; set; }
        public string userTopBannerURL { get; set; }

    }
}
