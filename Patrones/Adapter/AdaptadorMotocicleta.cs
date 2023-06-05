using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class AdaptadorMotocicleta : IVehiculo
    {
        public Motocicleta motocicleta;

        public AdaptadorMotocicleta(Motocicleta motocicleta)
        {
            this.motocicleta = motocicleta;
        }

        public void Acelerar()
        {
            this.motocicleta.AcelerarMotocicleta();
        }

        public void Frenar()
        {
            this.motocicleta.FrenarMotocicleta();
        }
    }
}
