using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Gimnasio
{
    public partial class Main : Form
    {

        public string userName { get; set; }

        public Main()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            ConjuntoDatosTableAdapters.UsuarioTableAdapter adapter;
            adapter = new ConjuntoDatosTableAdapters.UsuarioTableAdapter();

            ConjuntoDatos.UsuarioDataTable res = adapter.Login(txt_userName.Text, txt_userPass.Text);

            if (res.Count > 0)
            {
                MessageBox.Show("Bienvenido! " + res[0].Nombre);
                userName = res[0].Nombre;
                
                salirToolStripMenuItem.Visible = true;

                pbx1.Visible = false;
                lb1.Visible = false;
                lb2.Visible = false;
                txt_userName.Visible = false;
                txt_userPass.Visible = false;
                btn_login.Visible = false;
                
                if (res[0].Id_Tipo == 1)
                {
                    showAdminOptions();
                }
                else
                {
                    showClienteOptions();
                }

                lbl_user.Visible = true;
                lbl_user.Text = "Bienvenido, " + res[0].Nombre;

            }
            else
            {
                MessageBox.Show("Usuario no registrado");
            }
        }


        public void showAdminOptions()
        {
            crearUsuariosToolStripMenuItem.Visible = true;
            configuracionToolStripMenuItem.Visible = true;
            reportesToolStripMenuItem.Visible = true;
            tiendaToolStripMenuItem.Visible = true;
        }


        public void showClienteOptions()
        {
            informacionToolStripMenuItem.Visible = true;
            sugerenciaRutinasToolStripMenuItem.Visible = true;
            sugerenciaProductosToolStripMenuItem.Visible = true;
            nutricionToolStripMenuItem.Visible = true;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            crearUsuariosToolStripMenuItem.Visible = false;
            configuracionToolStripMenuItem.Visible = false;
            reportesToolStripMenuItem.Visible = false;
            tiendaToolStripMenuItem.Visible = false;
            informacionToolStripMenuItem.Visible = false;
            sugerenciaRutinasToolStripMenuItem.Visible = false;
            sugerenciaProductosToolStripMenuItem.Visible = false;
            nutricionToolStripMenuItem.Visible = false;


            salirToolStripMenuItem.Visible = false;

            pbx1.Visible = true;
            lb1.Visible = true;
            lb2.Visible = true;
            txt_userName.Text = "";
            txt_userName.Visible = true;
            txt_userPass.Text = "";
            txt_userPass.Visible = true;
            btn_login.Visible = true;

            lbl_user.Visible = false;
        }
    }
}
