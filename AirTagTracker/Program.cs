// See https://aka.ms/new-console-template for more information
using AirTagTracker;

Cache? _cache = null;
List<Cache> _failedUploads = new List<Cache>();
string filepath = @"C:\Users\clark\Downloads\Items.data";

/// Can I make this run on startup in MacOS?
/// Open the Find My App (if Possible)
// Log that Find My is open (if Possible) Something like system.threading.tasks or TaskManager

// Infinite Loop
while (true)
{
    try
    {

        // Read the cahce from the directory
        Console.WriteLine("Reading Cache from Dir");
        // ~/Library/Cache/Apps... on Mac

        using (StreamReader reader = File.OpenText(filepath))
        {
            var text = reader.ReadToEnd();

            _cache = new Cache(text, filepath);
        }


        Console.WriteLine("Writing Cache to DB");
        // Write the latest Cache data to the database
        CacheUploader.Upload(_cache);
        // Will only pass this line when the upload succeeds. 
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
        _cache = null;

    }

    catch (Exception)
    {

        if (_cache != null) _failedUploads.Add(_cache);

        throw;
    }

    // Repeat every 15 minutes 
    Console.WriteLine("Waiting for repeat");
    Thread.Sleep(15 * 60000);
}
