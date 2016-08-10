using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Integrations.Twillio.Models
{
    public class OperatorLookupResponse
    {
        public string url { get; set; }
        public Carrier carrier { get; set; }
        public string national_format { get; set; }
        public string phone_number { get; set; }
        public string country_code { get; set; }
    }
}
