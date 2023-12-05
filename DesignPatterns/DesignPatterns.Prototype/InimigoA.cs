namespace DesignPatterns.Prototype
{
    public class InimigoA : Inimigo, IInimigoPrototype
    {
        public Inimigo ShallowCopy()
        {
            return (Inimigo)this.MemberwiseClone();
        }

        public Inimigo DeepCopy()
        {
            var result = (Inimigo)this.MemberwiseClone();
            result.Arma = new Arma("Faca");
            return result;
        }
    }
}
