using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class RadioButton : IUIElement
    {
        private string color;
        private string label;
        private Boolean[] opciones;

        public RadioButton(string color, string label, int numOpciones)
        {
            this.color = color;
            this.label = label;
            this.opciones = new Boolean[numOpciones];

            for(int i = 0; i < numOpciones; i++)
            {
                this.opciones[i] = false;
            }
        }

        public void Render()
        {
            Console.WriteLine($"RadioButton con color: {color},etiqueta: {label} y numero de opciones {opciones.Length}");

            for(int i = 0;i < opciones.Length; i++)
            {
                Console.WriteLine($"Opcion: {i+1} valor: {opciones[i]}");
            }  
        }
    }
}
