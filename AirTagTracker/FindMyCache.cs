using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTagTracker
{
    public class FindMyCache
    {
        // The JSON object of the cache & Important File Information

        public string DateTimeDataLastModified { get; set; }

        public DateTime DateTimeDataAccessed { get; }

        public FindMyCache()
        {
            DateTimeDataAccessed = DateTime.Now;
        }
    }
}
