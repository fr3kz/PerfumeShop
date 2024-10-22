namespace PerfumeShop.Models
{
    public class ProductCategory
    {
        public int ProductId { get; set; }
        public Item Product { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}