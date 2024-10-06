using Microsoft.EntityFrameworkCore;
using PerfumeShop.Models;

namespace PerfumeShop.Migrations;

public class ApplicationDBcontext: DbContext
{
    
    public DbSet<User> Users { get; set; }
    
    public DbSet<Category> Categories { get; set; }
    
    
    
    public ApplicationDBcontext(DbContextOptions<ApplicationDBcontext> options) : base(options)
    {
        
    }
}