//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kayit.DAL.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Market
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string N11ApiUsername { get; set; }
        public string N11ApiPassword { get; set; }
        public string N11MarketName { get; set; }
        public string HbMerchantID { get; set; }
        public string HbMarketName { get; set; }
        public string TyApiUsername { get; set; }
        public string TyApiPassword { get; set; }
        public string TyMarketName { get; set; }
        public string GgApiKey { get; set; }
        public string GgApiSecret { get; set; }
        public string GgRoleName { get; set; }
        public string GgRolePass { get; set; }
        public string GgMarketName { get; set; }
        public string XmlUrl { get; set; }
        public string TyMID { get; set; }
    
        public virtual User User { get; set; }
    }
}
