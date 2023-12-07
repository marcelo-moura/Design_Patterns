namespace DesignPatterns.Bridge
{
    public class JanelaDialogo : JanelaAbstrata
    {
        public JanelaDialogo(IJanelaBridge janela) : base(janela)
        {
        }

        public override void Desenhar()
        {
            DesenharJanela("Atenção! Deseja encerrar sem salvar?");
            DesenharBotao("Sim");
            DesenharBotao("Não");
        }
    }
}
