using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServUp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class NewContractViewModel
    {
        public int ServiceId { get; set; }
        public string TenureYears { get; set; }
        public string TenureMonths { get; set; }
        public int StartDate { get; set; }
        public int EndDate { get; set; }
        public int SPRevenuePercentage { get; set; }
        public int ServUpRevenuePercentage { get; set; }
        public int BillingModelID { get; set; }
        public int TentativePricingID { get; set; }
        public int IndicativePrice { get; set; }
        public int TermsConditionsId { get; set; }

    }
}