// REPRESENTAR UMA OPERAÇÃO A SER EXECUTADA NOS ELEMENTOS DE UMA ESTRUTURA DE OBJETOS.
// VISITOR PERMITE DEFINIR UMA NOVA OPERAÇÃO SEM MUDAR AS CLASSES DOS ELEMENTOS SOBRE OS QUAIS OPERA

/*
Neste exemplo, Pessoa é uma classe que representa uma pessoa, que possui um método Accept para receber um objeto visitante. 
A interface IVisitor define o método Visit para o tipo Pessoa. 
PessoaVisitor é uma implementação concreta de IVisitor que define o comportamento de Visit, verificando se a pessoa é maior ou menor de idade. 
No método Main, dois objetos Pessoa são criados e o visitante PessoaVisitor é utilizado para visitar cada objeto, 
imprimindo no console se a pessoa é maior ou menor de idade. 
*/

var pessoa1 = new Pessoa { Nome = "João", Idade = 20 };
var pessoa2 = new Pessoa { Nome = "Maria", Idade = 16 };

var visitor = new PessoaVisitor();

pessoa1.Accept(visitor); // João é maior de idade.
pessoa2.Accept(visitor); // Maria é menor de idade.
