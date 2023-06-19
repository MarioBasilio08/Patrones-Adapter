using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Cliente
    public class UIElementRenderer
    {
        private IUIElementFactory factory;

        public UIElementRenderer(IUIElementFactory factory)
        {
            this.factory = factory;
        }

        public void RenderUIElements()
        {
            IUIElement button = factory.CreateButton();
            IUIElement textField = factory.CreateTextField();
            IUIElement checkbox = factory.CreateCheckbox();
            IUIElement radioButton = factory.CreateRadioButton();

            button.Render();
            textField.Render();
            checkbox.Render();
            radioButton.Render();
        }
    }
}
