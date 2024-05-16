using Project_Pim.Modelo;
using System;
using System.ComponentModel;
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
            FrmPrincipal frmPrincipal = new FrmPrincipal();

            frmPrincipal.Show();
            this.Close();
        }

        private void FrmResultado_Load(object sender, EventArgs e)
        {
            if (Estatico.Valor >= 6)
            {
                lblMensagem.Text = "Parabéns! Acertou todas as perguntas!";
            }
            else if (Estatico.Valor == 5)
            {
                lblMensagem.Text = "Acertou a maioria das perguntas! Bom trabalho!";
            }
            else if (Estatico.Valor == 4)
            {
                lblMensagem.Text = "Acertou a maioria! Continue assim!";
            }
            else if (Estatico.Valor == 3)
            {
                lblMensagem.Text = "Acertou várias perguntas! Continue estudando!";
            }
            else if (Estatico.Valor == 2)
            {
                lblMensagem.Text = "Bom esforço! Continue praticando!";
            }
            else if (Estatico.Valor == 1)
            {
                lblMensagem.Text = "Continue tentando! Com prática, você melhora!";
            }
            else
            {
                lblMensagem.Text = "Não desanime! Não acertou nenhuma pergunta.";
            }




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
        }

        private void pcbEstrelaBranca3_Click(object sender, EventArgs e)
        {
            AparecerEstrela(3);
        }

        private void pcbEstrelaBranca4_Click(object sender, EventArgs e)
        {
            AparecerEstrela(4);
        }

        private void pcbEstrelaBranca5_Click(object sender, EventArgs e)
        {  
            AparecerEstrela(5);
        }

        private void pcbEstrelaBranca1_Click(object sender, EventArgs e)
        {
            AparecerEstrela(1);
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
