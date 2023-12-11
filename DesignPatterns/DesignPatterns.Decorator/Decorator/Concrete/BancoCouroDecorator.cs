using DesignPatterns.Decorator.Decorator.Base;

namespace DesignPatterns.Decorator.Decorator.Concrete
{
    public class BancoCouroDecorator : CarroDecorator
    {
        public BancoCouroDecorator(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Banco de Couro";
        }
    }
}
