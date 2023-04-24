using System;
using Domain.Common;

namespace Domain.Entities
{
    public class ProductColor:BaseTableEntity
    {
        public Guid ProductId { get; set; }
        public Guid ColorId { get; set; }
        public double? Price { get; set; }
        public double? Discount { get; set; }
    }
}
