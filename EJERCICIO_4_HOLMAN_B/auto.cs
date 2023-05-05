using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_HOLMAN_B
{
    internal class  auto : vehiculo
    {
        char airbag;

        public auto(int id, string marca, string modelo, int kM, decimal precio, int año, char airbag)
        {
            this.Id1 = id;
            this.Marca1 = marca;
            this.Modelo1 = modelo;
            this.KM1 = kM;
            this.Precio1 = precio;
            this.Año1 = año;

            this.Airbag = airbag;
        }


        public char Airbag { get => airbag; set => airbag = value; }

        public override decimal precioestandar()
        {
            if(Airbag == 's'|| Airbag == 'S')
            {
                Precio1 += 250;
                return base.precioestandar();

            }
            else
            {
                Console.WriteLine(" este auto no lleva bolsas de aire");
                return precioestandar();
               
            }
        }
    }
}
