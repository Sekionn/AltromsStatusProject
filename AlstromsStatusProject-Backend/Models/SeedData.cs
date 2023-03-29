using Microsoft.EntityFrameworkCore;

namespace AlstromsStatusProject_Backend.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ItemContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ItemContext>>()))
            {
                // Look for any movies.
                if (context.Items.Any())
                {
                    return;   // DB has been seeded
                }
                context.Items.AddRange(
                    new Item
                    {
                        Date = DateTime.Parse("1989-2-12").ToString(),
                        Barcode = "Romantic Comedy",
                        AmountCounted = 7,
                        ShelfOfOrigin = 1
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
