using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyFlatAPI.Data.Models;

namespace MyFlatAPI.Data
{
    public class MyFlatAPIDBContext : IdentityDbContext
    {
        public MyFlatAPIDBContext(DbContextOptions<MyFlatAPIDBContext> options) : base(options) { }

        public DbSet<CategoryServiceModel> CategoryService { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                ConcurrencyStamp = "6d5c54e4-667f-4b61-9ac9-d61039cdf950"
                //Description = "This role can perform all operations"
            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Name = "User",
                NormalizedName = "USER",
                ConcurrencyStamp = "302dc497-bf7b-49fa-af47-cc1123b3fe8e"
                //Description = "This role can add PhoneBookRecord"
            });
        }
    }
}
