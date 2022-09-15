namespace WinFormsApp1
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lblTitulo = new Krypton.Toolkit.KryptonLabel();
            this.lblSubTitulo = new Krypton.Toolkit.KryptonLabel();
            this.txtCorreoLogin = new Krypton.Toolkit.KryptonTextBox();
            this.txtContraseñaLogin = new Krypton.Toolkit.KryptonTextBox();
            this.btnIngresar = new Krypton.Toolkit.KryptonButton();
            this.btnRegistro = new Krypton.Toolkit.KryptonButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSpecAny1 = new Krypton.Toolkit.ButtonSpecAny();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.lblCorreo = new Krypton.Toolkit.KryptonLabel();
            this.lblContraseña = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Location = new System.Drawing.Point(32, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 24);
            this.lblTitulo.TabIndex = 11;
            this.lblTitulo.Values.Text = "Login a la app";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.Location = new System.Drawing.Point(32, 77);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(151, 24);
            this.lblSubTitulo.TabIndex = 10;
            this.lblSubTitulo.Values.Text = "Bienvenido a mi app ";
            // 
            // txtCorreoLogin
            // 
            this.txtCorreoLogin.Location = new System.Drawing.Point(37, 185);
            this.txtCorreoLogin.Name = "txtCorreoLogin";
            this.txtCorreoLogin.Size = new System.Drawing.Size(400, 27);
            this.txtCorreoLogin.TabIndex = 9;
            // 
            // txtContraseñaLogin
            // 
            this.txtContraseñaLogin.Location = new System.Drawing.Point(37, 276);
            this.txtContraseñaLogin.Name = "txtContraseñaLogin";
            this.txtContraseñaLogin.Size = new System.Drawing.Size(400, 27);
            this.txtContraseñaLogin.TabIndex = 9;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(32, 369);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(90, 25);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Values.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(256, 369);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(90, 25);
            this.btnRegistro.TabIndex = 7;
            this.btnRegistro.Values.Text = "Regístrese";
            this.btnRegistro.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 344);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSpecAny1
            // 
            this.buttonSpecAny1.AllowInheritExtraText = false;
            this.buttonSpecAny1.ColorMap = System.Drawing.Color.Red;
            this.buttonSpecAny1.UniqueName = "ac0fa18195b54ef3b650405910d3e74e";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(37, 147);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel3.TabIndex = 6;
            this.kryptonLabel3.Values.Text = "";
            // 
            // lblCorreo
            // 
            this.lblCorreo.Location = new System.Drawing.Point(37, 155);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(129, 24);
            this.lblCorreo.TabIndex = 1;
            this.lblCorreo.Values.Text = "Ingrese su correo";
            // 
            // lblContraseña
            // 
            this.lblContraseña.Location = new System.Drawing.Point(37, 249);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(160, 24);
            this.lblContraseña.TabIndex = 0;
            this.lblContraseña.Values.Text = "Ingrese su contraseña";
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.ButtonSpecs.FormClose.ColorMap = System.Drawing.Color.Black;
            this.kryptonPalette1.ButtonSpecs.FormClose.ExtraText = "hoola";
            this.kryptonPalette1.ButtonSpecs.FormClose.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ButtonSpecs.AddRange(new Krypton.Toolkit.ButtonSpecAny[] {
            this.buttonSpecAny1});
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContraseñaLogin);
            this.Controls.Add(this.txtCorreoLogin);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.PaletteMode = Krypton.Toolkit.PaletteMode.Office365Black;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.None;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Header.ButtonEdgeInset = 10;
            this.StateCommon.Header.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.Gray;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel lblTitulo;
        private Krypton.Toolkit.KryptonLabel lblSubTitulo;
        private Krypton.Toolkit.KryptonTextBox txtCorreoLogin;
        private Krypton.Toolkit.KryptonTextBox txtContraseñaLogin;
        private Krypton.Toolkit.KryptonButton btnIngresar;
        private Krypton.Toolkit.KryptonButton btnRegistro;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.ButtonSpecAny buttonSpecAny1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel lblCorreo;
        private Krypton.Toolkit.KryptonLabel lblContraseña;
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
    }
}