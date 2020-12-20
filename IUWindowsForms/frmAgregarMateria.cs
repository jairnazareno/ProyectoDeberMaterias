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
    public partial class frmAgregarMateria : Form
    {
        public frmAgregarMateria()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ProyectoMaterias.Materias mate = new ProyectoMaterias.Materias();
            mate.codMaterias = this.txtCodigo.Text;
            mate.nombreMateria = this.txtNombre.Text;
            mate.nivel = int.Parse(this.cmbNivel.Text);
            mate.carrera = this.cmbCarrera.Text;
        

            int x = ProyectoMaterias.MateriasDAO.crear(mate);

            if (x > 0)
                MessageBox.Show("Se agrego correctamente...");
            else
                MessageBox.Show("No se pudo agregar el registro..");
        }
    }
}

