using Project_Pim.Modelo;
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
    public partial class FrmRelatorio : Form
    {
        public FrmRelatorio()
        {
            InitializeComponent();
        }

        private void FrmRelatorio_Load(object sender, EventArgs e)
        {
            if (Estatico.ListaPesquisa.Count > 0)
            {
                foreach (string item in Estatico.ListaPesquisa)
                {
                    rtbRelatorio.Text += item + "\n\n\n";
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();

            frmprincipal.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; ++i)
                if (Application.OpenForms[i] != this)
                    Application.OpenForms[i].Close();
        }
    }
}
