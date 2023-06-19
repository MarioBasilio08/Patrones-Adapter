using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete Product A1
    public class Button : IUIElement
    {
        private string color;
        private int size;

        public Button(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public void Render()
        {
            Console.WriteLine($"Button con color: {color} y tamaño: {size}");
        }
    }
}
