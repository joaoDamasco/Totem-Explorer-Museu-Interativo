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
   
            Estatico.ListaPesquisa.Add(txbNome.Text);
            Estatico.ListaPesquisa.Add(txbIdade.Text);

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
    }
}
