// DINAMICAMENTE, AGREGAR RESPONSABILIDADES ADICIONAIS A OBJETOS.
// OS DECORATORS FORNECEM UMA ALTERNATIVA FLEXIVEL AO USO DE SUBCLASSES PARA EXTENSÃO DE FUNCIONALIDADES

using DesignPatterns.Decorator;
using DesignPatterns.Decorator.Decorator.Concrete;

ICarro carro = new Carro();
ICarro rodaDecorator = new RodaLigaDecorator(carro);
ICarro arDecorator = new ArCondicionadoDecorator(rodaDecorator);
ICarro bancoDecorator = new BancoCouroDecorator(arDecorator);
ICarro multimidiaDecorator = new RodaLigaDecorator(bancoDecorator);

var result = multimidiaDecorator.RetornarCarro();

Console.WriteLine(result);
