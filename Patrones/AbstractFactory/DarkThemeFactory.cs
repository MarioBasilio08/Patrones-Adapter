using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete Factory 2
    public class DarkThemeFactory : IUIElementFactory
    {
        public IUIElement CreateButton()
        {
            return new Button("Dark", 14);
        }

        public IUIElement CreateTextField()
        {
            return new TextField("Modern", 16);
        }

        public IUIElement CreateCheckbox()
        {
            return new Checkbox("Dark", "Check");
        }

        public IUIElement CreateRadioButton()
        {
            return new RadioButton("Dark", "RadioButton", 2);
        }
    }
}
