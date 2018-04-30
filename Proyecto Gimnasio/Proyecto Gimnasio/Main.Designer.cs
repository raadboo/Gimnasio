namespace Proyecto_Gimnasio
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_userName = new System.Windows.Forms.TextBox();
            this.txt_userPass = new System.Windows.Forms.TextBox();
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_user = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerenciaRutinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerenciaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nutricionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_userName
            // 
            this.txt_userName.Location = new System.Drawing.Point(305, 286);
            this.txt_userName.Name = "txt_userName";
            this.txt_userName.Size = new System.Drawing.Size(196, 20);
            this.txt_userName.TabIndex = 4;
            // 
            // txt_userPass
            // 
            this.txt_userPass.Location = new System.Drawing.Point(305, 343);
            this.txt_userPass.Name = "txt_userPass";
            this.txt_userPass.PasswordChar = '*';
            this.txt_userPass.Size = new System.Drawing.Size(196, 20);
            this.txt_userPass.TabIndex = 5;
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx1.Image = global::Proyecto_Gimnasio.Properties.Resources._1;
            this.pbx1.Location = new System.Drawing.Point(324, 53);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(159, 196);
            this.pbx1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx1.TabIndex = 6;
            this.pbx1.TabStop = false;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(370, 257);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(66, 21);
            this.lb1.TabIndex = 7;
            this.lb1.Text = "Usuario";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lb2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(352, 314);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(103, 21);
            this.lb2.TabIndex = 10;
            this.lb2.Text = "Contraseña";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_login.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(342, 386);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(123, 33);
            this.btn_login.TabIndex = 11;
            this.btn_login.Text = "Iniciar sesion";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.Location = new System.Drawing.Point(607, 3);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(66, 21);
            this.lbl_user.TabIndex = 12;
            this.lbl_user.Text = "Usuario";
            this.lbl_user.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.configuracionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.informacionToolStripMenuItem,
            this.sugerenciaRutinasToolStripMenuItem,
            this.sugerenciaProductosToolStripMenuItem,
            this.nutricionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.crearUsuariosToolStripMenuItem.Text = "Crear usuarios";
            this.crearUsuariosToolStripMenuItem.Visible = false;
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            this.configuracionToolStripMenuItem.Visible = false;
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            this.tiendaToolStripMenuItem.Visible = false;
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informacionToolStripMenuItem.Text = "Informacion";
            this.informacionToolStripMenuItem.Visible = false;
            // 
            // sugerenciaRutinasToolStripMenuItem
            // 
            this.sugerenciaRutinasToolStripMenuItem.Name = "sugerenciaRutinasToolStripMenuItem";
            this.sugerenciaRutinasToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.sugerenciaRutinasToolStripMenuItem.Text = "Sugerencia rutinas";
            this.sugerenciaRutinasToolStripMenuItem.Visible = false;
            // 
            // sugerenciaProductosToolStripMenuItem
            // 
            this.sugerenciaProductosToolStripMenuItem.Name = "sugerenciaProductosToolStripMenuItem";
            this.sugerenciaProductosToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.sugerenciaProductosToolStripMenuItem.Text = "Sugerencia productos";
            this.sugerenciaProductosToolStripMenuItem.Visible = false;
            // 
            // nutricionToolStripMenuItem
            // 
            this.nutricionToolStripMenuItem.Name = "nutricionToolStripMenuItem";
            this.nutricionToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.nutricionToolStripMenuItem.Text = "Nutricion";
            this.nutricionToolStripMenuItem.Visible = false;
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Visible = false;
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.pbx1);
            this.Controls.Add(this.txt_userPass);
            this.Controls.Add(this.txt_userName);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GymSoft";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_userName;
        private System.Windows.Forms.TextBox txt_userPass;
        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerenciaRutinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerenciaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nutricionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

