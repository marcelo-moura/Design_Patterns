// DEFINIR UMA FAMILIA DE ALGORITMOS, ENCAPSULAR CADA UMA DELAS E TORNA-LAS INTERCAMBIAVEIS.
// STRATEGY PERMITE QUE O ALGORITMO VARIE INDEPENDENTEMENTE DOS CLIENTES QUE O UTILIZAM

/*
Nesse exemplo, a interface IStrategy define o contrato para as estratégias, que são implementadas pelas classes StrategyA e StrategyB. 
A classe Context é responsável por manter a referência para a estratégia atual e por chamar o método Execute da estratégia quando necessário. 
O programa de exemplo cria um contexto com a estratégia A, executa a estratégia A, troca a estratégia para a estratégia B e executa a estratégia B
*/

var context = new Context(new StrategyA());
context.ExecuteStrategy();

context.SetStrategy(new StrategyB());
context.ExecuteStrategy();

Console.ReadLine();
