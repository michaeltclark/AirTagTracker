using Microsoft.EntityFrameworkCore;

namespace AirTagTracker
{
    public partial class FindMyModel : DbContext
    {

        public FindMyModel()
        {
                
        }

        public static void ConfigureOptions(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionString);
        }
    }
}
