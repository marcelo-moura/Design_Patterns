using DesignPatterns.FactoryMethod.Product;

namespace DesignPatterns.FactoryMethod.Creator
{
    public class ConcreteTelaWebCreator : TelaCreator
    {
        public override Tela CriaTela()
        {
            return new TelaWeb();
        }
    }
}
