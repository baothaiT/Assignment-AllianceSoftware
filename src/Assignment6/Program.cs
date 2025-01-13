
using Assignment6.Services;

class Program
{
    static void Main(string[] args)
    {
        var currentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        string folderPath = Path.Combine(currentDirectory, "ImageLevel1");

        // Get All File
        var allFileSearchContext = new FileSearchContext(new AllFileFilterStrategy());
        var allFiles = allFileSearchContext.GetFiles(folderPath);
        var fileNames = allFiles.Select(file => Path.GetFileName(file)).ToList();
        Console.WriteLine($"List image from {folderPath}");
        foreach (var fileName in fileNames)
        {
            Console.WriteLine(fileName);
        }
        Console.WriteLine("------------");

        // Get image files
        var fileSearchContext = new FileSearchContext(new ImageFileFilterStrategy());
        var imageFiles = fileSearchContext.GetFiles(folderPath);
        var imageNames = imageFiles.Select(imgae => Path.GetFileName(imgae)).ToList();
        Console.WriteLine($"List file from {folderPath}");
        foreach (var imageName in imageNames)
        {
            Console.WriteLine(imageName);
        }
    }
}

