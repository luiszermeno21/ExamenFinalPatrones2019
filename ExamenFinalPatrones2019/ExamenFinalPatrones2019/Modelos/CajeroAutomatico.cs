using ExamenFinalPatrones2019.Estados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalPatrones2019.Modelos
{
    public class CajeroAutomatico
    {
        private EstadoCajeroAutomatico estado;
        private double saldo;
        private double monto;

        public CajeroAutomatico()
        {
            saldo = 5000;
            estado = new SinTarjeta();
        }

        public void IniciarCajero()
        {
            while(true)
            {
                Console.WriteLine("------------------------------------------------");
                monto = estado.Atender();
                estado = new TarjetaValida(saldo);
                monto = estado.Atender();
                saldo -= monto;
                estado = new EntregaDeDinero(monto);
                monto = estado.Atender();
                if (saldo == 0)
                {
                    estado = new FueraDeServicio();
                    estado.Atender();
                }
                else
                    estado = new SinTarjeta(saldo);
            }
            
        }
    }
}
