using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete Factory 1
    public class LightThemeFactory : IUIElementFactory
    {
        public IUIElement CreateButton()
        {
            return new Button("Light", 12);
        }

        public IUIElement CreateTextField()
        {
            return new TextField("Simple", 14);
        }

        public IUIElement CreateCheckbox()
        {
            return new Checkbox("Light", "Enable");
        }

        public IUIElement CreateRadioButton()
        {
            return new RadioButton("Light", "RadioButton", 3);
        }
    }
}
