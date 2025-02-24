using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace NZWalks.API.Data
{
    public class NZWalksAuthDbContext: IdentityDbContext
    {
        public NZWalksAuthDbContext(DbContextOptions<NZWalksAuthDbContext> options): base(options)
        {
             
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //Seeding roles
            var readerRoleId = "ca9f0436-e41b-4c88-8ba5-fff88d292aeb";
            var writerRoleId = "fa11e9b6-eff1-4390-8d3c-4812e6fcf12e";

            var roles = new List<IdentityRole>
            {
                new IdentityRole
                {

                    Id = readerRoleId,
                    ConcurrencyStamp = readerRoleId,
                    Name = "Reader",
                    NormalizedName = "Reader".ToUpper()
                },

                new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }

            };

            builder.Entity<IdentityRole>().HasData(roles);
        }
    }

    

}
