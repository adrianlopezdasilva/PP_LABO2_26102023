using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Automovil : Vehiculo
    {
        protected override string Tipo
        {
            get { return this.GetType().ToString(); }
        }

        public Automovil(EPropulsion propulsion) : base(propulsion)
        {
            this.propulsion = EPropulsion.Hibrida;
        }
    }
}
