// A interface IIterator define as operações para iterar sobre a coleção.
public interface IIterator
{
    object First();
    object Next();
    bool IsDone { get; }
    object CurrentItem { get; }
}
