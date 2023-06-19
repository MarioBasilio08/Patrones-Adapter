using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete Product A3
    public class Checkbox : IUIElement
    {
        private string color;
        private string label;

        public Checkbox(string color, string label)
        {
            this.color = color;
            this.label = label;
        }

        public void Render()
        {
            Console.WriteLine($"Checkbox con color: {color} y etiqueta: {label}");
        }
    }
}
