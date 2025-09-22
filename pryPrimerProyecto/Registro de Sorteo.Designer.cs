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
            lblCantidadParticipantes = new Label();
            lblFecha = new Label();
            lblNombre = new Label();
            btnRegistrar = new Button();
            dTPFecha = new DateTimePicker();
            mtbCantidad = new MaskedTextBox();
            txtNombre = new TextBox();
            btnCancelar = new Button();
            lstResultado = new ListBox();
            SuspendLayout();
            // 
            // lblCantidadParticipantes
            // 
            lblCantidadParticipantes.AutoSize = true;
            lblCantidadParticipantes.Location = new Point(33, 189);
            lblCantidadParticipantes.Name = "lblCantidadParticipantes";
            lblCantidadParticipantes.Size = new Size(142, 15);
            lblCantidadParticipantes.TabIndex = 0;
            lblCantidadParticipantes.Text = "Cantidad de participantes";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(33, 118);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(93, 15);
            lblFecha.TabIndex = 1;
            lblFecha.Text = "Fecha del sorteo";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 46);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(106, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre del sorteo";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(101, 248);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(87, 34);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "&Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dTPFecha
            // 
            dTPFecha.Location = new Point(184, 112);
            dTPFecha.Name = "dTPFecha";
            dTPFecha.Size = new Size(200, 23);
            dTPFecha.TabIndex = 1;
            // 
            // mtbCantidad
            // 
            mtbCantidad.Location = new Point(184, 181);
            mtbCantidad.Mask = "99999";
            mtbCantidad.Name = "mtbCantidad";
            mtbCantidad.Size = new Size(200, 23);
            mtbCantidad.TabIndex = 2;
            mtbCantidad.ValidatingType = typeof(int);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(184, 43);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(200, 23);
            txtNombre.TabIndex = 0;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(254, 248);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 34);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstResultado
            // 
            lstResultado.FormattingEnabled = true;
            lstResultado.ItemHeight = 15;
            lstResultado.Location = new Point(44, 318);
            lstResultado.Name = "lstResultado";
            lstResultado.Size = new Size(351, 94);
            lstResultado.TabIndex = 5;
            // 
            // frmSorteo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(446, 447);
            Controls.Add(lstResultado);
            Controls.Add(btnCancelar);
            Controls.Add(txtNombre);
            Controls.Add(mtbCantidad);
            Controls.Add(dTPFecha);
            Controls.Add(btnRegistrar);
            Controls.Add(lblNombre);
            Controls.Add(lblFecha);
            Controls.Add(lblCantidadParticipantes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmSorteo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Sorteo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidadParticipantes;
        private Label lblFecha;
        private Label lblNombre;
        private Button btnRegistrar;
        private DateTimePicker dTPFecha;
        private MaskedTextBox mtbCantidad;
        private TextBox txtNombre;
        private Button btnCancelar;
        private ListBox lstResultado;
    }
}