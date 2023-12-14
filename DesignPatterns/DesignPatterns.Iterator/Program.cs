// FORNECER UM MEIO DE ACESSAR, SEQUENCIALMENTE, OS ELEMENTOS DE UM OBJETO AGREGADO
// SEM EXPOR SUA REPRESENTAÇÃO SUBJACENTE

// Demonstração do padrão de design Iterator.
ConcreteAggregate aggregate = new ConcreteAggregate();
aggregate.AddItem("Item 1");
aggregate.AddItem("Item 2");
aggregate.AddItem("Item 3");

IIterator iterator = aggregate.CreateIterator();
Console.WriteLine("Iterating over collection:");


for (object item = iterator.First(); !iterator.IsDone; item = iterator.Next())
{
    Console.WriteLine(item);
}

Console.ReadKey();
