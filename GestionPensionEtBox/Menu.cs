using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionPensionEtBox
{
    public partial class Menu : Form
    {
        public static string IDPension { get; set; }
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_changerPension_Click(object sender, EventArgs e)
        {
            Authentification frm = new Authentification();
            frm.ShowDialog();
        }

        private void btn_gestionBox_Click(object sender, EventArgs e)
        {
            GestionDeBox frm = new GestionDeBox();
            frm.ShowDialog();
        }

        private void btn_paraPension_Click(object sender, EventArgs e)
        {
            GestionPension frm = new GestionPension();
            frm.ShowDialog();
        }
    }
}
