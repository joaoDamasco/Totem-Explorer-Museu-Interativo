namespace Project_Pim
{
    partial class FrmMenu
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
            this.btnHistoria1 = new System.Windows.Forms.Button();
            this.btnTelaPrincipal = new System.Windows.Forms.Button();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.pcbApontar = new System.Windows.Forms.PictureBox();
            this.pcbIndicador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApontar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHistoria1
            // 
            this.btnHistoria1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistoria1.BackColor = System.Drawing.Color.Black;
            this.btnHistoria1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria1.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistoria1.Location = new System.Drawing.Point(166, 180);
            this.btnHistoria1.Name = "btnHistoria1";
            this.btnHistoria1.Size = new System.Drawing.Size(341, 50);
            this.btnHistoria1.TabIndex = 0;
            this.btnHistoria1.Text = "Iniciar História e Quiz de Perguntas";
            this.btnHistoria1.UseVisualStyleBackColor = false;
            this.btnHistoria1.Click += new System.EventHandler(this.btnHistoria1_Click);
            // 
            // btnTelaPrincipal
            // 
            this.btnTelaPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTelaPrincipal.BackColor = System.Drawing.Color.Black;
            this.btnTelaPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelaPrincipal.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTelaPrincipal.ForeColor = System.Drawing.Color.White;
            this.btnTelaPrincipal.Location = new System.Drawing.Point(12, 12);
            this.btnTelaPrincipal.Name = "btnTelaPrincipal";
            this.btnTelaPrincipal.Size = new System.Drawing.Size(68, 66);
            this.btnTelaPrincipal.TabIndex = 6;
            this.btnTelaPrincipal.Text = "Tela Inicial";
            this.btnTelaPrincipal.UseVisualStyleBackColor = false;
            this.btnTelaPrincipal.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.BackColor = System.Drawing.Color.Black;
            this.lblBemVindo.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblBemVindo.Location = new System.Drawing.Point(204, 78);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(288, 46);
            this.lblBemVindo.TabIndex = 8;
            this.lblBemVindo.Text = "Seja Bem-Vindo";
            // 
            // pcbApontar
            // 
            this.pcbApontar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbApontar.BackColor = System.Drawing.Color.Transparent;
            this.pcbApontar.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbApontar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbApontar.Location = new System.Drawing.Point(513, 180);
            this.pcbApontar.Name = "pcbApontar";
            this.pcbApontar.Size = new System.Drawing.Size(100, 50);
            this.pcbApontar.TabIndex = 9;
            this.pcbApontar.TabStop = false;
            // 
            // pcbIndicador
            // 
            this.pcbIndicador.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pcbIndicador.BackColor = System.Drawing.Color.Transparent;
            this.pcbIndicador.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIndicador.Location = new System.Drawing.Point(86, 24);
            this.pcbIndicador.Name = "pcbIndicador";
            this.pcbIndicador.Size = new System.Drawing.Size(39, 41);
            this.pcbIndicador.TabIndex = 10;
            this.pcbIndicador.TabStop = false;
            this.pcbIndicador.Click += new System.EventHandler(this.pcbIndicador_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.GalaxiaFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 410);
            this.Controls.Add(this.pcbIndicador);
            this.Controls.Add(this.pcbApontar);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.btnTelaPrincipal);
            this.Controls.Add(this.btnHistoria1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbApontar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHistoria1;
        private System.Windows.Forms.Button btnTelaPrincipal;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.PictureBox pcbApontar;
        private System.Windows.Forms.PictureBox pcbIndicador;
    }
}