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
    public partial class frmMostrarMaterias : Form
    {
        public frmMostrarMaterias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            
        }

        private void cargarGrid()
        {
            this.dtListado.DataSource = ProyectoMaterias.MateriasDAO.getAll();

        }
        public void dtListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtListado.Columns[e.ColumnIndex].Name=="linkEliminar")
            {
             
                int fila = e.RowIndex;
                String codMaterias = dtListado["codMaterias", fila].Value.ToString();
                String nombreMateria = dtListado["nombreMateria", fila].Value.ToString();

                

                DialogResult dr = MessageBox.Show("ESTAS SEGURO DE ELIMINAR LA MATERIA, "+ nombreMateria + " ?", "CONFIRME", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(dr==DialogResult.No)
                {
                    return;
                }

                int x = ProyectoMaterias.MateriasDAO.eliminar(codMaterias);
                if (x > 0)
                {
                    MessageBox.Show("Registro borrado con exito...");
                }
                else
                    MessageBox.Show("NO SE PUDO BORRAR");
            }
            else if (this.dtListado.Columns[e.ColumnIndex].Name == "linkActualizar")
            {
                int fila = e.RowIndex;
                String codMaterias = dtListado["codMaterias", fila].Value.ToString();

                //MessageBox.Show("clic actualizar");
                frmActualizar frm1 = new frmActualizar(codMaterias);
                frm1.ShowDialog();
                cargarGrid();
            }

        }
      
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMostrarMaterias_Load(object sender, EventArgs e)
        {

        }
    }
}
