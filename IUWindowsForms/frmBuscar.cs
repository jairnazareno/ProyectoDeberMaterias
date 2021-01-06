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
    public partial class frmBuscar : Form
    {
        public frmBuscar()
        {
            InitializeComponent();
        }

        private void cargarComboEstudiantes()
        {
            this.cmbCodigo.DataSource = ProyectoMaterias.MateriasDAO.getAll();
            this.cmbCodigo.DisplayMember = "codMaterias";
            this.cmbCodigo.ValueMember = "nombreMateria";
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codMaterias = this.cmbCodigo.SelectedValue.ToString();

            ProyectoMaterias.Materias p = new ProyectoMaterias.Materias();
            p = ProyectoMaterias.MateriasDAO.GetPersona(codMaterias);

            //cargar datos en los cuadros de texto
            this.txtCodigo.Text = p.codMaterias;
            this.txtNombre.Text = p.nombreMateria;
            this.cmbNivel.Text = p.nivel.ToString();
            this.cmbCarrera.Text = p.carrera;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            /*
            if (this.txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("No hay cedula seleccionada");
                return;
            }
            ProyectoMaterias.Materias persona = new CapaDatos.Persona();
            persona.Cedula = this.txtCedula.Text;
            persona.Apellidos = this.txtApellidos.Text;
            persona.Nombres = this.txtNombres.Text;
            persona.Sexo = this.cmbSexo.Text;
            persona.Correo = this.txtCorreo.Text;
            persona.Estatura = int.Parse(this.txtEstatura.Text);
            persona.Peso = decimal.Parse(this.txtPeso.Text);
            persona.FechaNacimiento = dtFechaNacimiento.Value;


            int x = CapaDatos.PersonaDAO.actualizar(persona);

            if (x > 0)
            {
                this.cargarComboEstudiantes();
                MessageBox.Show("Registro Aactualizar con exito!");
            }

            else
                MessageBox.Show("No se pudo actualizar el registro!");*/
        }

    }
    }
