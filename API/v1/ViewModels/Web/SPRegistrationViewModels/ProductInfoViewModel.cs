using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServUp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ProductInfo
    {
        ///// <summary>
        ///// 
        ///// </summary>
        //public int ServiceID { get; set; }
        ///// <summary>
        ///// 
        /// </summary>
        public int SPID { get; set; }      //next page requires SP ID
        
        /// <summary>
        /// 
        /// </summary>
        public int ServiceType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceDescription { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string AdditionalComments { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool ISDataInputRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool IsOperatorIntegrationRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public Dictionary<int,string> Territories { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ServiceChargingTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int TargetSegmentTypeId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceFacebookPageURL { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ServiceTwitterURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ServiceInstagramURL { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SupportEmail { get; set; }


    }
}