namespace Project_Pim
{
    partial class FrmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.btnSenha = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblAcessoAdmin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbSenha
            // 
            this.txbSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbSenha.Location = new System.Drawing.Point(291, 161);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(190, 20);
            this.txbSenha.TabIndex = 0;
            // 
            // btnSenha
            // 
            this.btnSenha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSenha.Location = new System.Drawing.Point(344, 206);
            this.btnSenha.Name = "btnSenha";
            this.btnSenha.Size = new System.Drawing.Size(75, 23);
            this.btnSenha.TabIndex = 1;
            this.btnSenha.Text = "Entrar";
            this.btnSenha.UseVisualStyleBackColor = true;
            this.btnSenha.Click += new System.EventHandler(this.btnSenha_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVoltar.BackColor = System.Drawing.Color.Transparent;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.Color.Cyan;
            this.btnVoltar.Location = new System.Drawing.Point(12, 384);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(157, 37);
            this.btnVoltar.TabIndex = 9;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblAcessoAdmin
            // 
            this.lblAcessoAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAcessoAdmin.AutoSize = true;
            this.lblAcessoAdmin.Location = new System.Drawing.Point(208, 164);
            this.lblAcessoAdmin.Name = "lblAcessoAdmin";
            this.lblAcessoAdmin.Size = new System.Drawing.Size(77, 13);
            this.lblAcessoAdmin.TabIndex = 10;
            this.lblAcessoAdmin.Text = "Acesso Admin:";
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Galaxy;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAcessoAdmin);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSenha);
            this.Controls.Add(this.txbSenha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button btnSenha;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblAcessoAdmin;
    }
}