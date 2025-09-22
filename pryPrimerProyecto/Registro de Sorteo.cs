using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryPrimerProyecto
{
    public partial class frmSorteo : Form
    {
        public frmSorteo()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {


        }
        private void LimpirControles()
        {
            txtNombre.Clear();
            dTPFecha.Value = DateTime.Now;
            mtbCantidad.Clear();
            txtNombre.Focus();
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            lstResultado.Items.Add("Nombre del sorteo: " + txtNombre.Text);
            lstResultado.Items.Add("Fecha del sorteo: " + dTPFecha.Text);
            lstResultado.Items.Add("Cantidad de participantes: " + mtbCantidad.Text);
            LimpirControles();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpirControles();
        }
    }
}
