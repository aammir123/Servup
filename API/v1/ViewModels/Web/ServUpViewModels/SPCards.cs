using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.ServUpViewModels
{
    public class SPCards
    {
        public string CardID { get; set; }
        public string CardName { get; set; }
        public string ContractID { get; set; }
        public string Revenue { get; set; }
        public string Engagement { get; set; }
        public string SPName { get; set; }
        public int StatusID { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
