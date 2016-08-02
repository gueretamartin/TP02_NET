namespace Escritorio
{
    partial class ListarPlanes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.DGPlanes = new System.Windows.Forms.DataGridView();
            this.id_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_plan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controladorUsuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.controladorUsuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorUsuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorUsuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutPanel1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(617, 406);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(-1, -2);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(617, 431);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_TopToolStripPanel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnActualizar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DGPlanes, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 348);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnActualizar.Location = new System.Drawing.Point(458, 322);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(539, 322);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // DGPlanes
            // 
            this.DGPlanes.AllowUserToAddRows = false;
            this.DGPlanes.AllowUserToDeleteRows = false;
            this.DGPlanes.AutoGenerateColumns = false;
            this.DGPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGPlanes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_plan,
            this.desc_plan,
            this.Especialidad,
            this.ESTADO});
            this.tableLayoutPanel1.SetColumnSpan(this.DGPlanes, 2);
            this.DGPlanes.DataSource = this.controladorUsuarioBindingSource1;
            this.DGPlanes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPlanes.Location = new System.Drawing.Point(3, 3);
            this.DGPlanes.Name = "DGPlanes";
            this.DGPlanes.ReadOnly = true;
            this.DGPlanes.Size = new System.Drawing.Size(611, 313);
            this.DGPlanes.TabIndex = 3;
           
            // 
            // id_plan
            // 
            this.id_plan.DataPropertyName = "Id";
            this.id_plan.HeaderText = "ID PLAN";
            this.id_plan.Name = "id_plan";
            this.id_plan.ReadOnly = true;
            // 
            // desc_plan
            // 
            this.desc_plan.DataPropertyName = "descripcionPlan";
            this.desc_plan.HeaderText = "DESCRIPCION";
            this.desc_plan.Name = "desc_plan";
            this.desc_plan.ReadOnly = true;
            // 
            // Especialidad
            // 
            this.Especialidad.DataPropertyName = "Entidades.Especialidad.descripcionEspecialidad";
            this.Especialidad.HeaderText = "ESPECIALIDAD";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            // 
            // ESTADO
            // 
            this.ESTADO.DataPropertyName = "State";
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            // 
            // controladorUsuarioBindingSource1
            // 
            this.controladorUsuarioBindingSource1.DataSource = typeof(Negocio.ControladorUsuario);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Location = new System.Drawing.Point(3, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(111, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // controladorUsuarioBindingSource
            // 
            this.controladorUsuarioBindingSource.DataSource = typeof(Negocio.ControladorUsuario);
            // 
            // ListarPlanes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 429);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "ListarPlanes";
            this.Text = "Planes";
            this.Load += new System.EventHandler(this.ListarPlanes_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorUsuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controladorUsuarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.BindingSource controladorUsuarioBindingSource;
        private System.Windows.Forms.DataGridView DGPlanes;
        private System.Windows.Forms.BindingSource controladorUsuarioBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_plan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
    }
}