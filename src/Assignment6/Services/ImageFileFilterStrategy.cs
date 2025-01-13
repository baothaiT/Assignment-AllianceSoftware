

using Assignment6.Services.Interfaces.StrategyPattern;

namespace Assignment6.Services;

public class ImageFileFilterStrategy : IFileFilterStrategy
{
    private readonly HashSet<string> _imageExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".jpg", ".jpeg", ".png", ".bmp", ".gif", ".tiff", ".webp"
    };

    public List<string> FilterFiles(IEnumerable<string> files)
    {
        return files.Where(file => _imageExtensions.Contains(Path.GetExtension(file))).ToList();
    }
}
