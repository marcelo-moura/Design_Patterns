// DEFINIR UMA INTERFACE PARA CRIAR UM OBJETO, MAS DEIXAR AS SUBCLASSES DECIDIREM QUE CLASSE INSTANCIAR.
// O FACTORY METHOD PERMITE ADIAR A INSTANCIAÇÃO PARA SUBCLASSES.

using DesignPatterns.FactoryMethod.Creator;
using DesignPatterns.FactoryMethod.Product;

Tela tela1 = new ConcreteTelaWebCreator().CriaTela();
Tela tela2 = new ConcreteTelaSmartphoneCreator().CriaTela();
Tela tela3 = new ConcreteTelaSmartwatchCreator().CriaTela();
Tela tela4 = new ConcreteTelaSmartvCreator().CriaTela();

Console.WriteLine("TELA WEB : " + tela1.GetMessageText());
Console.WriteLine("TELA SMARTPHONE: " + tela2.GetMessageText());
Console.WriteLine("TELA SMARTWATCH: " + tela3.GetMessageText());
Console.WriteLine("TELA SMARTTV: " + tela4.GetMessageText());
