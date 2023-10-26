using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fabrica
    {
        private int capacidad;
        private List<Vehiculo> vehiculos;

        public List<Vehiculo> Vehiculos 
        { 
            get {return vehiculos; }
        }

        private Fabrica()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        public Fabrica(int capacidad) :this()
        {
            this.capacidad = capacidad;
        }


        /// <summary>
        /// Agrega un vehiculo a la lista y revisa que no haya un vehiculo identico ya existente
        /// </summary>
        /// <param name="fabrica"></param>
        /// <param name="vehiculo"></param>
        /// <returns></returns>
        public static Fabrica operator + (Fabrica fabrica, Vehiculo vehiculo)
        {
            bool aux = true;
            foreach (Vehiculo v in fabrica.vehiculos)
            {
                if (v == vehiculo)
                {
                    aux = false;
                }
            }
            if (aux == true && fabrica.capacidad > fabrica.vehiculos.Count())
            {
                fabrica.vehiculos.Add(vehiculo);
            }
            return fabrica;
        }

        public static Fabrica operator -(Fabrica fabrica, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in fabrica.vehiculos)
            {
                if (v == vehiculo)
                {
                    fabrica.vehiculos.Remove(vehiculo);
                    break;
                }
            }
            return fabrica;
        }

    }

}
