using Microsoft.EntityFrameworkCore;

namespace PluginFramework.Models
{
    public class Image
    {
        public int id { get; set; }

        public string img { get; set; }

    }

    public class ImageDbContext: DbContext
    {
        public ImageDbContext(DbContextOptions<ImageDbContext>options):base(options)
        { }
        public DbSet<Image> Images { get; set; }
    }
}
