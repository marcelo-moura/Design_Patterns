namespace DesignPatterns.Proxy
{
    public class ConfiguracaoProxy : IConfiguracao
    {
        Configuracao configuracao = new();

        public void Inicializar()
        {
            configuracao.Inicializar();
        }

        void IConfiguracao.Atualizar()
        {
            throw new NotImplementedException();
        }

        public void SetConfig(string key, string value)
        {
            configuracao.SetConfig(key, value);
        }

        public string GetConfig(string key)
        {
            return configuracao.GetConfig(key);
        }
    }
}
