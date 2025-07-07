using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;


namespace BloodBank.infrastructure.Persistence
{
   
        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BloodBankDbContext>
        {
            public BloodBankDbContext CreateDbContext(string[] args)
            {
                var optionsBuilder = new DbContextOptionsBuilder<BloodBankDbContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-OVH31FU\\SQLEXPRESS;Database=BloodbankDb;Trusted_Connection=True;TrustServerCertificate=True;");
  

                return new BloodBankDbContext(optionsBuilder.Options);
            }
        }
    
}

