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

        protected override string GetInfo()
        {
            base.GetInfo();
            StringBuilder sb = new StringBuilder();
            if(this.cabinaSimple == true)
            {
                sb.AppendLine($"con cabina simple");

            }
            else
            {
                sb.AppendLine($"con cabina doble");

            }

            return sb.ToString();
        }
    }
}
