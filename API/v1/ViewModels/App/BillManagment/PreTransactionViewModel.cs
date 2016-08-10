using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.App.PamentManagmentViewModels
{
    public  class PreTransactionViewModel
    {
        public string Item { get; set; }
        public string Source { get; set; }
        public string Amount { get; set; }
        public string PayingTo { get; set; }
    }
}
