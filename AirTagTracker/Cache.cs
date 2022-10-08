using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AirTagTracker
{
    public class Cache
    {

        /// <summary>
        /// Metadata from MacOS indicating the last modified DateTime of the file. 
        /// </summary>
        public DateTime DateTimeDataLastModified { get; set; }

        /// <summary>
        /// When the Cache object is created
        /// </summary>
        public DateTime DateTimeDataAccessed { get; }

        public Data[] Data { get; }


        public Cache(string json)
        {
            DateTimeDataAccessed = DateTime.Now;

            Data = JsonConvert.DeserializeObject<Data[]>(json);
        }

    }


    public partial class Data
    {
        public static Data[] FromJson(string json) => JsonConvert.DeserializeObject<Data[]>(json);
    }

    public partial class Data
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

    }

    public partial class Location
    {
        [JsonProperty("longitude")]
        public double Longitude { get; set; }

        [JsonProperty("latitude")]
        public double Latitude { get; set; }

        //[JsonProperty("positionType")]
        //public string PositionType { get; set; }

        //[JsonProperty("verticalAccuracy")]
        //public long VerticalAccuracy { get; set; }

        //[JsonProperty("floorLevel")]
        //public long FloorLevel { get; set; }

        //[JsonProperty("isInaccurate")]
        //public bool IsInaccurate { get; set; }

        //[JsonProperty("isOld")]
        //public bool IsOld { get; set; }

        //[JsonProperty("horizontalAccuracy")]
        //public double HorizontalAccuracy { get; set; }

        //[JsonProperty("timeStamp")]
        //public long TimeStamp { get; set; }

        //[JsonProperty("altitude")]
        //public long Altitude { get; set; }

        //[JsonProperty("locationFinished")]
        //public bool LocationFinished { get; set; }
    }
}
