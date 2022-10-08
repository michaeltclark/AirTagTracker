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
        public static void Write(Cache cache)
        {
            using (var context = new FindMyModel(new DbContextOptions<FindMyModel>()))
            {
                var session = context.UploadSessions.Add(
                    UploadSession.Create(
                        cache.DateTimeDataAccessed,
                        DateTime.Now,
                        cache.DateTimeDataLastModified
                        )
                    );

                // Foreach FindMyDevice in Cache, create a new data
                context.AirTagDatas.Add(AirTagData.Create(session.Entity));
            }
        }
    }
}
