namespace Formularios
{
    partial class FrmView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmView));
            lstVehiculos = new ListBox();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            btnFabricar = new Button();
            btnEliminar = new Button();
            pcbFabrica = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.HorizontalScrollbar = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(23, 12);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(876, 574);
            lstVehiculos.TabIndex = 0;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblTipo.Location = new Point(957, 44);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(219, 37);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de vehiculo:";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(957, 118);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(219, 23);
            cmbTipo.TabIndex = 2;
            // 
            // btnFabricar
            // 
            btnFabricar.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFabricar.Location = new Point(957, 383);
            btnFabricar.Name = "btnFabricar";
            btnFabricar.Size = new Size(216, 87);
            btnFabricar.TabIndex = 3;
            btnFabricar.Text = "Fabricar";
            btnFabricar.UseVisualStyleBackColor = true;
            btnFabricar.Click += btnFabricar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEliminar.Location = new Point(957, 499);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(216, 87);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // pcbFabrica
            // 
            pcbFabrica.Image = Properties.Resources.icons8_vehicles_64;
            pcbFabrica.Location = new Point(957, 174);
            pcbFabrica.Name = "pcbFabrica";
            pcbFabrica.Size = new Size(216, 175);
            pcbFabrica.TabIndex = 5;
            pcbFabrica.TabStop = false;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 620);
            Controls.Add(pcbFabrica);
            Controls.Add(btnEliminar);
            Controls.Add(btnFabricar);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lstVehiculos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Fabrica de Vehiculos";
            Load += FrmView_Load;
            ((System.ComponentModel.ISupportInitialize)pcbFabrica).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculos;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Button btnFabricar;
        private Button btnEliminar;
        private PictureBox pcbFabrica;
    }
}