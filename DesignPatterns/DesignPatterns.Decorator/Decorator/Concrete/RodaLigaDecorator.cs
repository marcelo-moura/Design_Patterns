using DesignPatterns.Decorator.Decorator.Base;

namespace DesignPatterns.Decorator.Decorator.Concrete
{
    public class RodaLigaDecorator : CarroDecorator
    {
        public RodaLigaDecorator(ICarro carro) : base(carro)
        {
        }

        public override string RetornarCarro()
        {
            return base.RetornarCarro() + " com Roda de Liga Leve";
        }
    }
}
