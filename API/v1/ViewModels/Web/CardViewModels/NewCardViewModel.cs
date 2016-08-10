using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServUp.Models
{
    public class Card
    {
        
        public int ContractId { get; set; }
        public int CardTitle { get; set; }
        public int ServiceDescription { get; set; }
        public int[] Tags { get; set; }
        public Dictionary<int,string> ImageUrsl { get; set; }
        public int CurrencyID { get; set; }
        public double Price { get; set; }
        public int MediaType { get; set; }
        public int ChargingMethodId { get; set; }
        public int CallToActionLabel { get; set; }
        public int IsPhysicalProduct { get; set; }        
        public int AvailableQuantity { get; set; }
        public int ConsumedQuantity { get; set; }
        public int MaxQuantityPerUser { get; set; }
        public int CardStartDate { get; set; }
        public int CardEndDate { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public int Gender { get; set; }
        public int ReturnPolicyURL { get; set; }
        public int TermOfServiceURL { get; set; }
        public int WarantyURL { get; set; }
        public int CurrencyId { get; set; }
        public int WorkflowStatus { get; set; }
        public int IsPaused { get; set; }

    }
}