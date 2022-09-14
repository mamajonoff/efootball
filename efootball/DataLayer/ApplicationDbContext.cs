using efootball.Models;
using Microsoft.EntityFrameworkCore;

namespace efootball.DataLayer
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<News> News { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>()
               .HasData(
                    new News()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Bootcamp Pro kursiga qabul davom etmoqda!",
                        Body = "✅ Endilikda yoshi 18 va undan yuqori bo'lganlar uchun kechki kurs ham tashkil etildi.  Ushbu kurs orqali Python, C++, Desktop dasturlash, mobil ilovalar yaratish va UI/UX dizaynlarini o'rganishingiz mumkin.",
                        CreatedTime = DateTime.Now,
                        Images = "about.jpg"
                    },
                    new News()
                    {
                        Id = Guid.NewGuid(),
                        Title = "Bootcamp Pro kursiga qabul davom etmoqda!",
                        Body = "✅ Endilikda yoshi 18 va undan yuqori bo'lganlar uchun kechki kurs ham tashkil etildi.  Ushbu kurs orqali Python, C++, Desktop dasturlash, mobil ilovalar yaratish va UI/UX dizaynlarini o'rganishingiz mumkin.",
                        CreatedTime= DateTime.Now,
                        Images = "about.jpg"
                    }
                );
        }
    }
}
