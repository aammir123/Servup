using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServUp.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class SPRegistration
    {
       
        /// <summary>
        /// 
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string LandlineNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string ConfirmPassword { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ContactNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessAddress { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Industry { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string WebSite { get; set; }

        /// <summary>
        /// 
        /// </summary>
        
        public int IsOperatorIntegrationRequired { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string BusinessTwitterHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BusinessFacebookHandle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string BusinessLinkedinHandle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string BusinessInstagramHandle { get; set; }
    
       
    }
}