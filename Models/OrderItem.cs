namespace PerfumeShop.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Order Order { get; set; }
        
        public Item Product { get; set; }

        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice 
        { 
            get 
            { 
                return Quantity * UnitPrice; 
            }
        }
    }
}