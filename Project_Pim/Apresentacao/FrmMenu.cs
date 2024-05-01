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

        private void btnHistoria2_Click(object sender, EventArgs e)
        {
            FrmHistoriaApollo frmApollo = new FrmHistoriaApollo();

            frmApollo.Show();

            this.Visible = false;
        }

        private void btnHistoria3_Click(object sender, EventArgs e)
        {
            FrmHistoriaAstronauta frmHistoriaAstronauta = new FrmHistoriaAstronauta();

            frmHistoriaAstronauta.Show();

            this.Visible = false;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmQuestionario frmQuestionario = new FrmQuestionario();

            frmQuestionario.Show();

            this.Visible = false;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdmin frmAdmin = new FrmAdmin();

            frmAdmin.Show();

            this.Visible = false;
        }
    }
}
