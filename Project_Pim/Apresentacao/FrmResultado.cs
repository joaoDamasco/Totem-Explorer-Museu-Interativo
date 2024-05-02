using Project_Pim.Modelo;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_Pim
{
    public partial class FrmResultado : Form
    {
        private System.Windows.Forms.GroupBox groupBox;
        private string respostaCorreta;

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
            // Instancia um objeto Controle e valida as respostas das perguntas utilizando os valores estáticos de Resposta.
            Controle controle = new Controle();
            controle.ValidarResposta(grbPergunta1, Estatico.Resposta1);
            controle.ValidarResposta(grbPergunta2, Estatico.Resposta2);
            controle.ValidarResposta(grbPergunta3, Estatico.Resposta3);
            controle.ValidarResposta(grbPergunta4, Estatico.Resposta4);
            controle.ValidarResposta(grbPergunta5, Estatico.Resposta5);
        }
    }
}
