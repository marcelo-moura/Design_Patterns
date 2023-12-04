using DesignPatterns.FactoryMethod.Product;

namespace DesignPatterns.FactoryMethod.Creator
{
    public class ConcreteTelaSmartphoneCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaSmarthphone();
        }
    }
}
