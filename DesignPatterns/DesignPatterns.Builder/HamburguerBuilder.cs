namespace DesignPatterns.Builder
{
    public class HamburguerBuilder
    {
        private readonly Hamburguer _hamburguer;

        public HamburguerBuilder()
        {
            _hamburguer = new Hamburguer();
        }

        public HamburguerBuilder SetTipoPao(string tipoPao)
        {
            _hamburguer.TipoPao = tipoPao;
            return this;
        }

        public HamburguerBuilder SetTipoCarne(string tipoCarne)
        {
            _hamburguer.TipoCarne = tipoCarne;
            return this;
        }

        public HamburguerBuilder TemBacon()
        {
            _hamburguer.TemBacon = true;
            return this;
        }

        public HamburguerBuilder TemBatataPalha()
        {
            _hamburguer.TemBatataPalha = true;
            return this;
        }

        public HamburguerBuilder TemQueijo()
        {
            _hamburguer.TemQueijo = true;
            return this;
        }

        public HamburguerBuilder TemSalada()
        {
            _hamburguer.TemSalada = true;
            return this;
        }

        public Hamburguer Build() => _hamburguer;
    }
}
