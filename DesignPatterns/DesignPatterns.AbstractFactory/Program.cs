// FORNECER UMA INTERFACE PARA CRIAÇÃO DE FAMÍLIAS DE OBJETOS RELACIONADOS OU DEPENDENTES
// SEM ESPECIFICAR SUAS CLASSES CONCRETAS

using DesignPatterns.AbstractFactory.Factory;

IGUIFactory factory;

factory = new MacFactory();
factory.CreateButton().Paint();
factory.CreateCheckbox().Paint();

factory = new WindowsFactory();
factory.CreateButton().Paint();
factory.CreateCheckbox().Paint();