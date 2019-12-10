using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinalPatrones2019.Modelos;

namespace ExamenFinalPatrones2019.Estados
{
    public class EntregaDeDinero:EstadoCajeroAutomatico
    {
        public double monto;
        public EntregaDeDinero(double m)
        {
            monto = m;
        }

        public double Atender()
        {
            Console.WriteLine("Cantidad retirada: $" + monto.ToString());
            return monto;
        }
    }
}
