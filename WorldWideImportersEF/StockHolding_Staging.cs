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
    
    public partial class StockHolding_Staging
    {
        public long Stock_Holding_Staging_Key { get; set; }
        public Nullable<int> Stock_Item_Key { get; set; }
        public Nullable<int> Quantity_On_Hand { get; set; }
        public string Bin_Location { get; set; }
        public Nullable<int> Last_Stocktake_Quantity { get; set; }
        public Nullable<decimal> Last_Cost_Price { get; set; }
        public Nullable<int> Reorder_Level { get; set; }
        public Nullable<int> Target_Stock_Level { get; set; }
        public Nullable<int> WWI_Stock_Item_ID { get; set; }
    }
}
