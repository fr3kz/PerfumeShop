namespace PerfumeShop.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        // Relacja z produktami
        
        public ICollection<ProductCategory> ProductCategories { get; set; }

    }
    

}