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
    
    public partial class ProductCode_Out
    {
        public System.Guid Id { get; set; }
        public System.Guid ProductCode { get; set; }
        public Nullable<byte> ExportType { get; set; }
        public System.Guid CustomerOrder_ProductStyle_Id { get; set; }
        public System.Guid Inventory_ProductOut_Id { get; set; }
    
        public virtual CustomerOrder_ProductStyle CustomerOrder_ProductStyle { get; set; }
        public virtual Inventory_ProductOut Inventory_ProductOut { get; set; }
        public virtual ProductCode ProductCode1 { get; set; }
    }
}
