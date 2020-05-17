using System;

namespace FrontlineMaster.Repository.ContextModel
{
    public partial class Products
    {
        public long ProductId { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Color { get; set; }
        public decimal UnitPrice { get; set; }
        public long AvailableQuantity { get; set; }
        public DateTime CratedDate { get; set; }
    }
}
