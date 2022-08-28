using HRMS.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }




    protected override void OnModelCreating(ModelBuilder builder)       //to chaneg tables name
        {
            base.OnModelCreating(builder);

            builder.Entity/*<IdentityUser>*/<ApplicationUser>()             //to change table name from
                .ToTable("Users", "security");                             //to
              //.Ignore(e=>e . nameOfColom)                                //to delete specific colom
              //.
            
            builder.Entity<IdentityRole>().ToTable("Roles", "security");

            builder.Entity<IdentityUserRole<string>>().ToTable("UserRoles", "security");

            builder.Entity<IdentityUserClaim<string>>().ToTable("UserClaims", "security");

            builder.Entity<IdentityUserLogin<string>>().ToTable("UserLogins", "security");

            builder.Entity<IdentityRoleClaim<string>>().ToTable("RoleClaims", "security");

            builder.Entity<IdentityUserToken<string>>().ToTable("UserTokens", "security");
        }
    }
}
