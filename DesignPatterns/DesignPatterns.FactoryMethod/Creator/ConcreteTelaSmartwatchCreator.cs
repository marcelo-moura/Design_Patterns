using DesignPatterns.FactoryMethod.Product;

namespace DesignPatterns.FactoryMethod.Creator
{
    public class ConcreteTelaSmartwatchCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmartwatch();
        }
    }
}
