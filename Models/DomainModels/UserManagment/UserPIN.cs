using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DomainModels.UserManagment
{
    public class UserPIN
    {
        public string userAccount { get; set; }
        public string pin { get; set; }
        public DateTime created { get; set; }
    }
}
