// SEPARAR A CONSTRUÇÃO DE UM OBJETO COMPLEXO DE SUA REPRESENTAÇÃO
// DE MODO QUE O MESMO PROCESSO DE CONSTRUÇÃO POSSA CRIAR DIFERENTES REPRESENTAÇÕES

using DesignPatterns.Builder;

//X-Salada
HamburguerBuilder hamburguerBuilder = new();
var xSalada = hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemSalada()
    .Build();

//X-Bacon
hamburguerBuilder = new();
var xBacon = hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemQueijo()
    .Build();

//X-Tudo
hamburguerBuilder = new();
var xTudo = hamburguerBuilder
    .SetTipoPao("Branco")
    .SetTipoCarne("Bovina")
    .TemBacon()
    .TemQueijo()
    .TemSalada()
    .TemBatataPalha()
    .Build();

Console.WriteLine(xSalada.GetDescricao());
Console.WriteLine("------------------------------------");
Console.WriteLine(xBacon.GetDescricao());
Console.WriteLine("------------------------------------");
Console.WriteLine(xTudo.GetDescricao());