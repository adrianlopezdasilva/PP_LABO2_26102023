using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EPropulsion
        { 
            Combustion,
            Hibrida,
            Electrica
        }

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        public EPropulsion Propulsion { get { return this.propulsion; } }

        protected abstract string Tipo
        {
            get;
        }

        protected Vehiculo(EPropulsion propulsion)
        {
            this.propulsion = propulsion;
            this.esAWD = false;

            numeroDeChasis = Guid.NewGuid();
        }

        protected Vehiculo(EPropulsion propulsion, bool esAWD)  : this (propulsion)    
        {
            this.esAWD = esAWD;
        }

        protected virtual string GetInfo()
        {

            return String.Format(this.Tipo, this.propulsion, this.esAWD, this.numeroDeChasis, "{0} con propulsion a {1}, {2} es AWD, numero de chasis {3}");
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2)
        {
            return v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        public override string ToString()
        {
            return this.GetInfo();
        }


    }
}