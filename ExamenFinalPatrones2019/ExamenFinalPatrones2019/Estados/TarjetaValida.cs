using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinalPatrones2019.Modelos;

namespace ExamenFinalPatrones2019.Estados
{
    public class TarjetaValida:EstadoCajeroAutomatico
    {
        private double saldo;
        public TarjetaValida(double s)
        {
            saldo = s;
        }
        public double Atender()
        {
            while(true)
            {
                Console.WriteLine("Ingrese el monto a retirar:");
                string a = Console.ReadLine();
                double h = Convert.ToDouble(a);
                if (saldo - h>= 0)
                    return h;
                Console.WriteLine("Cajero con cantidad requerida insuficiente");
            }
            
        }
    }
}
