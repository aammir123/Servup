using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.ViewModels.SPViewModels
{
    public class SPProfileViewModel
    {
        //personel info
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Phone { get; set; }
        public string CompanyEmail { get; set; }

        //company info
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string CompanyNumber { get; set; }
        public string Website { get; set; }
        public string FoundedIn { get; set; }
        public string Locations { get; set; }
        public string IndustryTypeID { get; set; }

        public string LogoURL { get; set; }

        public Dictionary<int, string> LegalDocumentsURL { get; set; }

        //company bank details object
        // services details object
        
    }
}
