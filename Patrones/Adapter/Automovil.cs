using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Automovil
    {
        public void AcelerarAutomovil()
        {
            Console.WriteLine("Se realizo el cambio de velocidad");
            Console.WriteLine("Acelerando el automóvil");
        }

        public void FrenarAutomovil()
        {
            Console.WriteLine("Frenando el automóvil");
        }
    }
}
