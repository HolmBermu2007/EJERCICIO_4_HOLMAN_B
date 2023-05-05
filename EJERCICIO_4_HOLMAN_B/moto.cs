using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_HOLMAN_B
{
    internal class moto: vehiculo
    {
        char sidecar;

        public moto(int id, string marca, string modelo, int kM, decimal precio, int año, char sidecar)
        {
            this.Id1 = id;
            this.Marca1 = marca;
            this.Modelo1 = modelo;
            this.KM1 = kM;
            this.Precio1 = precio;
            this.Año1 = año;
            this.sidecar = sidecar;
        }

        public char Sidecar { get => sidecar; set => sidecar = value; }

        
        public override decimal precioestandar()
        {
            if (sidecar == 's' || sidecar == 'S')
            {
                Precio1 += 50;
                return base.precioestandar();

            }
            else
            {
                Console.WriteLine(" La moto no tiene Sidecar");
                return precioestandar();

            }
        }
    }
}
