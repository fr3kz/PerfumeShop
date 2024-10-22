namespace PerfumeShop.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public DateTime Founded { get; set; }
        
        // Relacja z produktami
        public ICollection<Item> Products { get; set; }
    }
}