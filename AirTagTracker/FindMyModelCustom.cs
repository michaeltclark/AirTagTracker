using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AirTagTracker
{
    public partial class FindMyModel : DbContext
    {

        public FindMyModel()
        {
                
        }

        public static void ConfigureOptions(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=tcp:granitetestingground.database.windows.net,1433;Initial Catalog=airtags;Persist Security Info=False;User ID=GraniteAdmin;Password=mBnx$Ddqc$yP9wR;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

    }
}
