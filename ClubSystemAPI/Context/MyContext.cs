using ClubSystemAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClubSystemAPI.Context
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }
        DbSet<MemberModel> Members { get; set; }
        DbSet<MembershipModel> Memberships { get; set; }
        DbSet<FacilityModel> Facilities { get; set; }
        DbSet<PaymentModel> Payments { get; set; }
        DbSet<BookingModel> Bookings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MemberModel>().HasKey(o => o.Id);
            modelBuilder.Entity<FacilityModel>().HasKey(o => o.Id);
            modelBuilder.Entity<PaymentModel>().HasKey(o => o.Id);
            modelBuilder.Entity<BookingModel>().HasKey(o => o.Id);
            modelBuilder.Entity<MemberModel>().Property(m => m.FullName).HasMaxLength(100);
            modelBuilder.Entity<MemberModel>().HasIndex(m => m.Email).IsUnique();

            modelBuilder.Entity<MemberModel>().HasMany(m => m.Bookings).WithOne(b => b.Member).HasForeignKey(b => b.MemberId);
            modelBuilder.Entity<MembershipModel>().HasKey(ms => ms.Id);
            modelBuilder.Entity<MembershipModel>().HasOne(o => o.Member).WithOne(m => m.Membership).HasForeignKey<MembershipModel>(o => o.MemberId);
            modelBuilder.Entity<MemberModel>().HasData(new MemberModel
            {
                Id = 1,
                FullName = "Ahmed Mohamed",
                Email = "ahmed@example.com",
                Phone = "01011112222",
                BirthDate = DateTime.Parse("2000-05-15")


            }, new MemberModel
            {
                Id = 2,
                FullName = "Mona Ali",
                Email = "mona@example.com",
                Phone = "01022223333",
                BirthDate = DateTime.Parse("1998-09-20")


            }, new MemberModel
            {
                Id = 3,
                FullName = "Omar Hassan",
                Email = "omar@example.com",
                Phone = "01033334444",
                BirthDate = DateTime.Parse("2002-01-10"),
                


            });modelBuilder.Entity<MembershipModel>().HasData(new MembershipModel
            {
                Id = 1,
                Type= "Gold",
                StartDate=DateTime.Parse("2026-01-01"),
                EndDate=DateTime.Parse("2027-01-01"),
                Price=5000,
                Status="Active",
                MemberId = 1

            }, new MembershipModel
            {
                Id = 2,
                Type = "Silver",
                StartDate = DateTime.Parse("2026-03-01"),
                EndDate = DateTime.Parse("2027-03-01"),
                Price = 3000,
                Status = "Active",
                MemberId = 2

            }, new MembershipModel
            {
                Id = 3,
                Type = "Basic",
                StartDate = DateTime.Parse("2025-01-01"),
                EndDate = DateTime.Parse("2026-01-01"),
                Price = 1500,
                Status = "Expired",
                MemberId = 3

            });
            modelBuilder.Entity<FacilityModel>().HasData(new FacilityModel
            {

                Id = 1,
                Name = "Swimming Pool",
                Capacity = 30,
                HourlyPrice = 250


            }, new FacilityModel
            {

                Id = 2,
                Name = "Gym Hall",
                Capacity = 40,
                HourlyPrice = 150


            }, new FacilityModel
            {

                Id = 3,
                Name = "Tennis Court",
                Capacity = 10,
                HourlyPrice = 200,
                


            });
            modelBuilder.Entity<BookingModel>().HasData(new BookingModel
            {
                Id = 1,
                BookingDate = DateTime.Parse("2026-10-10"),
                StartTime = TimeSpan.FromHours(10),
                EndTime = TimeSpan.FromHours(12),
                GroupSize = 10,
                Status = "Confirmed",
                FacilityId = 1,
                MemberId = 1
            }, new BookingModel
            {
                Id = 2,
                BookingDate = DateTime.Parse("2026-10-11"),
                StartTime = TimeSpan.FromHours(14),
                EndTime = TimeSpan.FromHours(15),
                GroupSize = 8,
                Status = "Confirmed",
                FacilityId = 2,
                MemberId = 2
            }, new BookingModel
            {
                Id = 3,
                BookingDate = DateTime.Parse("2026-10-12"),
                StartTime = TimeSpan.FromHours(16),
                EndTime = TimeSpan.FromHours(17),
                GroupSize = 4,
                Status = "Confirmed",
                FacilityId = 3,
                MemberId=3
            });
            modelBuilder.Entity<PaymentModel>().HasData(new PaymentModel{ Id=1,Amount=5000,PaymentDate=DateTime.Parse("2026-01-01"),PaymentMethod="Cash",MembershipId=1 },new PaymentModel { Id = 2, Amount = 3000, PaymentDate = DateTime.Parse("2026-03-01"), PaymentMethod = "Cash",MembershipId=2 },new PaymentModel { Id = 3, Amount = 1500, PaymentDate = DateTime.Parse("2025-01-01"), PaymentMethod = "Wallet", MembershipId=3 });
            base.OnModelCreating(modelBuilder);
        }
    }
}
