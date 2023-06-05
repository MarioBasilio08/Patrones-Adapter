using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorAutomovil : IVehiculo
    {
        private readonly Automovil automovil;

        public AdaptadorAutomovil(Automovil automovil)
        {
            this.automovil = automovil;
        }

        public void Acelerar()
        {
            this.automovil.AcelerarAutomovil();
        }

        public void Frenar()
        {
            this.automovil.FrenarAutomovil();
        }
    }
}
