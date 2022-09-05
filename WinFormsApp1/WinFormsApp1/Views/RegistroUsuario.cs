using Krypton.Toolkit;
using AppUsuario.PL.ConfigControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidad;
using Negocio;
using AppUsuario.PL.Views;
using System.Text.RegularExpressions;

namespace WinFormsApp1
{
    public partial class RegistroUsuario : KryptonForm
    {
        Usuario us = new Usuario();
        UsuarioNegocio un = new UsuarioNegocio();

        public RegistroUsuario()
        {
            InitializeComponent();

            LabelConfig lbl = new LabelConfig();
            lbl.lblTitulo(lblTitulo);
            lbl.lblRegistro(lblNombre);
            lbl.lblRegistro(lblApellido);
            lbl.lblRegistro(lblDni);
            lbl.lblRegistro(lblCorreo);
            lbl.lblRegistro(lblContraseña);
            lbl.lblRegistro(lblCelular);

            TexBoxConfig txt = new TexBoxConfig();
            txt.ConfigureControl(txtNombre);
            this.Shown += FocusNombre;
            txt.ConfigureControl(txtApellido);
            txt.ConfigureControl(txtDni);
            txt.ConfigureControl(txtCorreo);
            txt.ConfigureControl(txtContrasenia);
            txtContrasenia.PasswordChar = '*';
            txt.ConfigureControl(txtCelular);

            BtnConfig btn = new BtnConfig();
            btn.ConfigureControl(btnEnviar);
            btn.BtnSecundario(btnVolver);

        }

        private void FocusNombre(object sender, EventArgs e)
        {
            this.txtNombre.Focus();
        }

        //BoxShadow al form

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }

        //************************

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            
            if (txtNombre.Text.Length < 2 || txtApellido.Text.Length < 2 ||  txtDni.Text.Length < 7 ||  ValidarEmail(txtCorreo.Text) == false || txtCelular.Text.Length < 10 ||  string.IsNullOrEmpty(txtContrasenia.Text))
            {
                KryptonMessageBox.Show("Verifique los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                us.Nombre = txtNombre.Text;
                us.Apellido = txtApellido.Text;
                us.Dni = txtDni.Text;
                us.Correo = txtCorreo.Text;
                us.Contraseña = txtContrasenia.Text;
                us.Celular = txtCelular.Text;

                if (un.VerificarDni(us.Dni))
                {
                    txtDni.StateCommon.Border.Color1 = Color.Red;
                    KryptonMessageBox.Show("El DNI ingresado ya es existente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    txtDni.StateCommon.Border.Color1 = Color.Green;

                    if (un.verificarUsuario(us.Correo) == false)
                    {
                        txtCorreo.StateCommon.Border.Color1 = Color.Green;

                        un.cargarUsuario(us);
                        KryptonMessageBox.Show("Usuario creado con exito, ya puede ingresar", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        Login l = new Login();
                        l.Show();
                    }
                    else
                    {
                        txtCorreo.StateCommon.Border.Color1 = Color.Red;
                        KryptonMessageBox.Show("El Correo ingresado ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public static bool ValidarEmail(string ComprobarEmail)
        {
            string emailFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(ComprobarEmail, emailFormato))
            {
                if (Regex.Replace(ComprobarEmail, emailFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length < 2)
            {
                txtNombre.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtNombre.StateCommon.Border.Color1 = Color.Green;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text.Length < 2)
            {
                txtApellido.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtApellido.StateCommon.Border.Color1 = Color.Green;
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            if (txtDni.Text.Length < 7)
            {
                txtDni.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtDni.StateCommon.Border.Color1 = Color.Green;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (ValidarEmail(txtCorreo.Text)==false)
            {
                txtCorreo.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtCorreo.StateCommon.Border.Color1 = Color.Green;
            }
        }

        private void txtContrasenia_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtContrasenia.Text))
            {
                txtContrasenia.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtContrasenia.StateCommon.Border.Color1 = Color.Green;
            }
        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {
            if (txtCelular.Text.Length < 10)
            {
                txtCelular.StateCommon.Border.Color1 = Color.Red;
            }
            else
            {
                txtCelular.StateCommon.Border.Color1 = Color.Green;
            }
        }
    }
}
