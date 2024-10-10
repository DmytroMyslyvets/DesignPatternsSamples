using DesignPatternsSamples.Factory;
using DesignPatternsSamples.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsSamples.FactoryMethod
{
    public class FactoryMethodSample
    {
        public FactoryMethodSample()
        {
            new NavigationBar();
            new DropdownMenu();
            new AndroidNavigationBar();
            new AndroidDropdownMenu();
            new AppleNavigationBar();
            new AppleDropdownMenu();
        }
    }

    public abstract class Element
    {
        protected abstract Button CreateButton();

        public Element() => CreateButton();
    }

    public class NavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Default Navigation Bar Button".Dump() };
        }
    }

    public class DropdownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Dafoult Dropdown Menu Button".Dump() };
        }
    }

    public class AndroidNavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Android Navigation Bar Button".Dump() };
        }
    }

    public class AndroidDropdownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Android Dropdown Menu Button".Dump() };
        }
    }

    public class AppleNavigationBar : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Apple Navigation Bar Button".Dump() };
        }
    }

    public class AppleDropdownMenu : Element
    {
        protected override Button CreateButton()
        {
            return new Button() { Type = "Apple Dropdown Menu Button".Dump() };
        }
    }
}
