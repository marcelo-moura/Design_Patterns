// SEM VIOLAR O ENCAPSULAMENTO, CAPTURAR E EXTERNALIZAR UM ESTADO INTERNO DE UM OBJETO,
// DE MANEIRA QUE O OBJETO POSSA SER RESTAURADO PARA ESSE ESTADO MAIS TARDE

/*
O padrão ConcreteMemento é usado para capturar e armazenar o estado interno de um objeto sem violar o encapsulamento. 
Isso permite que o objeto seja restaurado posteriormente para o seu estado anterior. 
Para implementar o padrão ConcreteMemento, precisamos de três classes:

A classe Originator, que é a classe cujo estado desejamos salvar e restaurar.
A classe ConcreteMemento, que é uma classe auxiliar que armazena o estado interno do Originator.
A classe Caretaker, que é responsável por armazenar e gerenciar os objetos ConcreteMemento.
*/

// Exemplo de uso
EditorTexto editor = new("Hello world!");
CaretakerMemento gerenciador = new();

editor.ExibirTexto();

gerenciador.AdicionarMemento(editor.Salvar());

editor.Escrever("Olá");
editor.ExibirTexto();

gerenciador.AdicionarMemento(editor.Salvar());

editor.Escrever("Mundo");
editor.ExibirTexto();

gerenciador.AdicionarMemento(editor.Salvar());

editor.Restaurar(gerenciador.GetMemento(1));
editor.ExibirTexto();

editor.Restaurar(gerenciador.GetMemento(0));
editor.ExibirTexto();

Console.ReadKey();
