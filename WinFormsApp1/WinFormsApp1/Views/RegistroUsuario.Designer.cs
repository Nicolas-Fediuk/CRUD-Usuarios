namespace WinFormsApp1
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.lblTitulo = new Krypton.Toolkit.KryptonLabel();
            this.lblNombre = new Krypton.Toolkit.KryptonLabel();
            this.lblApellido = new Krypton.Toolkit.KryptonLabel();
            this.lblDni = new Krypton.Toolkit.KryptonLabel();
            this.lblCorreo = new Krypton.Toolkit.KryptonLabel();
            this.lblCelular = new Krypton.Toolkit.KryptonLabel();
            this.txtNombre = new Krypton.Toolkit.KryptonTextBox();
            this.btnEnviar = new Krypton.Toolkit.KryptonButton();
            this.btnVolver = new Krypton.Toolkit.KryptonButton();
            this.txtApellido = new Krypton.Toolkit.KryptonTextBox();
            this.txtDni = new Krypton.Toolkit.KryptonTextBox();
            this.txtCorreo = new Krypton.Toolkit.KryptonTextBox();
            this.txtCelular = new Krypton.Toolkit.KryptonTextBox();
            this.txtContrasenia = new Krypton.Toolkit.KryptonTextBox();
            this.lblContraseña = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(275, 12);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(170, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Values.Text = "Regístese para ingresar";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(197, 75);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(68, 24);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Values.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(197, 126);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 24);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Values.Text = "Apellido";
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(197, 176);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(38, 24);
            this.lblDni.TabIndex = 3;
            this.lblDni.Values.Text = "DNI";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(197, 229);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 24);
            this.lblCorreo.TabIndex = 4;
            this.lblCorreo.Values.Text = "Correo electrónico";
            // 
            // lblCelular
            // 
            this.lblCelular.Location = new System.Drawing.Point(197, 331);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(59, 24);
            this.lblCelular.TabIndex = 5;
            this.lblCelular.Values.Text = "Celular";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(430, 72);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(185, 27);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(194, 396);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(112, 31);
            this.btnEnviar.TabIndex = 7;
            this.btnEnviar.Values.Text = "Enviar";
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(430, 396);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(112, 31);
            this.btnVolver.TabIndex = 8;
            this.btnVolver.Values.Text = "Volver";
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(430, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(185, 27);
            this.txtApellido.TabIndex = 9;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(430, 173);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(185, 27);
            this.txtDni.TabIndex = 10;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            this.txtDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDni_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(430, 226);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(185, 27);
            this.txtCorreo.TabIndex = 11;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(430, 328);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(185, 27);
            this.txtCelular.TabIndex = 12;
            this.txtCelular.TextChanged += new System.EventHandler(this.txtCelular_TextChanged);
            this.txtCelular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCelular_KeyPress);
            // 
            // txtContrasenia
            // 
            this.txtContrasenia.Location = new System.Drawing.Point(430, 277);
            this.txtContrasenia.Name = "txtContrasenia";
            this.txtContrasenia.Size = new System.Drawing.Size(185, 27);
            this.txtContrasenia.TabIndex = 14;
            this.txtContrasenia.TextChanged += new System.EventHandler(this.txtContrasenia_TextChanged);
            // 
            // lblContraseña
            // 
            this.lblContraseña.Location = new System.Drawing.Point(197, 280);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(89, 24);
            this.lblContraseña.TabIndex = 13;
            this.lblContraseña.Values.Text = "Contraseña";
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.txtContrasenia);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroUsuario";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.LightGray;
            this.StateCommon.Border.Color2 = System.Drawing.Color.LightGray;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.LightGray;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.LightGray;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.ButtonEdgeInset = 10;
            this.StateCommon.Header.ButtonPadding = new System.Windows.Forms.Padding(0);
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.Text = "Registro de usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel lblNombre;
        private Krypton.Toolkit.KryptonLabel lblApellido;
        private Krypton.Toolkit.KryptonLabel lblDni;
        private Krypton.Toolkit.KryptonLabel lblCorreo;
        private Krypton.Toolkit.KryptonLabel lblCelular;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox3;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox4;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox5;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox6;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox7;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox8;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox9;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox10;
        private Krypton.Toolkit.KryptonButton kryptonButton3;
        private Krypton.Toolkit.KryptonButton kryptonButton4;
        private Krypton.Toolkit.KryptonTextBox txtNombre;
        private Krypton.Toolkit.KryptonButton btnEnviar;
        private Krypton.Toolkit.KryptonButton btnVolver;
        private Krypton.Toolkit.KryptonTextBox txtApellido;
        private Krypton.Toolkit.KryptonTextBox txtDni;
        private Krypton.Toolkit.KryptonTextBox txtCorreo;
        private Krypton.Toolkit.KryptonTextBox txtCelular;
        private Krypton.Toolkit.KryptonTextBox txtContrasenia;
        private Krypton.Toolkit.KryptonLabel lblContraseña;
    }
}