

namespace Assignment6.Services.Interfaces.StrategyPattern;

public interface IFileFilterStrategy
{
    List<string> FilterFiles(IEnumerable<string> files);
}
