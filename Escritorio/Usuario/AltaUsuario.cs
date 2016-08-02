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
using Escritorio;
using Escritorio.Main_and_FormBase;

namespace Escritorio
{
    public partial class AltaUsuario : FormBase
    {
        #region Variables
        private Usuario usuarioActual;
        bool est = false;
       
        #endregion
        
        #region Propiedades
        public Usuario UsuarioActual
        {
            get { return usuarioActual; }
            set { usuarioActual = value; }
        }
        #endregion

        #region Constructores
        
        public AltaUsuario()
        {
            InitializeComponent();
        }

        public AltaUsuario(ModoForm modo) : this()
        {
            this.Modo = modo;
        }

        public AltaUsuario(int Id, ModoForm modo)
            : this()
        {
            this.Modo = modo;
            UsuarioActual = new ControladorUsuario().GetUsuario(Id);
            MapearDeDatos();
            switch (modo)
            {
                case (ModoForm.Alta):
                    this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Modificacion):
                    this.btnAceptar.Text = "Guardar";
                    break;
                case (ModoForm.Baja):
                    this.btnAceptar.Text = "Eliminar";
                    break;
                case (ModoForm.Consulta):
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }
        }
        #endregion

        #region Metodos

        public virtual void MapearDeDatos() {
            this.textApellido.Text = this.UsuarioActual.Apellido;
            this.textNombre.Text = this.UsuarioActual.Nombre;
            this.textId.Text = this.UsuarioActual.Id.ToString();
            this.textNombreUsuario.Text = this.UsuarioActual.NombreUsuario;
            //this.cmbPersonas.SelectedItem = this.UsuarioActual.Per.ApeNom();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.textPassword.Text = this.UsuarioActual.Clave;
            // this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            this.textMail.Text = this.UsuarioActual.Email;
        }

        public virtual void GuardarCambios() {
            try
            {
                MapearADatos();
                new ControladorUsuario().GuardarUsuario(UsuarioActual);
            }
            catch (Exception ex)
            {
                //ErrorEliminar miExcep = new ErrorEliminar("No se puede eliminar la inscripción.");
                Notificar("Error", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public virtual void MapearADatos() {

            Personas personaActual = this.ObtenerPersona();
            switch (this.Modo)
            {
                case (ModoForm.Alta):
                    {
                        UsuarioActual = new Usuario();
                        this.UsuarioActual.Persona = personaActual;
                        this.UsuarioActual.Apellido = personaActual.Apellido;
                        this.UsuarioActual.Nombre = personaActual.Nombre;
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Clave = this.textPassword.Text;
                        this.UsuarioActual.Email = this.textMail.Text;
                        this.UsuarioActual.NombreUsuario = this.textNombreUsuario.Text;
                        this.UsuarioActual.State = BusinessEntity.States.New;
                        break;
                    }
                case (ModoForm.Modificacion):
                    {
                        this.UsuarioActual.Apellido = personaActual.Apellido;
                        this.UsuarioActual.Nombre = personaActual.Nombre;
                        this.UsuarioActual.Persona = personaActual;
                        this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                        this.UsuarioActual.Clave = this.textPassword.Text;
                        this.UsuarioActual.Email = this.textMail.Text;
                        this.UsuarioActual.NombreUsuario = this.textNombreUsuario.Text;
                        this.UsuarioActual.State = BusinessEntity.States.Modified;
                        break;
                    }
                case (ModoForm.Baja):
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Deleted;
                        break;

                    }
                case (ModoForm.Consulta):
                    {
                        this.UsuarioActual.State = BusinessEntity.States.Unmodified;
                        break;
                    }
            }
        }

        private Personas ObtenerPersona()
        {
            return new ControladorPersonas().GetPersona((((Personas)this.cmbPersonas.SelectedValue).Id));
        }

        public virtual bool Validar() { return false; }
        public void Notificar(string titulo, string mensaje, MessageBoxButtons
        botones, MessageBoxIcon icono)
        {
            MessageBox.Show(mensaje, titulo, botones, icono);
        }
        public void Notificar(string mensaje, MessageBoxButtons botones,
        MessageBoxIcon icono)
        {
            this.Notificar(this.Text, mensaje, botones, icono);
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

        private void AltaUsuario_Load(object sender, EventArgs e)
        {
            cmbPersonas.DataSource = new ControladorPersonas().getAllPersonas(); ;

            cmbPersonas.DisplayMember = "nombre";
            cmbPersonas.ValueMember = "id_persona";

        }


        #endregion

    }
}
