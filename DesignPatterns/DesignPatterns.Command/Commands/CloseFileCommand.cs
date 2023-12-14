using DesignPatterns.Command.Interface;

namespace DesignPatterns.Command.Commands
{
    // As classes Command concretas implementam a interface ICommand e invocam os métodos do Receiver
    public class CloseFileCommand : ICommand
    {
        private Receiver _receiver;

        public CloseFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.CloseFile();
        }
    }
}
