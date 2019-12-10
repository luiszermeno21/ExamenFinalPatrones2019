using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenFinalPatrones2019.Modelos;

namespace ExamenFinalPatrones2019.Estados
{
    public class SinTarjeta : EstadoCajeroAutomatico
    {
        private double saldorestante;
        public SinTarjeta()
        {
            saldorestante = 5000;
        }
        public SinTarjeta(double sr)
        {
            saldorestante = sr;
        }
        public double Atender()
        {
            while(true)
            {
                Console.WriteLine("Ingrese el pin:");
                string a = Console.ReadLine();
                if (a == "1234" || a == "4321")
                    return saldorestante;
                else
                {
                    Console.WriteLine("Pin Incorrecto");
                }
            }
        }
    }
}
