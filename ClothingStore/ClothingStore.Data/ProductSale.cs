//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClothingStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductSale
    {
        public System.Guid Id { get; set; }
        public System.Guid ProductStyleId { get; set; }
        public Nullable<int> CurrentPrice { get; set; }
        public Nullable<int> SaleOffPrice { get; set; }
        public Nullable<System.DateTime> FromDate { get; set; }
        public Nullable<System.DateTime> ToDate { get; set; }
        public bool IsActived { get; set; }
    
        public virtual ProductStyle ProductStyle { get; set; }
    }
}