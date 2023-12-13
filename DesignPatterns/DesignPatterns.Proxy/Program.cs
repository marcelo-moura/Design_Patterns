// FORNECER UM SUBSTITUTO OU MARCADOR DA LOCALIZAÇÃO DE OUTRO OBJETO PARA CONTROLAR O ACESSO A ESSE OBJETO

using DesignPatterns.Proxy;

ConfiguracaoProxy configuracaoProxy = new();

configuracaoProxy.Inicializar();
configuracaoProxy.SetConfig("001", "test");
Console.WriteLine(configuracaoProxy.GetConfig("001"));
