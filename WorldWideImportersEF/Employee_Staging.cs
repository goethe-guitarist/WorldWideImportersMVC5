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
    
    public partial class Employee_Staging
    {
        public int Employee_Staging_Key { get; set; }
        public int WWI_Employee_ID { get; set; }
        public string Employee { get; set; }
        public string Preferred_Name { get; set; }
        public bool Is_Salesperson { get; set; }
        public byte[] Photo { get; set; }
        public System.DateTime Valid_From { get; set; }
        public System.DateTime Valid_To { get; set; }
    }
}
