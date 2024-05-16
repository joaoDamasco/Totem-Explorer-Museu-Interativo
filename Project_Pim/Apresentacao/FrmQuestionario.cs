using Project_Pim.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Pim
{
    public partial class FrmQuestionario : Form
    {
        
        public FrmQuestionario()
        {
            InitializeComponent();
            // Define o valor máximo da barra de progresso como 6
            pgbPontuacao.Maximum = 6;
        }
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();
            frmMenu.Visible = true;
            this.Close();

            Estatico.Valor = 0;
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmResultado frmResultado = new FrmResultado();
            frmResultado.Show();
            this.Close();
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

        private void btnNao2_Click(object sender, EventArgs e)
         {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao2.Enabled = false;
            btnSim2.Enabled = false;
            btnNao2.BackColor = Color.Green;
        }

        private void btnSim3_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao3.Enabled = false;
            btnSim3.Enabled = false;
            btnSim3.BackColor = Color.Green;
        }

        private void btnSim4_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao4.Enabled = false;
            btnSim4.Enabled = false;
            btnSim4.BackColor = Color.Green;
        }

        private void btnSim5_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao5.Enabled = false;
            btnSim5.Enabled = false;
            btnSim5.BackColor = Color.Green;
        }

        private void btnSim6_Click(object sender, EventArgs e)
        {
            Estatico.Valor++;
            lblPontuacao.Text = "Pontuação:  0" + Estatico.Valor;
            pgbPontuacao.Value = Estatico.Valor;
            btnNao6.Enabled = false;
            btnSim6.Enabled = false;
            btnSim6.BackColor = Color.Green;       
        }

        private void btnSim1_Click(object sender, EventArgs e)
        {
            btnSim1.BackColor = Color.Red;
            btnNao1.Enabled = false;
            btnSim1.Enabled = false;
        }

        private void btnSim2_Click(object sender, EventArgs e)
        {
            btnSim2.BackColor = Color.Red;
            btnNao2.Enabled = false;
            btnSim2.Enabled = false;
        }

        private void btnNao3_Click(object sender, EventArgs e)
        {
            btnNao3.BackColor = Color.Red;
            btnNao3.Enabled = false;
            btnSim3.Enabled = false;
        }

        private void btnNao4_Click(object sender, EventArgs e)
        {
            btnNao4.BackColor = Color.Red;
            btnNao4.Enabled = false;
            btnSim4.Enabled = false;
        }

        private void btnNao5_Click(object sender, EventArgs e)
        {
            btnNao5.BackColor = Color.Red;
            btnNao5.Enabled = false;
            btnSim5.Enabled = false;
        }

        private void btnNao6_Click(object sender, EventArgs e)
        {
            btnNao6.BackColor = Color.Red;
            btnNao6.Enabled = false;
            btnSim6.Enabled = false;
        }
    }
}
