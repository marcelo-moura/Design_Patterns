namespace DesignPatterns.Bridge
{
    public class JanelaLinux : IJanelaBridge
    {
        public void DesenharJanela(string titulo)
        {
            Console.WriteLine(titulo + " - Janela Linux");
        }

        public void DesenharBotao(string titulo)
        {
            Console.WriteLine(titulo + " - Botão Linux");
        }        
    }
}
