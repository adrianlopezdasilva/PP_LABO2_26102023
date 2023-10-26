namespace Formularios
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            cmbTipo.Items.Add("Automovil");
            cmbTipo.Items.Add("Camioneta");
            cmbTipo.Items.Add("Moto"); ;


        }

        private void Refrescar()
        {
            cmbTipo.Text = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Refrescar();
        }
    }
}