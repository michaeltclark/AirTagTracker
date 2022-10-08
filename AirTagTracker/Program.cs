// See https://aka.ms/new-console-template for more information
using AirTagTracker;

Cache _cache;

/// Can I make this run on startup in MacOS?
/// Open the Find My App (if Possible)
// Log that Find My is open (if Possible) Something like system.threading.tasks or TaskManager

Console.WriteLine("Reading Cache from Dir");
// Read the cahce from the directory
// ~/Library/Cache/Apps... on Mac
// Some temp location on PC   "C:\Users\clark\Downloads\Items.data"
using (StreamReader reader = File.OpenText(@"C:\Users\clark\Downloads\Items.data"))
{
    var text = reader.ReadToEnd();

    _cache = new Cache(text);
}


Console.WriteLine("Writing Cache to DB");
// Write the latest Cache data to the database
CacheUploader.Upload(_cache);

Console.WriteLine("Waiting for repeat");
// Repeat every 15 minutes 