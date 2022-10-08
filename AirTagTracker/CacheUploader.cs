using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTagTracker
{
    public class CacheUploader
    {
        /// <summary>
        /// Write the supplied FindMyCache to the database
        /// </summary>
        public static void Write(FindMyCache cache)
        {
            using (var dbcx = new FindMyModel())
            {

            }
        }
    }
}
