using DesignPatterns.Command.Interface;

namespace DesignPatterns.Command
{
    // O Invoker é a classe que executa os comandos
    public class Invoker
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}
