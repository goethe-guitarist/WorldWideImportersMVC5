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
    
    public partial class StockItem_Staging
    {
        public int Stock_Item_Staging_Key { get; set; }
        public int WWI_Stock_Item_ID { get; set; }
        public string Stock_Item { get; set; }
        public string Color { get; set; }
        public string Selling_Package { get; set; }
        public string Buying_Package { get; set; }
        public string Brand { get; set; }
        public string Size { get; set; }
        public int Lead_Time_Days { get; set; }
        public int Quantity_Per_Outer { get; set; }
        public bool Is_Chiller_Stock { get; set; }
        public string Barcode { get; set; }
        public decimal Tax_Rate { get; set; }
        public decimal Unit_Price { get; set; }
        public Nullable<decimal> Recommended_Retail_Price { get; set; }
        public decimal Typical_Weight_Per_Unit { get; set; }
        public byte[] Photo { get; set; }
        public System.DateTime Valid_From { get; set; }
        public System.DateTime Valid_To { get; set; }
    }
}
