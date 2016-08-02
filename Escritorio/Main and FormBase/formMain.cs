using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void formMain_Shown(object sender, EventArgs e)
        {
            formLogin appLogin = new formLogin();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }

        private void aBMUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escritorio.AltaUsuario form = new Escritorio.AltaUsuario();
            form.Show();
        }

        private void formMain_Load(object sender, EventArgs e)
        {

        }

        private void docentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escritorio.AltaDocente form = new Escritorio.AltaDocente();
            form.Show();
        }

        private void mnsPrincipal_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void inscripcionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escritorio.AltaInscripcion form = new Escritorio.AltaInscripcion();
            form.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Escritorio.ListarPlanes form = new Escritorio.ListarPlanes();
            form.Show();
        }
    }
}

