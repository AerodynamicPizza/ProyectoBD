using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos.Paneles
{
    public partial class PanelLogin : UserControl
    {

        VentanaPrincipal principal;

        public PanelLogin(VentanaPrincipal vp)
        {
            InitializeComponent();
            principal = vp;
        }

        private void botonEntrar_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string pass = textBoxPass.Text;

            principal.VerificarLogin(username, pass);
        }
    }
}
