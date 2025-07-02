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

                e.HasMany(d => d.Donations)
                    .WithOne(w => w.Donor)
                    .HasForeignKey(f => f.IdDonor)
                    .OnDelete(DeleteBehavior.Restrict);           
            });


            builder.Entity<Donation>(e =>
            {
                e.HasKey(k => k.Id);

                e.HasMany(b => b.BloodStocks)
                    .WithOne(d => d.Donation)
                    .HasForeignKey(f => f.IdDonation)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            builder.Entity<Address>(e =>
            {
                e.HasKey(k => k.Id);

                e.HasMany(o => o.Donors)
                    .WithOne(w => w.Address)
                    .HasForeignKey(i => i.IdAddress)
                    .OnDelete(DeleteBehavior.Restrict);
            });

            base.OnModelCreating(builder);
        }
    }
}
