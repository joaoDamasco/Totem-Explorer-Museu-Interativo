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
    public partial class FrmQuestionario1 : Form
    {
        public FrmQuestionario1()
        {
            InitializeComponent();
            // Define o valor máximo da barra de progresso como 5
            pgbPontuacao.Maximum = 5;
        }

        private void btnNao1_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao1.Enabled = false;
            btnSim1.Enabled = false;
            btnNao1.BackColor = Color.Green;
        }

        private void btnSim1_Click(object sender, EventArgs e)
        {
            btnSim1.BackColor = Color.Red;
            btnNao1.Enabled = false;
            btnSim1.Enabled = false;
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            FrmQuestionario2 frmQuestionario2 = new FrmQuestionario2();
            frmQuestionario2.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();
            Estatico.Valor = 0;
            pgbPontuacao.Value = 0;
        }

        private void FrmQuestionario1_Load(object sender, EventArgs e)
        {
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
        }
    }
}
