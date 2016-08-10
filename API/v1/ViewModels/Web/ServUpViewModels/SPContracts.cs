using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.ServUpViewModels
{
    public class SPContracts
    {
        public string ContractID { get; set; }
        public string ServiceTitle { get; set; }
        public string SPName { get; set; }
        public DateTime CreatedAt { get; set; }
        public int StatusID { get; set; }
        public int NoOfCards { get; set; }
    }
}
