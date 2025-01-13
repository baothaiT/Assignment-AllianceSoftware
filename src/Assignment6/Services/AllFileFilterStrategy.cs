using Assignment6.Services.Interfaces.StrategyPattern;

namespace Assignment6.Services;

public class AllFileFilterStrategy : IFileFilterStrategy
{
    public List<string> FilterFiles(IEnumerable<string> files)
    {
        return files.ToList();
    }
}
