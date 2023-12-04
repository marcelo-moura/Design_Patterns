namespace DesignPatterns.AbstractFactory.Product
{
    public class WindowsButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Drawing button in Windows");
        }
    }
}
