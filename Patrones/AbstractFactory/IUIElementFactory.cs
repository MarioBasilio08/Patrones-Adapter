using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Abstract Factory
    public interface IUIElementFactory
    {
        IUIElement CreateButton();
        IUIElement CreateTextField();
        IUIElement CreateCheckbox();
        IUIElement CreateRadioButton();
    }
}
