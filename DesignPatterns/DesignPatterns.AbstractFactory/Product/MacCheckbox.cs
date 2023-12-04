namespace DesignPatterns.AbstractFactory.Product
{
    public class MacCheckbox : ICheckbox
    {
        public void Paint()
        {
            Console.WriteLine("Drawing checkbox in Mac OS");
        }
    }
}
