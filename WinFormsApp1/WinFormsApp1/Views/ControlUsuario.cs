using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Krypton.Toolkit;
using Entidad;
using Negocio;
using System.Net;
using AppUsuario.PL.ConfigControls;

namespace AppUsuario.PL.Views
{
    public partial class ControlUsuario : KryptonForm
    {
        Usuario us = new Usuario();
        UsuarioNegocio un = new UsuarioNegocio();
        TexBoxConfig _txt = new TexBoxConfig();
        LabelConfig _lbl = new LabelConfig(); 
        BtnConfig _btn = new BtnConfig();   
        public ControlUsuario()
        {
            
            
            InitializeComponent();

            

            _txt.ConfigureControl(txtNombreEdit);
            _txt.ConfigureControl(txtApellidoEdit);
            _txt.ConfigureControl(txtCorreoEdit);
            _txt.ConfigureControl(txtContraseñaEdit);
            _txt.ConfigureControl(txtCelularEdit);
            _txt.ConfigureControl(txtDniEdit);

            _lbl.lblTitulo(kryptonLabel2);

            _lbl.lblRegistro(kryptonLabel4);
            _lbl.lblRegistro(kryptonLabel5);
            _lbl.lblRegistro(kryptonLabel6);
            _lbl.lblRegistro(kryptonLabel7);
            _lbl.lblRegistro(kryptonLabel8);
            _lbl.lblRegistro(kryptonLabel10);

            _btn.ConfigureControl(btnEditar);
            _btn.ConfigureControl(btnBajaUsuario);


        }

        private void ControlUsuario_Load(object sender, EventArgs e)
        {
            cargarGvUsuario();
            cargarTexbox();
            this.Shown += FocusBtn;
        }

        public void FocusBtn(object sender, EventArgs e)
        {
            this.btnEditar.Focus();
        }

        public void cargarGvUsuario()
        {
            gvUsuarios.DataSource = un.TablaUsuario();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var dni = GetDni();
            us.Dni = txtDniEdit.Text;
            us.Nombre = txtNombreEdit.Text;
            us.Apellido = txtApellidoEdit.Text;
            us.Correo = txtCorreoEdit.Text;
            us.Contraseña = txtContraseñaEdit.Text;
            us.Celular = txtCelularEdit.Text;

            if(un.ModificarDatosUsuarios(dni, us))
            {
                KryptonMessageBox.Show("Datos modificados", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                KryptonMessageBox.Show("El DNI ingresado ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            cargarGvUsuario();

            limpiarTxt();

            cargarTexbox();

        }

        public void limpiarTxt()
        {
            txtNombreEdit.Text = "";
            txtApellidoEdit.Text = "";
            txtContraseñaEdit.Text = "";
            txtCelularEdit.Text = "";
            txtCorreoEdit.Text = "";
        }

        private void btnBajaUsuario_Click(object sender, EventArgs e)
        {
            KryptonMessageBox.Show("Usuario eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            string dni = GetDni();
            un.eliminarUsuario(dni);
            cargarGvUsuario();
            cargarTexbox();
        }

        private string GetDni()
        {
            try
            {
                return gvUsuarios.Rows[gvUsuarios.CurrentRow.Index].Cells[0].Value.ToString();
            }
            catch(Exception ex)
            {
                KryptonMessageBox.Show("Usuario eliminado: "+ex.Message, "Exito", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return null;
            }
        }

        private void gvUsuarios_Click(object sender, EventArgs e)
        {
            cargarTexbox();
        }

        public void cargarTexbox()
        {
            var dni = GetDni();
            txtDniEdit.Text = dni;
            txtNombreEdit.Text = un.buscarNombre(dni);
            txtApellidoEdit.Text = un.buscarApellido(dni);
            txtContraseñaEdit.Text = un.buscarContraseña(dni);
            txtCorreoEdit.Text = un.buscarCorreo(dni);
            txtCelularEdit.Text = un.buscarCelular(dni);
        }
    }
}
