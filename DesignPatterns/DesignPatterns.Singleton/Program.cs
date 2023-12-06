// GARANTIR QUE UMA CLASSE TENHA SOMENTE UMA INSTÂNCIA
// E FORNECE UM PONTO GLOBAL DE ACESSO PARA A MESMA

using DesignPatterns.Singleton;

var log = LogSingleton.GetInstancia;
log.Write("Mensagem de log");