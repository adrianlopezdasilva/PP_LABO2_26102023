using Entidades;

namespace Formularios

{
    public partial class FrmView : Form
    {
        private Fabrica fabrica;
        public FrmView()
        {
            InitializeComponent();
            InicializarFabrica();
            lstVehiculos.Text = string.Empty;
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Camioneta");
            cmbTipo.Items.Add("Moto");
        }

        private void Refrescar()
        {
            cmbTipo.Text = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }

        private void btnFabricar_Click(object sender, EventArgs e)
        {

        }

        private void InicializarFabrica()
        { 
        }
    }
}