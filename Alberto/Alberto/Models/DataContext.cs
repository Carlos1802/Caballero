
namespace Alberto.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {
        }

        public System.Data.Entity.DbSet<Alberto.Models.Fairy> Fairies { get; set; }
    }
}