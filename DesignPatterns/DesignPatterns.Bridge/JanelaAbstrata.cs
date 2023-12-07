namespace DesignPatterns.Bridge
{
    public abstract class JanelaAbstrata
    {
        protected IJanelaBridge _janela;

        public JanelaAbstrata(IJanelaBridge janela)
        {
            _janela = janela;
        }

        public void DesenharJanela(string titulo)
        {
            _janela.DesenharJanela(titulo);
        }

        public void DesenharBotao(string titulo)
        {
            _janela.DesenharBotao(titulo);
        }

        public abstract void Desenhar();
    }
}
