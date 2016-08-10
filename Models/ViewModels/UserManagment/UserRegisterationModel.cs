using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.ViewModels.UserManagment
{
    public class UserRegisterationModel
    {
        public string mobileNumber { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool isTermsAndConditionsAgreed { get; set; }
    }
}
