using Assignment6.Services.Interfaces.StrategyPattern;

namespace Assignment6.Services;

public class FileSearchContext
{
    private readonly IFileFilterStrategy _fileFilterStrategy;

    public FileSearchContext(IFileFilterStrategy fileFilterStrategy)
    {
        _fileFilterStrategy = fileFilterStrategy;
    }

    public List<string> GetFiles(string pathOfFolder)
    {
        if (!Directory.Exists(pathOfFolder))
        {
            throw new DirectoryNotFoundException($"The folder does not exist: {pathOfFolder}");
        }
        var allFiles = Directory.EnumerateFiles(pathOfFolder, "*.*", SearchOption.AllDirectories);
        return _fileFilterStrategy.FilterFiles(allFiles);
    }
}
