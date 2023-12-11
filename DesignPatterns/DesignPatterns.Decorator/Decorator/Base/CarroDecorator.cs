namespace DesignPatterns.Decorator.Decorator.Base
{
    //Decorator (Base)
    public class CarroDecorator : ICarro
    {
        private readonly ICarro _carro;
        public CarroDecorator(ICarro carro)
        {
            _carro = carro;
        }

        public virtual string RetornarCarro()
        {
            return _carro.RetornarCarro();
        }
    }
}
