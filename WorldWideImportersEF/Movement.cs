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
    
    public partial class Movement
    {
        public long Movement_Key { get; set; }
        public System.DateTime Date_Key { get; set; }
        public int Stock_Item_Key { get; set; }
        public Nullable<int> Customer_Key { get; set; }
        public Nullable<int> Supplier_Key { get; set; }
        public int Transaction_Type_Key { get; set; }
        public int WWI_Stock_Item_Transaction_ID { get; set; }
        public Nullable<int> WWI_Invoice_ID { get; set; }
        public Nullable<int> WWI_Purchase_Order_ID { get; set; }
        public int Quantity { get; set; }
        public int Lineage_Key { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Date Date { get; set; }
        public virtual Stock_Item Stock_Item { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual Transaction_Type Transaction_Type { get; set; }
    }
}