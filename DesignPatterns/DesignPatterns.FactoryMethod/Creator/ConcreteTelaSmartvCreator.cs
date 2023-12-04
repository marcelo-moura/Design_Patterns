using DesignPatterns.FactoryMethod.Product;

namespace DesignPatterns.FactoryMethod.Creator
{
    public class ConcreteTelaSmartvCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmarttv();
        }
    }
}
