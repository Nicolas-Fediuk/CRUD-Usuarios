using Krypton.Toolkit;
using AppUsuario.PL.ConfigControls;
using Entidad;
using AppUsuario.PL.Views;
using Negocio;

namespace WinFormsApp1
{
    public partial class Login : KryptonForm
    {
        Usuario us = new Usuario();
        UsuarioNegocio un = new UsuarioNegocio();
        public Login()
        {

            InitializeComponent();
            
            TexBoxConfig textConfig = new TexBoxConfig();
            textConfig.ConfigureControl(txtCorreoLogin);
            this.Shown += FocusCorreo;
            textConfig.ConfigureControl(txtContrase�aLogin);
            txtContrase�aLogin.PasswordChar = '*';

            LabelConfig lblConfig = new LabelConfig();
            lblConfig.ConfigureControl(lblSubTitulo); 
            lblConfig.ConfigureControl(lblCorreo);
            lblConfig.ConfigureControl(lblContrase�a);
            lblConfig.lblTitulo(lblTitulo);

            BtnConfig btnConfig = new BtnConfig();
            btnConfig.ConfigureControl(btnIngresar);
            btnConfig.BtnSecundario(btnRegistro);
        }
        private void FocusCorreo(object sender, EventArgs e)
        {
            this.txtCorreoLogin.Focus();
        }


        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            RegistroUsuario registro = new RegistroUsuario();

            //no me deja interactuar con el form anterior
            //registro.ShowDialog();

            //esta si
            registro.Show();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            us.Contrase�a = txtContrase�aLogin.Text;
            us.Correo = txtCorreoLogin.Text;

            if (un.verificarUsuario(txtCorreoLogin.Text))
            {
                txtCorreoLogin.StateCommon.Border.Color1 = Color.Green;
            }
            else
            {
                txtCorreoLogin.StateCommon.Border.Color1 = Color.Red;
            }

            if (un.verificarContrase�a(txtContrase�aLogin.Text))
            {
                txtContrase�aLogin.StateCommon.Border.Color1 = Color.Green;
            }
            else
            {
                txtContrase�aLogin.StateCommon.Border.Color1 = Color.Red;
            }

            if (un.ExisteUsuario(us))
            {
                ControlUsuario control = new ControlUsuario();
                control.Show();
            }
            
               
        }

    }
}