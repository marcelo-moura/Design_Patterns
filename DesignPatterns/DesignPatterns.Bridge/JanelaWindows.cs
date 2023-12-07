namespace DesignPatterns.Bridge
{
    public class JanelaWindows : IJanelaBridge
    {
        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Windows");
        }

        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Windows");
        }
    }
}
