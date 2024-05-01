using Project_Pim.Modelo;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Project_Pim
{
    public partial class FrmResultado : Form
    {
        public FrmResultado()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            FrmPesquisa frmPesquisa = new FrmPesquisa();

            frmPesquisa.Show();
            this.Close();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            // Chamo o método estatico para verificar e alterar a cor da resposta errada
            VerificadorResposta.PintarRespostaIncorreta(grbPergunta1, Estatico.Resposta1);
            VerificadorResposta.PintarRespostaIncorreta(grbPergunta2, Estatico.Resposta2);
            VerificadorResposta.PintarRespostaIncorreta(grbPergunta3, Estatico.Resposta3);
            VerificadorResposta.PintarRespostaIncorreta(grbPergunta4, Estatico.Resposta4);
            VerificadorResposta.PintarRespostaIncorreta(grbPergunta5, Estatico.Resposta5);
        }
    }
}
