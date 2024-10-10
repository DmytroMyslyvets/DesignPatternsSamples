using DesignPatternsSamples.Factory;
using DesignPatternsSamples.Helpers;

namespace DesignPatternsSamples.AbstractFactory
{
    public class AbstractFactorySample
    {
        public AbstractFactorySample()
        {
            new NavigationBar(new AppleUI());
            new DropdownMenu(new AppleUI());
            new NavigationBar(new AndroidUI());
            new DropdownMenu(new AndroidUI());
        }
    }

    public interface IUIFactory
    {
        Button CreateButton();
    }

    public class AppleUI : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button() { Type = "Apple UI new Button".Dump() };
        }
    }

    public class AndroidUI : IUIFactory
    {
        public Button CreateButton()
        {
            return new Button() { Type = "Android UI new Button".Dump() };
        }
    }
    public class NavigationBar
    {
        public NavigationBar(IUIFactory factory) => factory.CreateButton();
    }

    public class DropdownMenu
    {
        public DropdownMenu(IUIFactory factory) => factory.CreateButton();
    }

     

}
