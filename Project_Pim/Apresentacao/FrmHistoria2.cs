using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim.Apresentacao
{
    public partial class FrmHistoria2 : Form
    {
        public FrmHistoria2()
        {
            InitializeComponent();
        }

        private void FrmHistoria2_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FrmQuestionario1 frmQuestionario1 = new FrmQuestionario1();
            frmQuestionario1.Visible = true;
            this.Close();


        }

        private void btnTelaPrincipal_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
        }
    }
}
