using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Integrations.Twillio.Models
{
    public class Carrier
    {
        public object error_code { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string mobile_network_code { get; set; }
        public string mobile_country_code { get; set; }
    }
}
