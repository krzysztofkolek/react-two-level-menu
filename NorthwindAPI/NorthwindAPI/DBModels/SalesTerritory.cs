//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NorthwindAPI.DBModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesTerritory
    {
        public SalesTerritory()
        {
            this.StateProvinces = new HashSet<StateProvince>();
            this.Customers = new HashSet<Customer>();
            this.SalesOrderHeaders = new HashSet<SalesOrderHeader>();
            this.SalesPersons = new HashSet<SalesPerson>();
            this.SalesTerritoryHistories = new HashSet<SalesTerritoryHistory>();
        }
    
        public int TerritoryID { get; set; }
        public string Name { get; set; }
        public string CountryRegionCode { get; set; }
        public string Group { get; set; }
        public decimal SalesYTD { get; set; }
        public decimal SalesLastYear { get; set; }
        public decimal CostYTD { get; set; }
        public decimal CostLastYear { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual CountryRegion CountryRegion { get; set; }
        public virtual ICollection<StateProvince> StateProvinces { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
        public virtual ICollection<SalesPerson> SalesPersons { get; set; }
        public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistories { get; set; }
    }
}
