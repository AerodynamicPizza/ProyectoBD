using GestionProyectos.Dialogos;
using GestionProyectos.Paneles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProyectos
{
    public partial class VentanaPrincipal : Form
    {

        

        public VentanaPrincipal()
        {
            InitializeComponent();
            MostrarLogin();
        }

        private void MostrarLogin()
        {

            PanelLogin pnlLogin = new PanelLogin(this);
            pnlLogin.Name = "panelLogin";

            Controls.Add(pnlLogin);

            foreach (Control c in Controls)
            {
                c.Visible = false;
            }

            pnlLogin.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogoAgregarActividad daa = new DialogoAgregarActividad();
            daa.ShowDialog();
        }

        internal void VerificarLogin(string username, string pass)
        {

            

        }
    }
}
