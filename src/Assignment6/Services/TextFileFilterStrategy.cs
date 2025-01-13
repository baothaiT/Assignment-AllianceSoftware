

using Assignment6.Services.Interfaces.StrategyPattern;

namespace Assignment6.Services;

public class TextFileFilterStrategy : IFileFilterStrategy
{
    private readonly HashSet<string> _textExtensions = new(StringComparer.OrdinalIgnoreCase)
    {
        ".txt", ".log", ".md"
    };

    public List<string> FilterFiles(IEnumerable<string> files)
    {
        return files.Where(file => _textExtensions.Contains(Path.GetExtension(file))).ToList();
    }
}
