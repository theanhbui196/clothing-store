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
    
    public partial class ProductStyle_Inventory
    {
        public System.Guid ProductStyleId { get; set; }
        public System.Guid InventoryId { get; set; }
        public Nullable<int> QuantityInInventory { get; set; }
    
        public virtual Inventory Inventory { get; set; }
        public virtual ProductStyle ProductStyle { get; set; }
    }
}