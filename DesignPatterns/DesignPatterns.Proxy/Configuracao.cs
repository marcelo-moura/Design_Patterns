namespace DesignPatterns.Proxy
{
    public class Configuracao : IConfiguracao
    {
        public void Inicializar()
        {
            Console.WriteLine("Configurações inicializadas");
        }

        public void Atualizar()
        {
            Console.WriteLine("Configurações atualizadas");
        }

        public void SetConfig(string key, string value)
        {
            Console.WriteLine($"Configurações registradas: {key}:{value}");
        }

        public string GetConfig(string key)
        {
            Random random = new();
            return $"Valor da configuração {key} é: {random.Next()}";
        }
    }
}
