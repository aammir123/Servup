using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.ServUpViewModels
{
    public class ServUpHomeViewModel
    {
        public string SPID { get; set; }
        public string ServiceProviderName { get; set; }
        public string Category { get; set; }
        public DateTime ActiveSince { get; set; }
        public string[] Territories { get; set; }
        public int NoOfServices { get; set; }
        public SPSummary SpSummaryObject { get; set; }
    }
}
