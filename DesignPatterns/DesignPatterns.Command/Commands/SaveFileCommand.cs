using DesignPatterns.Command.Interface;

namespace DesignPatterns.Command.Commands
{
    // As classes Command concretas implementam a interface ICommand e invocam os métodos do Receiver
    public class SaveFileCommand : ICommand
    {
        private Receiver _receiver;

        public SaveFileCommand(Receiver receiver)
        {
            _receiver = receiver;
        }

        public void Execute()
        {
            _receiver.SaveFile();
        }
    }
}
