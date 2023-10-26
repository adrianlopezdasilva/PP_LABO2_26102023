using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {
        private bool cabinaSimple;
        protected override string Tipo

        {
            get { return this.GetType().ToString(); }
        }

        public Camioneta(EPropulsion propulsion, bool cabinaSimple) : base(propulsion)
        {
            this.cabinaSimple = cabinaSimple;
            this.esAWD = true;
        }
    }
}
