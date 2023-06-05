using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class Cliente
    {
        public IVehiculo vehiculo;
        public Automovil aut;
        public Motocicleta mot;

        public Cliente(IVehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }

        public void UtilizarVehiculo()
        {
            this.vehiculo.Acelerar();
            this.vehiculo.Frenar();
        }
    }
}
