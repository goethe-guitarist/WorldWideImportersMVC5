//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldWideImportersEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_Staging
    {
        public long Sale_Staging_Key { get; set; }
        public Nullable<int> City_Key { get; set; }
        public Nullable<int> Customer_Key { get; set; }
        public Nullable<int> Bill_To_Customer_Key { get; set; }
        public Nullable<int> Stock_Item_Key { get; set; }
        public Nullable<System.DateTime> Invoice_Date_Key { get; set; }
        public Nullable<System.DateTime> Delivery_Date_Key { get; set; }
        public Nullable<int> Salesperson_Key { get; set; }
        public Nullable<int> WWI_Invoice_ID { get; set; }
        public string Description { get; set; }
        public string Package { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public Nullable<decimal> Tax_Rate { get; set; }
        public Nullable<decimal> Total_Excluding_Tax { get; set; }
        public Nullable<decimal> Tax_Amount { get; set; }
        public Nullable<decimal> Profit { get; set; }
        public Nullable<decimal> Total_Including_Tax { get; set; }
        public Nullable<int> Total_Dry_Items { get; set; }
        public Nullable<int> Total_Chiller_Items { get; set; }
        public Nullable<int> WWI_City_ID { get; set; }
        public Nullable<int> WWI_Customer_ID { get; set; }
        public Nullable<int> WWI_Bill_To_Customer_ID { get; set; }
        public Nullable<int> WWI_Stock_Item_ID { get; set; }
        public Nullable<int> WWI_Salesperson_ID { get; set; }
        public Nullable<System.DateTime> Last_Modified_When { get; set; }
    }
}
