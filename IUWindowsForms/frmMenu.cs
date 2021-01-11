using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IUWindowsForms
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarMateria frm1 = new frmAgregarMateria();
            frm1.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBuscar frm1 = new frmBuscar();
            frm1.ShowDialog();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            frmMostrarMaterias frm1 = new frmMostrarMaterias();
            frm1.ShowDialog();
        }
    }
}
