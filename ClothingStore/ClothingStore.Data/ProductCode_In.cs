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
    
    public partial class ProductCode_In
    {
        public System.Guid ProductCode { get; set; }
        public System.Guid Inventory_ProductIn_Id { get; set; }
        public Nullable<byte> ImportType { get; set; }
        public Nullable<System.Guid> CustomerOrder_ProductStyle_Id { get; set; }
    
        public virtual Inventory_ProductIn Inventory_ProductIn { get; set; }
        public virtual ProductCode ProductCode1 { get; set; }
    }
}
