using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace kayit.UI.Models
{
    public class InsertInfoVM
    {
        public string Email { get; set; }
        public string UserIPassword { get; set; }


        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string Phone { get; set; }
        public string ManagerName { get; set; }
        public string ManagerEmail { get; set; }
        public string Logo { get; set; }
        public string N11UserName { get; set; }
        public string N11Password { get; set; }
        public string N11MarketName { get; set; }
        public string XmlUrl { get; set; }
        public string HBMerchantId { get; set; }
        public string HBMarketName { get; set; }
        
        public string TYMerchantId { get; set; }
        public string TYUserName { get; set; }
        public string TYPassword { get; set; }

        public string TYMarketName { get; set; }
       
        public string GGApiKey { get; set; }
        public string GGApiSecret { get; set; }
        public string GGRolName { get; set; }

        public string GGPassword { get; set; }
        public string GGMarketName { get; set; }
      
       

    }
}