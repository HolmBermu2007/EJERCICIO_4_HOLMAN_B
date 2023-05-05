using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO_4_HOLMAN_B
{
    internal class vehiculo
    { // definimos los campos de la clase
        int Id;
        string Marca;
        string Modelo;
        int KM;
        decimal Precio;
        int Año;
        //constructor y propiedades
        public vehiculo(int id, string marca, string modelo, int kM, decimal precio, int año)
        {
            Id1 = id;
            Marca1 = marca;
            Modelo1 = modelo;
            KM1 = kM;
            Precio1 = precio;
            Año1 = año;
        }
        public vehiculo()
        {

        }
        public int Id1 { get => Id; set => Id = value; }
        public string Marca1 { get => Marca; set => Marca = value; }
        public string Modelo1 { get => Modelo; set => Modelo = value; }
        public int KM1 { get => KM; set => KM = value; }
        public decimal Precio1 { get => Precio; set => Precio = value; }
        public int Año1 { get => Año; set => Año = value; }
        public override string ToString()
        {
            return "modelo: " + Modelo + "\n" + "marca:" + Marca + "\n" + "kilometraje: " + KM + "\n" + "precio: " + Precio + "\n" + "año:" + Año;
        }
        public virtual decimal precioestandar()
        {
            return Precio;
        }
    }
}
