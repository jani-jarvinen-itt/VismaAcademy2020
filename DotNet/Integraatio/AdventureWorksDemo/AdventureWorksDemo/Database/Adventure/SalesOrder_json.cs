//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdventureWorksDemo.Database.Adventure
{
    using System;
    using System.Collections.Generic;
    
    public partial class SalesOrder_json
    {
        public int SalesOrderID { get; set; }
        public byte RevisionNumber { get; set; }
        public System.DateTime OrderDate { get; set; }
        public System.DateTime DueDate { get; set; }
        public Nullable<System.DateTime> ShipDate { get; set; }
        public byte Status { get; set; }
        public bool OnlineOrderFlag { get; set; }
        public string SalesOrderNumber { get; set; }
        public string PurchaseOrderNumber { get; set; }
        public string AccountNumber { get; set; }
        public int CustomerID { get; set; }
        public Nullable<int> SalesPersonID { get; set; }
        public Nullable<int> TerritoryID { get; set; }
        public Nullable<int> BillToAddressID { get; set; }
        public Nullable<int> ShipToAddressID { get; set; }
        public Nullable<int> ShipMethodID { get; set; }
        public Nullable<int> CreditCardID { get; set; }
        public string CreditCardApprovalCode { get; set; }
        public Nullable<int> CurrencyRateID { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmt { get; set; }
        public decimal Freight { get; set; }
        public decimal TotalDue { get; set; }
        public string Comment { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    }
}
