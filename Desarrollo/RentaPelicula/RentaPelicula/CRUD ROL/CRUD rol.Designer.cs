namespace RentaPelicula
{
    partial class CRUD_rol
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRUD_rol));
            this.Pnl_ventana = new System.Windows.Forms.Panel();
            this.Label_roles = new System.Windows.Forms.Label();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Pnl_menu = new System.Windows.Forms.Panel();
            this.Label_cancelar = new System.Windows.Forms.Label();
            this.Label_guardar = new System.Windows.Forms.Label();
            this.Label_modificar = new System.Windows.Forms.Label();
            this.Label_remover = new System.Windows.Forms.Label();
            this.Label_nuevo = new System.Windows.Forms.Label();
            this.Btn_cancelar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_remover = new System.Windows.Forms.Button();
            this.Btn_nuevo = new System.Windows.Forms.Button();
            this.Pnl_reporte = new System.Windows.Forms.Panel();
            this.Tbc_reporte = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Txt_administrador = new System.Windows.Forms.TextBox();
            this.Txt_descricpion = new System.Windows.Forms.TextBox();
            this.Txt_nombre = new System.Windows.Forms.TextBox();
            this.Txt_id = new System.Windows.Forms.TextBox();
            this.Label_administrador = new System.Windows.Forms.Label();
            this.Label_descripcion = new System.Windows.Forms.Label();
            this.Label_nombre = new System.Windows.Forms.Label();
            this.Label_idrol = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Txt_id1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_registro = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pnl_ventana.SuspendLayout();
            this.Pnl_menu.SuspendLayout();
            this.Pnl_reporte.SuspendLayout();
            this.Tbc_reporte.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registro)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_ventana
            // 
            this.Pnl_ventana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.Pnl_ventana.Controls.Add(this.Label_roles);
            this.Pnl_ventana.Controls.Add(this.Btn_ayuda);
            this.Pnl_ventana.Controls.Add(this.Btn_cerrar);
            this.Pnl_ventana.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_ventana.Location = new System.Drawing.Point(0, 0);
            this.Pnl_ventana.Name = "Pnl_ventana";
            this.Pnl_ventana.Size = new System.Drawing.Size(950, 30);
            this.Pnl_ventana.TabIndex = 0;
            // 
            // Label_roles
            // 
            this.Label_roles.AutoSize = true;
            this.Label_roles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_roles.Location = new System.Drawing.Point(78, 6);
            this.Label_roles.Name = "Label_roles";
            this.Label_roles.Size = new System.Drawing.Size(52, 18);
            this.Label_roles.TabIndex = 6;
            this.Label_roles.Text = "Roles";
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_ayuda.BackgroundImage")));
            this.Btn_ayuda.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Location = new System.Drawing.Point(888, 0);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(30, 30);
            this.Btn_ayuda.TabIndex = 2;
            this.Btn_ayuda.UseVisualStyleBackColor = true;
            this.Btn_ayuda.Click += new System.EventHandler(this.Btn_ayuda_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(920, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(30, 30);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Pnl_menu
            // 
            this.Pnl_menu.BackColor = System.Drawing.Color.PeachPuff;
            this.Pnl_menu.Controls.Add(this.Label_cancelar);
            this.Pnl_menu.Controls.Add(this.Label_guardar);
            this.Pnl_menu.Controls.Add(this.Label_modificar);
            this.Pnl_menu.Controls.Add(this.Label_remover);
            this.Pnl_menu.Controls.Add(this.Label_nuevo);
            this.Pnl_menu.Controls.Add(this.Btn_cancelar);
            this.Pnl_menu.Controls.Add(this.Btn_guardar);
            this.Pnl_menu.Controls.Add(this.Btn_modificar);
            this.Pnl_menu.Controls.Add(this.Btn_remover);
            this.Pnl_menu.Controls.Add(this.Btn_nuevo);
            this.Pnl_menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_menu.Location = new System.Drawing.Point(0, 30);
            this.Pnl_menu.Name = "Pnl_menu";
            this.Pnl_menu.Size = new System.Drawing.Size(950, 94);
            this.Pnl_menu.TabIndex = 1;
            this.Pnl_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_menu_Paint);
            // 
            // Label_cancelar
            // 
            this.Label_cancelar.AutoSize = true;
            this.Label_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_cancelar.Location = new System.Drawing.Point(533, 71);
            this.Label_cancelar.Name = "Label_cancelar";
            this.Label_cancelar.Size = new System.Drawing.Size(75, 18);
            this.Label_cancelar.TabIndex = 9;
            this.Label_cancelar.Text = "Cancelar";
            // 
            // Label_guardar
            // 
            this.Label_guardar.AutoSize = true;
            this.Label_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_guardar.Location = new System.Drawing.Point(448, 71);
            this.Label_guardar.Name = "Label_guardar";
            this.Label_guardar.Size = new System.Drawing.Size(69, 18);
            this.Label_guardar.TabIndex = 8;
            this.Label_guardar.Text = "Guardar";
            // 
            // Label_modificar
            // 
            this.Label_modificar.AutoSize = true;
            this.Label_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_modificar.Location = new System.Drawing.Point(353, 71);
            this.Label_modificar.Name = "Label_modificar";
            this.Label_modificar.Size = new System.Drawing.Size(78, 18);
            this.Label_modificar.TabIndex = 7;
            this.Label_modificar.Text = "Modificar";
            // 
            // Label_remover
            // 
            this.Label_remover.AutoSize = true;
            this.Label_remover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_remover.Location = new System.Drawing.Point(271, 71);
            this.Label_remover.Name = "Label_remover";
            this.Label_remover.Size = new System.Drawing.Size(76, 18);
            this.Label_remover.TabIndex = 6;
            this.Label_remover.Text = "Remover";
            // 
            // Label_nuevo
            // 
            this.Label_nuevo.AutoSize = true;
            this.Label_nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_nuevo.Location = new System.Drawing.Point(206, 71);
            this.Label_nuevo.Name = "Label_nuevo";
            this.Label_nuevo.Size = new System.Drawing.Size(56, 18);
            this.Label_nuevo.TabIndex = 5;
            this.Label_nuevo.Text = "Nuevo";
            // 
            // Btn_cancelar
            // 
            this.Btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cancelar.BackgroundImage")));
            this.Btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_cancelar.FlatAppearance.BorderSize = 0;
            this.Btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cancelar.Location = new System.Drawing.Point(545, 18);
            this.Btn_cancelar.Name = "Btn_cancelar";
            this.Btn_cancelar.Size = new System.Drawing.Size(50, 50);
            this.Btn_cancelar.TabIndex = 4;
            this.Btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.BackgroundImage")));
            this.Btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Location = new System.Drawing.Point(456, 18);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(50, 50);
            this.Btn_guardar.TabIndex = 3;
            this.Btn_guardar.UseVisualStyleBackColor = true;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.BackgroundImage")));
            this.Btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Location = new System.Drawing.Point(366, 18);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(50, 50);
            this.Btn_modificar.TabIndex = 2;
            this.Btn_modificar.UseVisualStyleBackColor = true;
            this.Btn_modificar.Click += new System.EventHandler(this.Btn_modificar_Click);
            // 
            // Btn_remover
            // 
            this.Btn_remover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_remover.BackgroundImage")));
            this.Btn_remover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_remover.FlatAppearance.BorderSize = 0;
            this.Btn_remover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_remover.Location = new System.Drawing.Point(284, 18);
            this.Btn_remover.Name = "Btn_remover";
            this.Btn_remover.Size = new System.Drawing.Size(50, 50);
            this.Btn_remover.TabIndex = 1;
            this.Btn_remover.UseVisualStyleBackColor = true;
            this.Btn_remover.Click += new System.EventHandler(this.Btn_remover_Click);
            // 
            // Btn_nuevo
            // 
            this.Btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_nuevo.BackgroundImage")));
            this.Btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Btn_nuevo.FlatAppearance.BorderSize = 0;
            this.Btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevo.Location = new System.Drawing.Point(209, 18);
            this.Btn_nuevo.Name = "Btn_nuevo";
            this.Btn_nuevo.Size = new System.Drawing.Size(50, 50);
            this.Btn_nuevo.TabIndex = 0;
            this.Btn_nuevo.UseVisualStyleBackColor = true;
            this.Btn_nuevo.Click += new System.EventHandler(this.Btn_nuevo_Click);
            // 
            // Pnl_reporte
            // 
            this.Pnl_reporte.BackColor = System.Drawing.Color.PapayaWhip;
            this.Pnl_reporte.Controls.Add(this.Tbc_reporte);
            this.Pnl_reporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pnl_reporte.Location = new System.Drawing.Point(0, 124);
            this.Pnl_reporte.Name = "Pnl_reporte";
            this.Pnl_reporte.Size = new System.Drawing.Size(950, 476);
            this.Pnl_reporte.TabIndex = 2;
            this.Pnl_reporte.Paint += new System.Windows.Forms.PaintEventHandler(this.Pnl_reporte_Paint);
            // 
            // Tbc_reporte
            // 
            this.Tbc_reporte.Controls.Add(this.tabPage1);
            this.Tbc_reporte.Controls.Add(this.tabPage2);
            this.Tbc_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbc_reporte.Location = new System.Drawing.Point(20, 28);
            this.Tbc_reporte.Name = "Tbc_reporte";
            this.Tbc_reporte.SelectedIndex = 0;
            this.Tbc_reporte.Size = new System.Drawing.Size(918, 419);
            this.Tbc_reporte.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Txt_administrador);
            this.tabPage1.Controls.Add(this.Txt_descricpion);
            this.tabPage1.Controls.Add(this.Txt_nombre);
            this.tabPage1.Controls.Add(this.Txt_id);
            this.tabPage1.Controls.Add(this.Label_administrador);
            this.tabPage1.Controls.Add(this.Label_descripcion);
            this.tabPage1.Controls.Add(this.Label_nombre);
            this.tabPage1.Controls.Add(this.Label_idrol);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 388);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Txt_administrador
            // 
            this.Txt_administrador.Location = new System.Drawing.Point(280, 218);
            this.Txt_administrador.Name = "Txt_administrador";
            this.Txt_administrador.Size = new System.Drawing.Size(186, 24);
            this.Txt_administrador.TabIndex = 15;
            // 
            // Txt_descricpion
            // 
            this.Txt_descricpion.Location = new System.Drawing.Point(280, 169);
            this.Txt_descricpion.Name = "Txt_descricpion";
            this.Txt_descricpion.Size = new System.Drawing.Size(186, 24);
            this.Txt_descricpion.TabIndex = 14;
            // 
            // Txt_nombre
            // 
            this.Txt_nombre.Location = new System.Drawing.Point(280, 119);
            this.Txt_nombre.Name = "Txt_nombre";
            this.Txt_nombre.Size = new System.Drawing.Size(186, 24);
            this.Txt_nombre.TabIndex = 13;
            // 
            // Txt_id
            // 
            this.Txt_id.Location = new System.Drawing.Point(280, 70);
            this.Txt_id.Name = "Txt_id";
            this.Txt_id.Size = new System.Drawing.Size(186, 24);
            this.Txt_id.TabIndex = 12;
            // 
            // Label_administrador
            // 
            this.Label_administrador.AutoSize = true;
            this.Label_administrador.Location = new System.Drawing.Point(160, 224);
            this.Label_administrador.Name = "Label_administrador";
            this.Label_administrador.Size = new System.Drawing.Size(112, 18);
            this.Label_administrador.TabIndex = 11;
            this.Label_administrador.Text = "Administrador";
            // 
            // Label_descripcion
            // 
            this.Label_descripcion.AutoSize = true;
            this.Label_descripcion.Location = new System.Drawing.Point(160, 175);
            this.Label_descripcion.Name = "Label_descripcion";
            this.Label_descripcion.Size = new System.Drawing.Size(98, 18);
            this.Label_descripcion.TabIndex = 10;
            this.Label_descripcion.Text = "Descripción";
            // 
            // Label_nombre
            // 
            this.Label_nombre.AutoSize = true;
            this.Label_nombre.Location = new System.Drawing.Point(160, 125);
            this.Label_nombre.Name = "Label_nombre";
            this.Label_nombre.Size = new System.Drawing.Size(68, 18);
            this.Label_nombre.TabIndex = 9;
            this.Label_nombre.Text = "Nombre";
            // 
            // Label_idrol
            // 
            this.Label_idrol.AutoSize = true;
            this.Label_idrol.Location = new System.Drawing.Point(160, 73);
            this.Label_idrol.Name = "Label_idrol";
            this.Label_idrol.Size = new System.Drawing.Size(24, 18);
            this.Label_idrol.TabIndex = 8;
            this.Label_idrol.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Txt_id1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Dgv_registro);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Txt_id1
            // 
            this.Txt_id1.Location = new System.Drawing.Point(57, 21);
            this.Txt_id1.Name = "Txt_id1";
            this.Txt_id1.Size = new System.Drawing.Size(186, 24);
            this.Txt_id1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "ID";
            // 
            // Dgv_registro
            // 
            this.Dgv_registro.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dgv_registro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_registro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Dgv_registro.Location = new System.Drawing.Point(19, 62);
            this.Dgv_registro.Name = "Dgv_registro";
            this.Dgv_registro.Size = new System.Drawing.Size(875, 307);
            this.Dgv_registro.TabIndex = 0;
            this.Dgv_registro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_clientes_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Descripcion";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Administrador";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // CRUD_rol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.Pnl_reporte);
            this.Controls.Add(this.Pnl_menu);
            this.Controls.Add(this.Pnl_ventana);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CRUD_rol";
            this.Text = "CRUD_rol";
            this.Pnl_ventana.ResumeLayout(false);
            this.Pnl_ventana.PerformLayout();
            this.Pnl_menu.ResumeLayout(false);
            this.Pnl_menu.PerformLayout();
            this.Pnl_reporte.ResumeLayout(false);
            this.Tbc_reporte.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_registro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_ventana;
        private System.Windows.Forms.Panel Pnl_menu;
        private System.Windows.Forms.Panel Pnl_reporte;
        private System.Windows.Forms.TabControl Tbc_reporte;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button Btn_nuevo;
        private System.Windows.Forms.Button Btn_cancelar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_remover;
        private System.Windows.Forms.Label Label_roles;
        private System.Windows.Forms.Button Btn_ayuda;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Label_cancelar;
        private System.Windows.Forms.Label Label_guardar;
        private System.Windows.Forms.Label Label_modificar;
        private System.Windows.Forms.Label Label_remover;
        private System.Windows.Forms.Label Label_nuevo;
        private System.Windows.Forms.TextBox Txt_administrador;
        private System.Windows.Forms.TextBox Txt_descricpion;
        private System.Windows.Forms.TextBox Txt_nombre;
        private System.Windows.Forms.TextBox Txt_id;
        private System.Windows.Forms.Label Label_administrador;
        private System.Windows.Forms.Label Label_descripcion;
        private System.Windows.Forms.Label Label_nombre;
        private System.Windows.Forms.Label Label_idrol;
        private System.Windows.Forms.TextBox Txt_id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}