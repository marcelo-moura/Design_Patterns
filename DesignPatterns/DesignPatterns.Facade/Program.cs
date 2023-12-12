// FORNECER UMA INTERFACE UNIFICADA PARA UM CONJUNTO DE INTERFACES EM UM SUBSISTEMA.
// FACADE DEFINE UMA INTERFACE DE NÍVEL MAIS ALTO QUE TORNA O SUBSISTEMA MAIS FÁCIL DE SER USADO.

using DesignPatterns.Facade;

ScoreClienteFacade scoreFacade = new ScoreClienteFacade();

var score = scoreFacade.Score("12345678900", "521324832");

Console.WriteLine("O score do cliente é: " + score);