using BloodBank.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.infrastructure.Persistence
{
    public  class BloodBankDbContext : DbContext
    {
        public BloodBankDbContext(DbContextOptions<BloodBankDbContext> options) : base(options)
        {
            
        }

        public DbSet<Donor> Donors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<BloodStock> BloodStocks { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Donor>(e =>
            {
                e.HasKey(k => k.Id);

                e.HasOne(d => d.Address)
                    .WithOne()
                    .HasForeignKey<Donor>("IdAddress") 
                    .OnDelete(DeleteBehavior.Restrict);

                e.HasMany(d => d.Donations)
                    .WithOne(w => w.Donor)
                    .HasForeignKey(f => f.IdDonor)
                    .OnDelete(DeleteBehavior.Restrict);
            });



            builder.Entity<Donation>(e =>
            {
                e.HasKey(k => k.Id);

                e.HasOne(p => p.BloodStock)
               .WithMany(d => d.Donations)
               .HasForeignKey(i => i.IdBloodStock)
               .OnDelete(DeleteBehavior.Restrict);
            });


            base.OnModelCreating(builder);
        }
    }
}
