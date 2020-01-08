
using System;

namespace ClothingStore
{
    public class InsertProductCommand : ICommand
    {
        public string ProductName { get; set; }
        public int SellingPrice { get; set; }
        public Guid ProductTypeId { get; set; }
        public Guid SizeTypeId { get; set; }
        public Guid ColorTypeId { get; set; }
    }
}