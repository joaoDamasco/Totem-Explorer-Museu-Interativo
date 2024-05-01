using Project_Pim.Apresentacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Project_Pim
{
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            FrmMenu frmMenu = new FrmMenu();

            // Torna o formulário FrmMenu visível
            frmMenu.Visible = true;

            // Fecha o formulário atual
            this.Close();
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            // Verifica se a senha digitada é igual a "1999"
            if (txbSenha.Text.Equals("1999"))
            {
                txbSenha.BackColor = Color.White;
                FrmRelatorio frmRelatorio = new FrmRelatorio();
                frmRelatorio.Show();
                this.Close();
            }
            else
            {
                txbSenha.BackColor = Color.Red;
                txbSenha.Text = "";
                // Define o foco na caixa de texto para que o usuário possa tentar novamente
                this.ActiveControl = txbSenha;
            }          
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txbSenha;
        }

        private void FrmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmPrincipal frmprincipal = new FrmPrincipal();
            frmprincipal.Close();
        }
    }
}
