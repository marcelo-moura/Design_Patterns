// ENCAPSULAR UMA SOLICITAÇÃO COMO OBJETO, DESTA FORMA PERMITINDO PARAMETRIZAR CLIENTE COM DIFERENTES SOLICITAÇÕES,
// ENFILEIRAR OU FAZER O REGISTRO DE SOLICITAÇÕES E SUPORTAR OPERAÇÕES QUE PODEM SER DESFEITAS

// A classe Client cria os objetos necessários e configura a classe Invoker com os comandos
using DesignPatterns.Command;
using DesignPatterns.Command.Commands;

Receiver receiver = new();
OpenFileCommand openFileCommand = new(receiver);
SaveFileCommand saveFileCommand = new(receiver);
CloseFileCommand closeFileCommand = new(receiver);

Invoker invoker = new();
invoker.SetCommand(openFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(saveFileCommand);
invoker.ExecuteCommand();

invoker.SetCommand(closeFileCommand);
invoker.ExecuteCommand();