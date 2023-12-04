using DesignPatterns.AbstractFactory.Product;

namespace DesignPatterns.AbstractFactory.Factory
{
    public interface IGUIFactory
    {
        IButton CreateButton();
        ICheckbox CreateCheckbox();
    }
}
