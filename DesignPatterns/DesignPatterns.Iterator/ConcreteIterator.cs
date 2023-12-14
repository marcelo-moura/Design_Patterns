// A classe ConcreteIterator implementa a interface IIterator e mantém o controle do estado da iteração.
public class ConcreteIterator : IIterator
{
    private ConcreteAggregate _aggregate;
    private int _currentIndex = 0;

    public ConcreteIterator(ConcreteAggregate aggregate)
    {
        _aggregate = aggregate;
    }

    public object First()
    {
        return _aggregate[0];
    }

    public object Next()
    {
        object result = null;
        if (_currentIndex < _aggregate.Count - 1)
        {
            _currentIndex++;
            result = _aggregate[_currentIndex];
        }
        return result;
    }

    public bool IsDone
    {
        get { return _currentIndex >= _aggregate.Count - 1; }
    }

    public object CurrentItem
    {
        get { return _aggregate[_currentIndex]; }
    }
}
