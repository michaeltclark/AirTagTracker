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
        public static bool Upload(Cache cache)
        {
            using (var context = new FindMyModelFactory().CreateDbContext())
            {
                var session = context.UploadSessions.Add(
                    UploadSession.Create(
                        cache.DateTimeDataAccessed,
                        DateTime.Now,
                        cache.DateTimeDataLastModified
                        )
                    );

                // Foreach FindMyDevice in Cache, create a new data

                foreach (Data _cacheData in cache.Data)
                {
                    var _airTagData = context.AirTagDatas.Add(AirTagData.Create(session.Entity)).Entity;
                    _airTagData.TagName = _cacheData.Name;
                    _airTagData.Latitude = _cacheData.Location.Latitude;
                    _airTagData.Longitude = _cacheData.Location.Longitude;
                }

                context.SaveChanges();
            }

            return true;
        }
    }
}
