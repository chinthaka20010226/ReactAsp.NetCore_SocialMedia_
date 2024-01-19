using Microsoft.EntityFrameworkCore;

namespace backend_.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        
    }
}
