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
            this.cbUsuario = new Krypton.Toolkit.KryptonComboBox();
            this.txtNombre = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
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
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.cbBajaUsuario = new Krypton.Toolkit.KryptonComboBox();
            this.btnBajaUsuario = new Krypton.Toolkit.KryptonButton();
            this.lblBajaUsuario = new Krypton.Toolkit.KryptonLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtNombreEdit = new Krypton.Toolkit.KryptonTextBox();
            this.txtDniEdit = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel13 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBajaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // gvUsuarios
            // 
            this.gvUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.gvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsuarios.Location = new System.Drawing.Point(332, 12);
            this.gvUsuarios.Name = "gvUsuarios";
            this.gvUsuarios.RowHeadersWidth = 51;
            this.gvUsuarios.RowTemplate.Height = 29;
            this.gvUsuarios.Size = new System.Drawing.Size(828, 167);
            this.gvUsuarios.TabIndex = 4;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // cbUsuario
            // 
            this.cbUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbUsuario.DropDownWidth = 202;
            this.cbUsuario.IntegralHeight = false;
            this.cbUsuario.Location = new System.Drawing.Point(13, 337);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(202, 25);
            this.cbUsuario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbUsuario.TabIndex = 5;
            this.cbUsuario.SelectedIndexChanged += new System.EventHandler(this.cbUsuario_SelectedIndexChanged);
            this.cbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbUsuario_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(239, 338);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(68, 24);
            this.txtNombre.TabIndex = 6;
            this.txtNombre.Values.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1376, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldControl;
            this.kryptonLabel1.Location = new System.Drawing.Point(45, 294);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(127, 24);
            this.kryptonLabel1.TabIndex = 30;
            this.kryptonLabel1.Values.Text = "Busque por DNI";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 477);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1376, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(774, 227);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(191, 24);
            this.kryptonLabel2.TabIndex = 10;
            this.kryptonLabel2.Values.Text = "Edite los datos del usuario";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(569, 294);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel4.TabIndex = 14;
            this.kryptonLabel4.Values.Text = "Nombre";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(731, 294);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(89, 24);
            this.kryptonLabel5.TabIndex = 16;
            this.kryptonLabel5.Values.Text = "Contraseña";
            // 
            // txtContraseñaEdit
            // 
            this.txtContraseñaEdit.Location = new System.Drawing.Point(716, 337);
            this.txtContraseñaEdit.Name = "txtContraseñaEdit";
            this.txtContraseñaEdit.Size = new System.Drawing.Size(125, 27);
            this.txtContraseñaEdit.TabIndex = 15;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(897, 294);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(68, 24);
            this.kryptonLabel6.TabIndex = 18;
            this.kryptonLabel6.Values.Text = "Apellido";
            // 
            // txtApellidoEdit
            // 
            this.txtApellidoEdit.Location = new System.Drawing.Point(876, 337);
            this.txtApellidoEdit.Name = "txtApellidoEdit";
            this.txtApellidoEdit.Size = new System.Drawing.Size(125, 27);
            this.txtApellidoEdit.TabIndex = 17;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(1088, 294);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(58, 24);
            this.kryptonLabel7.TabIndex = 20;
            this.kryptonLabel7.Values.Text = "Correo";
            // 
            // txtCorreoEdit
            // 
            this.txtCorreoEdit.Location = new System.Drawing.Point(1036, 337);
            this.txtCorreoEdit.Name = "txtCorreoEdit";
            this.txtCorreoEdit.Size = new System.Drawing.Size(166, 27);
            this.txtCorreoEdit.TabIndex = 19;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(818, 407);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(112, 31);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Values.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(1259, 294);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(59, 24);
            this.kryptonLabel8.TabIndex = 23;
            this.kryptonLabel8.Values.Text = "Celular";
            // 
            // txtCelularEdit
            // 
            this.txtCelularEdit.Location = new System.Drawing.Point(1226, 338);
            this.txtCelularEdit.Name = "txtCelularEdit";
            this.txtCelularEdit.Size = new System.Drawing.Size(125, 27);
            this.txtCelularEdit.TabIndex = 22;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(796, 531);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(137, 24);
            this.kryptonLabel3.TabIndex = 24;
            this.kryptonLabel3.Values.Text = "Elimine un usuario";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(619, 628);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(120, 24);
            this.kryptonLabel9.TabIndex = 25;
            this.kryptonLabel9.Values.Text = "Busque por DNI";
            // 
            // cbBajaUsuario
            // 
            this.cbBajaUsuario.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbBajaUsuario.DropDownWidth = 151;
            this.cbBajaUsuario.IntegralHeight = false;
            this.cbBajaUsuario.Location = new System.Drawing.Point(609, 683);
            this.cbBajaUsuario.Name = "cbBajaUsuario";
            this.cbBajaUsuario.Size = new System.Drawing.Size(151, 25);
            this.cbBajaUsuario.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.cbBajaUsuario.TabIndex = 26;
            this.cbBajaUsuario.SelectedIndexChanged += new System.EventHandler(this.cbBajaUsuario_SelectedIndexChanged);
            this.cbBajaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbBajaUsuario_KeyPress);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Location = new System.Drawing.Point(987, 677);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(112, 31);
            this.btnBajaUsuario.TabIndex = 27;
            this.btnBajaUsuario.Values.Text = "Eliminar";
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // lblBajaUsuario
            // 
            this.lblBajaUsuario.Location = new System.Drawing.Point(796, 684);
            this.lblBajaUsuario.Name = "lblBajaUsuario";
            this.lblBajaUsuario.Size = new System.Drawing.Size(68, 24);
            this.lblBajaUsuario.TabIndex = 28;
            this.lblBajaUsuario.Values.Text = "Nombre";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(55, 531);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(377, 257);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 29;
            this.pictureBox3.TabStop = false;
            // 
            // txtNombreEdit
            // 
            this.txtNombreEdit.Location = new System.Drawing.Point(547, 338);
            this.txtNombreEdit.Name = "txtNombreEdit";
            this.txtNombreEdit.Size = new System.Drawing.Size(125, 27);
            this.txtNombreEdit.TabIndex = 31;
            // 
            // txtDniEdit
            // 
            this.txtDniEdit.Location = new System.Drawing.Point(384, 338);
            this.txtDniEdit.Name = "txtDniEdit";
            this.txtDniEdit.Size = new System.Drawing.Size(125, 27);
            this.txtDniEdit.TabIndex = 32;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(426, 294);
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
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(174, 227);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(290, 24);
            this.kryptonLabel12.TabIndex = 35;
            this.kryptonLabel12.Values.Text = "Elija primero el DNI de la lista para editar";
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Location = new System.Drawing.Point(438, 531);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(305, 24);
            this.kryptonLabel13.TabIndex = 36;
            this.kryptonLabel13.Values.Text = "Elija primero el DNI de la lista para eliminar";
            // 
            // ControlUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.kryptonLabel13);
            this.Controls.Add(this.kryptonLabel12);
            this.Controls.Add(this.kryptonLabel11);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.txtDniEdit);
            this.Controls.Add(this.txtNombreEdit);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblBajaUsuario);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.cbBajaUsuario);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.kryptonLabel3);
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cbUsuario);
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
            ((System.ComponentModel.ISupportInitialize)(this.cbUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbBajaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DataGridView gvUsuarios;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Krypton.Toolkit.KryptonComboBox cbUsuario;
        private Krypton.Toolkit.KryptonLabel txtNombre;
        private PictureBox pictureBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private PictureBox pictureBox2;
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
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonComboBox cbBajaUsuario;
        private Krypton.Toolkit.KryptonButton btnBajaUsuario;
        private Krypton.Toolkit.KryptonLabel lblBajaUsuario;
        private PictureBox pictureBox3;
        private Krypton.Toolkit.KryptonTextBox txtNombreEdit;
        private Krypton.Toolkit.KryptonTextBox txtDniEdit;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel13;
    }
}