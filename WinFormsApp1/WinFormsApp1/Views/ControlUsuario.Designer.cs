namespace AppUsuario.PL.Views
{
    partial class ControlUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlUsuario));
            this.gvUsuarios = new System.Windows.Forms.DataGridView();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.txtContraseñaEdit = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.txtApellidoEdit = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.txtCorreoEdit = new Krypton.Toolkit.KryptonTextBox();
            this.btnEditar = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.txtCelularEdit = new Krypton.Toolkit.KryptonTextBox();
            this.btnBajaUsuario = new Krypton.Toolkit.KryptonButton();
            this.txtNombreEdit = new Krypton.Toolkit.KryptonTextBox();
            this.txtDniEdit = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.gvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuarios.Location = new System.Drawing.Point(147, 12);
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.RowHeadersWidth = 51;
            this.gvUsuarios.RowTemplate.Height = 29;
            this.gvUsuarios.Size = new System.Drawing.Size(828, 167);
            this.gvUsuarios.TabIndex = 4;
            this.gvUsuarios.Click += new System.EventHandler(this.gvUsuarios_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1029, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(396, 211);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(194, 24);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Edite / elimine los usuarios";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(203, 278);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Nombre";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(365, 278);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(89, 24);
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "Contraseña";
            // 
            // txtContraseñaEdit
            // 
            this.txtContraseñaEdit.Location = new System.Drawing.Point(350, 321);
            this.txtContraseñaEdit.Name = "txtContraseñaEdit";
            this.txtContraseñaEdit.Size = new System.Drawing.Size(125, 27);
            this.txtContraseñaEdit.TabIndex = 15;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(531, 278);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel6.TabIndex = 18;
            this.kryptonLabel6.Values.Text = "Apellido";
            // 
            // txtApellidoEdit
            // 
            this.txtApellidoEdit.Location = new System.Drawing.Point(510, 321);
            this.txtApellidoEdit.Name = "txtApellidoEdit";
            this.txtApellidoEdit.Size = new System.Drawing.Size(125, 27);
            this.txtApellidoEdit.TabIndex = 17;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(722, 278);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(58, 24);
            this.kryptonLabel7.TabIndex = 20;
            this.kryptonLabel7.Values.Text = "Correo";
            // 
            // txtCorreoEdit
            // 
            this.txtCorreoEdit.Location = new System.Drawing.Point(670, 321);
            this.txtCorreoEdit.Name = "txtCorreoEdit";
            this.txtCorreoEdit.Size = new System.Drawing.Size(166, 27);
            this.txtCorreoEdit.TabIndex = 19;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(322, 391);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 31);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(893, 278);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(59, 24);
            this.kryptonLabel8.TabIndex = 23;
            this.kryptonLabel8.Values.Text = "Celular";
            // 
            // txtCelularEdit
            // 
            this.txtCelularEdit.Location = new System.Drawing.Point(860, 322);
            this.txtCelularEdit.Name = "txtCelularEdit";
            this.txtCelularEdit.Size = new System.Drawing.Size(125, 27);
            this.txtCelularEdit.TabIndex = 22;
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Location = new System.Drawing.Point(581, 391);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(112, 31);
            this.btnBajaUsuario.TabIndex = 27;
            this.btnBajaUsuario.Values.Text = "Eliminar";
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // txtNombreEdit
            // 
            this.txtNombreEdit.Location = new System.Drawing.Point(181, 322);
            this.txtNombreEdit.Name = "txtNombreEdit";
            this.txtNombreEdit.Size = new System.Drawing.Size(125, 27);
            this.txtNombreEdit.TabIndex = 31;
            // 
            // txtDniEdit
            // 
            this.txtDniEdit.Location = new System.Drawing.Point(18, 322);
            this.txtDniEdit.Name = "txtDniEdit";
            this.txtDniEdit.Size = new System.Drawing.Size(125, 27);
            this.txtDniEdit.TabIndex = 32;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(60, 278);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(38, 24);
            this.kryptonLabel10.TabIndex = 33;
            this.kryptonLabel10.Values.Text = "DNI";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(238, 194);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel11.TabIndex = 34;
            this.kryptonLabel11.Values.Text = "";
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 452);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.txtDniEdit);
            this.Controls.Add(this.txtNombreEdit);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.txtCelularEdit);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.txtCorreoEdit);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.txtApellidoEdit);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.txtContraseñaEdit);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ControlUsuario";
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
            this.Text = "Control de usuario";
            this.Load += new System.EventHandler(this.ControlUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView gvUsuarios;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonTextBox txtContraseñaEdit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonTextBox txtApellidoEdit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonTextBox txtCorreoEdit;
        private Krypton.Toolkit.KryptonButton btnEditar;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonTextBox txtCelularEdit;
        private Krypton.Toolkit.KryptonButton btnBajaUsuario;
        private Krypton.Toolkit.KryptonTextBox txtNombreEdit;
        private Krypton.Toolkit.KryptonTextBox txtDniEdit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
    }
}