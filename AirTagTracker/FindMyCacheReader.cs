using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirTagTracker
{

    internal class FindMyCacheReader
    {
        // public property of the type FindMyCache containing all of the read data
        public FindMyCache Cache { get; private set; }

        // constructor that loads the data file and does any required conversion so that the json can be read
        public FindMyCacheReader(string cacheDir)
        {
            // Supply the processed .data file
            ReadCache();
        }

        // method that reads the data
        private void ReadCache()
        {
            Cache = new FindMyCache();
        }
    }
}
