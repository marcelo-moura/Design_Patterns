namespace DesignPatterns.AbstractFactory.Product
{
    public class MacButton : IButton
    {
        public void Paint()
        {
            Console.WriteLine("Drawing button in Mac OS");
        }
    }
}
