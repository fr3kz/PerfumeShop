namespace PerfumeShop.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        
        
        public ICollection<ProductCategory> ProductCategories { get; set; }

        
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string Thumbnail { get; set; }
        public ICollection<string> Images { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsAvailable { get; set; }
        
        
        public ICollection<Category> CategoryList { get; set; }
    }
}