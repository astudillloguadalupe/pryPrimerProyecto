namespace pryPrimerProyecto
{
    partial class frmSorteo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblFecha = new Label();
            lblNombre = new Label();
            btnRegistrar = new Button();
            txtNombre = new TextBox();
            txtCantidad = new TextBox();
            lstFecha = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 238);
            label1.Name = "label1";
            label1.Size = new Size(142, 15);
            label1.TabIndex = 0;
            label1.Text = "Cantidad de participantes";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(46, 159);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(93, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha del sorteo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(46, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(106, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del sorteo";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(341, 290);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 23);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(198, 82);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(198, 238);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // lstFecha
            // 
            lstFecha.FormattingEnabled = true;
            lstFecha.Location = new Point(198, 159);
            lstFecha.Name = "lstFecha";
            lstFecha.Size = new Size(121, 23);
            lstFecha.TabIndex = 7;
            // 
            // frmSorteo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 340);
            Controls.Add(lstFecha);
            Controls.Add(txtCantidad);
            Controls.Add(txtNombre);
            Controls.Add(btnRegistrar);
            Controls.Add(lblNombre);
            Controls.Add(lblFecha);
            Controls.Add(label1);
            Name = "frmSorteo";
            Text = "Registro de Sorteo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblFecha;
        private Label lblNombre;
        private Button btnRegistrar;
        private TextBox txtNombre;
        private TextBox txtCantidad;
        private ComboBox lstFecha;
    }
}