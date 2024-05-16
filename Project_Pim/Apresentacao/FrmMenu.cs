using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnHistoria1_Click(object sender, EventArgs e)
        {
            FrmHistoria1 frmHistoria1 = new FrmHistoria1();
            
            frmHistoria1.ShowDialog();

            this.Visible = false;

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();
            frmprincipal.Show();
            this.Visible = false;
        }

        private void pcbIndicador_Click(object sender, EventArgs e)
        {

        }
    }
}
