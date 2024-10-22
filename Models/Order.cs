namespace PerfumeShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderStatus { get; set; }
        public decimal TotalAmount { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        
        public int UserId { get; set; }
        public User User { get; set; }
        
        

        
        public ICollection<Item> OrderItems { get; set; }
    }
}