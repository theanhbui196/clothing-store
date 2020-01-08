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
    
    public partial class Product : BaseEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.ProductStyles = new HashSet<ProductStyle>();
        }
    
        public System.Guid Id { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> SellingPrice { get; set; }
        public System.Guid ProductTypeId { get; set; }
        public System.Guid SizeTypeId { get; set; }
        public System.Guid ColorTypeId { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.Guid CreatedByUserId { get; set; }
    
        public virtual ProductType ProductType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductStyle> ProductStyles { get; set; }
    }
}
