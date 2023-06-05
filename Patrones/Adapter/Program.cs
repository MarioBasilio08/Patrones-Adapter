using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Adaptador de automovil  vehiculo
            Automovil automovil = new Automovil();
            IVehiculo adaptadorAutomovil = new AdaptadorAutomovil(automovil);
            Cliente clienteAutomovil = new Cliente(adaptadorAutomovil);
            clienteAutomovil.UtilizarVehiculo();

            Console.WriteLine();

            // Adaptador de motocicleta  vehiculo
            Motocicleta motocicleta = new Motocicleta();
            IVehiculo adaptadorMotocicleta = new AdaptadorMotocicleta(motocicleta);
            Cliente clienteMotocicleta = new Cliente(adaptadorMotocicleta);
            clienteMotocicleta.UtilizarVehiculo();

            Console.ReadKey();
        }
    }
}
