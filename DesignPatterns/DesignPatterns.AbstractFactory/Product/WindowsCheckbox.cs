namespace DesignPatterns.AbstractFactory.Product
{
    public class WindowsCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Drawing checkbox in Windows");
        }
    }
}
