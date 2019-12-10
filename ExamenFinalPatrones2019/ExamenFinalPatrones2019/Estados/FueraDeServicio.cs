using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinalPatrones2019.Modelos;

namespace ExamenFinalPatrones2019.Estados
{
    public class FueraDeServicio:EstadoCajeroAutomatico
    {
        public FueraDeServicio()
        {

        }
        public double Atender()
        {
            Console.WriteLine("Cajero fuera de servicio");
            while (true) ;
        }
    }
}
