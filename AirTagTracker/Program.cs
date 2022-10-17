// See https://aka.ms/new-console-template for more information
using AirTagTracker;

Cache? _cache = null;
List<Cache> _failedUploads = new List<Cache>();

/// Can I make this run on startup in MacOS?
/// Open the Find My App (if Possible)
// Log that Find My is open (if Possible) Something like system.threading.tasks or TaskManager

// Infinite Loop
while (true)
{
    try
    {
        Console.WriteLine("Reading Cache from Dir");

        using (StreamReader reader = File.OpenText(ConfigurationManager.CacheFilepath))
        {
            _cache = new Cache(reader.ReadToEnd(), ConfigurationManager.CacheFilepath);
        }

        Console.WriteLine("Writing Cache to DB");

        CacheUploader.Upload(_cache);
        _cache = null;

        // Will only pass this line when the upload succeeds. IE should be connected to internet and able to access DB.
        if (_failedUploads.Count > 0)
        {
            foreach (var item in _failedUploads)
            {
                // Attempt to upload the failed item
                CacheUploader.Upload(item);

                // Remove the stored item from the list
                _failedUploads.Remove(item);
            }
        }
    }

    catch (Exception)
    {
        if (_cache != null) _failedUploads.Add(_cache);
        throw;
    }

    // Repeat every 15 minutes 
    Console.WriteLine("Waiting for repeat");
    Thread.Sleep(ConfigurationManager.SampleTime);
}
