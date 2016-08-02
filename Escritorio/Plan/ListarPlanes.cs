using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Escritorio
{
    public partial class ListarPlanes : Form
    {
        
        public ListarPlanes()
        {
            InitializeComponent();
        }


      
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

       

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListarPlanes_Load(object sender, EventArgs e)
        {
           
            this.DGPlanes.Rows.Clear();
            this. DGPlanes.Refresh();
            this.DGPlanes.AutoGenerateColumns = false;
            List<Plan> planes = new List<Plan>();
            planes = new ControladorPlanes().getAllPlanes();
            this.DGPlanes.DataSource = planes;
            int cantidad = planes.Count;
            //Para llenar la columna especialidades, porque no me deja de otra forma
            for (int i = 0; i < cantidad; i++)
            {
                this.DGPlanes.Rows[i].Cells[2].Value = planes[i].Especialidad.DescripcionEspecialidad;

            }



        }
       
    }
}
