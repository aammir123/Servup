using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Helper
{
    /// <summary>
    /// 
    /// </summary>
    public static class GlobalMethod
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetIndustryTypeLovs()
        {
            Dictionary<int, string> IndustryTypeLovs = new Dictionary<int, string>();
            IndustryTypeLovs.Add(0, "Telecom");
            IndustryTypeLovs.Add(1, "Retail");
            IndustryTypeLovs.Add(2, "Sports");
            IndustryTypeLovs.Add(3, "eCommerce");
            IndustryTypeLovs.Add(4, "Medical");
            return IndustryTypeLovs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, string> GetServiceTypeLovs()
        {
            Dictionary<int, string> ServiceTypeLovs = new Dictionary<int, string>();
            ServiceTypeLovs.Add(0, "Entertainment");
            ServiceTypeLovs.Add(1, "Gaming");
            ServiceTypeLovs.Add(2, "Books");
            return ServiceTypeLovs;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> TermsANDConditions(int defaultID)
        {
            Dictionary<string, string> TermsANDConditionsObject = new Dictionary<string, string>();
            TermsANDConditionsObject.Add("terms", "terms");
            TermsANDConditionsObject.Add("conditions", "conditions");
            return TermsANDConditionsObject;
        }

        public static Dictionary<string, string> TermsANDConditions1(int defaultID)
        {
            Dictionary<string, string> TermsANDConditionsObject = new Dictionary<string, string>();
            TermsANDConditionsObject.Add("terms", "terms");
            TermsANDConditionsObject.Add("conditions", "conditions");
            return TermsANDConditionsObject;
        }

    }
}
