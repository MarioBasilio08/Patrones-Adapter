using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Renderizar elementos UI usando el tema blanco
            IUIElementFactory lightThemeFactory = new LightThemeFactory();
            UIElementRenderer lightThemeRenderer = new UIElementRenderer(lightThemeFactory);
            lightThemeRenderer.RenderUIElements();

            Console.WriteLine();

            // Renderizar elementos UI usando el tema oscuro
            IUIElementFactory darkThemeFactory = new DarkThemeFactory();
            UIElementRenderer darkThemeRenderer = new UIElementRenderer(darkThemeFactory);
            darkThemeRenderer.RenderUIElements();

            Console.ReadKey();
        }
    }
}
