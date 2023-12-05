namespace DesignPatterns.Prototype
{
    public interface IInimigoPrototype
    {
        Inimigo ShallowCopy();
        Inimigo DeepCopy();
    }
}
