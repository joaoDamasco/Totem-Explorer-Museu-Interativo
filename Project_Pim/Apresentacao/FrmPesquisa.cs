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

namespace Project_Pim
{
    public partial class FrmPesquisa : Form
    {
        public FrmPesquisa()
        {
            InitializeComponent();

            // Inicializa os eventos TextChanged
            txbNome.TextChanged += new EventHandler(txbNome_TextChanged);
            txbIdade.TextChanged += new EventHandler(txbIdade_TextChanged);

            // Inicialmente desativa o botão se os campos estiverem vazios
            VerificarCampos();

        }

        private void btnLetra_Click(object sender, EventArgs e)
        {
            // Adiciona o texto do botão
            txbNome.Text += (sender as Button).Text;

        }
        
        private void btnLetra_ClickNumero(object sender, EventArgs e)
        {
            // Adiciona o texto do botão
            txbIdade.Text += (sender as Button).Text;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa campo de texto
            txbNome.Text = "";
            txbIdade.Text = "";
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            // Remove o último caractere
            if (txbNome.Text != "")
            {
                txbNome.Text = txbNome.Text.Substring(0, txbNome.TextLength - 1);
            }
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            // Verifica se os campos de texto estão vazios
            if (string.IsNullOrWhiteSpace(txbNome.Text) || string.IsNullOrWhiteSpace(txbIdade.Text))
            {
                // Se algum campo estiver vazio, desativa o botão
                button1.Enabled = false;
            }
            else
            {
                // Se ambos os campos tiverem texto, adiciona os valores à lista e ativa o botão
                Estatico.ListaPesquisa.Add(txbNome.Text);
                Estatico.ListaPesquisa.Add(txbIdade.Text);
            }

            // Fecha o formulário de pesquisa e exibe o formulário Menu
            FrmMenu frmMenu = new FrmMenu();

            frmMenu.Visible = true;

            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FrmPrincipal frmPrincipal = new FrmPrincipal();
            frmPrincipal.Visible = true;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txbIdade.Text != "")
            {
                txbIdade.Text = txbIdade.Text.Substring(0, txbIdade.TextLength - 1);
            }
        }
        private void txbNome_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void txbIdade_TextChanged(object sender, EventArgs e)
        {
            VerificarCampos();
        }

        private void VerificarCampos()
        {
            // Habilita ou desabilita o botão com base no texto das caixas de texto
            btnMenu.Enabled = !string.IsNullOrWhiteSpace(txbNome.Text) && !string.IsNullOrWhiteSpace(txbIdade.Text);
        }

        private void btnEspaco_Click(object sender, EventArgs e)
        {
            txbNome.Text += " ";

        }
    }
}
