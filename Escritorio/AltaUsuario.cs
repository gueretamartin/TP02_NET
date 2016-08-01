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
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textNombreUsuario.Clear();
            textApellido.Clear();
            textMail.Clear();
            textNombre.Clear();
            textPassword.Clear();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            ControladorUsuario cu = new ControladorUsuario();
            Usuario usu = new Usuario();
            usu.NombreUsuario = textNombreUsuario.Text;
            usu.Nombre = textNombre.Text;
            usu.Apellido = textApellido.Text;
            usu.Email = textMail.Text;
            usu.Clave = textPassword.Text;
            usu.Habilitado = true;
            usu.State = Entidades.BusinessEntity.States.New;
         //   cu.guardarUsuario(usu);
      }
    }
}
