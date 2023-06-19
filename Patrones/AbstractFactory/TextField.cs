using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    //Concrete Product A2
    public class TextField : IUIElement
    {
        private string style;
        private int size;

        public TextField(string style, int size)
        {
            this.style = style;
            this.size = size;
        }

        public void Render()
        {
            Console.WriteLine($"TextField con estilo: {style} y tamaño: {size}");
        }
    }
}
