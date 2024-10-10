using DesignPatternsSamples.Factory;
using DesignPatternsSamples.Helpers;

namespace DesignPatternsSamples.FactorySample
{
    public class FactorySample
    {
        public FactorySample()
        {
            new NavigationBar();
            new DropdownMenu();
        }
    }

    public class NavigationBar
    {
       public NavigationBar() => ButtonFactory.CreateButton();
    }

    public class DropdownMenu
    {
        public DropdownMenu() => ButtonFactory.CreateButton();
    }

    public class ButtonFactory
    {
        public static Button CreateButton()
        {
            return new Button() { Type = "Red button".Dump() };
        }
    }

}
