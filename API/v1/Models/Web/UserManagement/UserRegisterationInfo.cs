using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Models.UserManagement
{
    public class UserRegisterationInfo
    {
        public string msisdn { get; set; }
        public string country { get; set; }
        public DeviceInfo deviceInfo { get; set; }
    }
}
