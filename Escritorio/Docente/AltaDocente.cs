using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Escritorio
{
    public partial class AltaDocente : Form
    {
        Personas p = new Personas();
        ControladorDocentes cd = new ControladorDocentes();
        public AltaDocente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Plan plan = new Plan();
            ControladorPlanes cp = new ControladorPlanes();
            ControladorDocentes cd = new ControladorDocentes();
            plan = (Plan)cbPlanes.SelectedItem;
            p.Plan = plan;
            p.Apellido = textApellidoDocente.Text;
            p.Nombre = textNombreDocente.Text;
            p.Direccion = textDireccionDocente.Text;
            p.Telefono = textTelefonoDocente.Text;
            p.Email = textMailDocente.Text;
            p.FechaNacimiento = DateTime.Parse(dTPFechaNacimiendoDocente.Text);
            p.Legajo = Convert.ToInt32(textLegajoDocente.Text);
            cd.agregarDocente(p);
            MessageBox.Show("Docente Ingresado Correctamente");
            this.Close();

            //modificar
            //  p.TipoPersona = new TipoPersona(1, "Usuario");
        }

        private void seleccionarPlan_Click(object sender, EventArgs e)
        {
            Escritorio.ListarPlanes f = new ListarPlanes();
            f.ShowDialog(this);
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void gbOpciones_Enter(object sender, EventArgs e)
        { 
            
        }

        private void agregar_CheckedChanged(object sender, EventArgs e)
        {
            btnAgregarUsuario.Show();
            btnEliminar.Hide();
            btnModificar.Hide();
        }

        private void cbmodificar_CheckedChanged(object sender, EventArgs e)
        {
            btnModificar.Show();
            btnAgregarUsuario.Hide();
            btnEliminar.Hide();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           

        }

        private void cbeliminar_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminar.Show();
            btnAgregarUsuario.Hide();
            btnModificar.Hide();
        }

        private void cbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
