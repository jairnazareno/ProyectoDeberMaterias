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
    public partial class frmActualizar : Form
    {
        private String mCodMateria;
        public frmActualizar(String codMaterias)
        {
            InitializeComponent();
            this.mCodMateria = codMaterias;
        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("El codigo es :" + this.mCodMateria);
            this.txtCodigo.Text = mCodMateria;
            ProyectoMaterias.Materias p = new ProyectoMaterias.Materias();

            p = ProyectoMaterias.MateriasDAO.GetPersona(mCodMateria);

            //cargar datos en los cuadros de texto
            this.txtCodigo.Text = p.codMaterias;
            this.txtNombre.Text = p.nombreMateria;
            this.cmbNivel.Text = p.nivel.ToString();
            this.cmbCarrera.Text = p.carrera;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {


        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonGuardar_Click(object sender, EventArgs e)
        {
            if (this.mCodMateria.Length > 0)

            {
                ProyectoMaterias.Materias persona = new ProyectoMaterias.Materias();
                persona.codMaterias = mCodMateria;
                persona.codMaterias = this.txtCodigo.Text;
                persona.nombreMateria = this.txtNombre.Text;
                persona.nivel = int.Parse(this.cmbNivel.Text);
                persona.carrera = this.cmbCarrera.Text;


                int x = ProyectoMaterias.MateriasDAO.actualizar(persona);

                if (x > 0)
                {

                    MessageBox.Show("Registro Aactualizar con exito!");
                }

                else
                    MessageBox.Show("No se pudo actualizar el registro!");
            }
        }
    }
}
