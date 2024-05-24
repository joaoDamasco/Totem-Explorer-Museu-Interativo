using Project_Pim.Apresentacao;
using Project_Pim.Modelo;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
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
            FrmRelatorio frmRelatorio = new FrmRelatorio();

            frmRelatorio.Show();
            this.Close();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            if (Estatico.Valor >= 5)
            {
                lblMensagem.Text = "Parabéns! Acertou todas as perguntas!";
            }
            else if (Estatico.Valor == 4)
            {
                lblMensagem.Text = "Acertou a maioria das perguntas! Bom trabalho!";
            }
            else if (Estatico.Valor == 3)
            {
                lblMensagem.Text = "Acertou a maioria! Continue assim!";
            }
            else if (Estatico.Valor == 2)
            {
                lblMensagem.Text = "Acertou várias perguntas! Continue estudando!";
            }
            else if (Estatico.Valor == 1)
            {
                lblMensagem.Text = "Bom esforço! Continue praticando!";
            }
            else
            {
                lblMensagem.Text = "Não desanime! Não acertou nenhuma pergunta.";
            }

            /*
            rtbPesquisa.Text = Estatico.Pessoas[0].Nome;

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Estatico.Pessoas.Length; i++)
            {
                sb.AppendLine($"Nome: {Estatico.Pessoas[i].Nome}, Idade: {Estatico.Pessoas[i].Idade}, Pontuação: {Estatico.Pessoas[i].Pontuacao}");
            }

            rtbPesquisa.Text = sb.ToString().ToUpper();

            rtbPesquisa.Text += ($"Nome: {Estatico.ListaPesquisa[0]}, Idade: {Estatico.ListaPesquisa[1]}, Pontuação: {Estatico.Valor}".ToUpper());
       */



            if (Estatico.ListaPesquisa.Count > 0)
            {
                string primeiroItem = Estatico.ListaPesquisa[0];
                
                    txbNome.Text += primeiroItem + "\n\n\n";
                
            }
            
            if (Estatico.ListaPesquisa.Count > 0)
            {
                string primeiroItem = Estatico.ListaPesquisa[1];
                
                    txbIdade.Text += primeiroItem + "\n\n\n";
                
            }
            lblPontuação.Text = "PONTUAÇÃO: 0" + Estatico.Valor;

            
        }
        private void pcbEstrelaBranca2_Click(object sender, EventArgs e)
        {
            AparecerEstrela(2);
            Estatico.Avaliacao = 2;
        }

        private void pcbEstrelaBranca3_Click(object sender, EventArgs e)
        {
            AparecerEstrela(3);
            Estatico.Avaliacao = 3;
        }

        private void pcbEstrelaBranca4_Click(object sender, EventArgs e)
        {
            AparecerEstrela(4);
            Estatico.Avaliacao = 4;
        }

        private void pcbEstrelaBranca5_Click(object sender, EventArgs e)
        {  
            AparecerEstrela(5);
            Estatico.Avaliacao = 5;
        }

        private void pcbEstrelaBranca1_Click(object sender, EventArgs e)
        {
            AparecerEstrela(1);
            Estatico.Avaliacao = 1;
        }

        private void AparecerEstrela(int limitar)
        {
            // Loop para percorrer cada PictureBox até o limite especificado
            for (int i = 1; i <= limitar; i++)
            {
                // Obtém o nome das PictureBoxes branca e amarela correspondentes
                string nomePictureBoxBranca = "pcbEstrelaBranca" + i;
                string nomePictureBoxAmarela = "pcbEstrelaAmarela" + i;

                // Encontra as PictureBoxes brancas e amarelas pelos nomes usando o método Controls.Find
                PictureBox pictureBoxBranca = this.Controls.Find(nomePictureBoxBranca, true).FirstOrDefault() as PictureBox;
                PictureBox pictureBoxAmarela = this.Controls.Find(nomePictureBoxAmarela, true).FirstOrDefault() as PictureBox;

                // Verifica se as PictureBoxes foram encontradas
                if (pictureBoxBranca != null && pictureBoxAmarela != null)
                {
                    // Torna a PictureBox amarela visível e a branca invisível
                    pictureBoxAmarela.Visible = true;
                    pictureBoxBranca.Visible = false;
                }
            }
        }
    }
}
