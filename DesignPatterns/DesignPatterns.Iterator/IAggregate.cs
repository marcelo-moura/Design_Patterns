// A interface IAggregate define uma operação que cria um objeto de Iterator.
public interface IAggregate
{
    IIterator CreateIterator();
    int Count { get; }
    object this[int index] { get; set; }
}
