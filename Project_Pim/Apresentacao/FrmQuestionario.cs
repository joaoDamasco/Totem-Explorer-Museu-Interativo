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
    public partial class FrmQuestionario : Form
    {
        public FrmQuestionario()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            frmMenu.Visible = true;

            this.Close();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Itera sobre todos os RadioButton dentro do grupo de controles
            foreach (RadioButton item in grbPergunta1.Controls.OfType<RadioButton>())
            {
                // Verifica se algum RadioButton está marcado
                if (item.Checked)
                {
                    // Se um RadioButton estiver marcado, extrai o primeiro caractere do texto desse RadioButton
                    // e armazena na variável estática Resposta1 da classe Estatico
                    Estatico.Resposta1 = item.Text.Substring(0, 1);
                }
            }
            foreach (RadioButton item in grbPergunta2.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    
                    Estatico.Resposta2 = item.Text.Substring(0, 1);
                }
            }
            foreach (RadioButton item in grbPergunta3.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    Estatico.Resposta3 = item.Text.Substring(0, 1);
                }
            }
            foreach (RadioButton item in grbPergunta4.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    Estatico.Resposta4 = item.Text.Substring(0, 1);
                }
            }
            foreach (RadioButton item in grbPergunta5.Controls.OfType<RadioButton>())
            {
                if (item.Checked)
                {
                    Estatico.Resposta5 = item.Text.Substring(0, 1);
                }
            }
            FrmResultado frmResultado = new FrmResultado();

            frmResultado.Show();
            this.Close();
        }
    }
}
