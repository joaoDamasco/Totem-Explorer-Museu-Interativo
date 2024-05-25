namespace Project_Pim
{
    partial class FrmHistoria1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHistoria1));
            this.btnContinuar = new System.Windows.Forms.Button();
            this.pcbApollo = new System.Windows.Forms.PictureBox();
            this.lblApresentarHistoria = new System.Windows.Forms.Label();
            this.pcbApontar = new System.Windows.Forms.PictureBox();
            this.pcbIndicador = new System.Windows.Forms.PictureBox();
            this.btnTelaPrincipal = new System.Windows.Forms.Button();
            this.lblHistori = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApontar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).BeginInit();
            this.SuspendLayout();
            // 
            // btnContinuar
            // 
            this.btnContinuar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnContinuar.BackColor = System.Drawing.Color.White;
            this.btnContinuar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinuar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinuar.ForeColor = System.Drawing.Color.Black;
            this.btnContinuar.Location = new System.Drawing.Point(478, 505);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(301, 55);
            this.btnContinuar.TabIndex = 8;
            this.btnContinuar.Text = "Continuar História";
            this.btnContinuar.UseVisualStyleBackColor = false;
            this.btnContinuar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // pcbApollo
            // 
            this.pcbApollo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbApollo.Image = global::Project_Pim.Properties.Resources.ApolloLua;
            this.pcbApollo.Location = new System.Drawing.Point(-13, 566);
            this.pcbApollo.Name = "pcbApollo";
            this.pcbApollo.Size = new System.Drawing.Size(1405, 180);
            this.pcbApollo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbApollo.TabIndex = 10;
            this.pcbApollo.TabStop = false;
            // 
            // lblApresentarHistoria
            // 
            this.lblApresentarHistoria.AutoSize = true;
            this.lblApresentarHistoria.BackColor = System.Drawing.Color.White;
            this.lblApresentarHistoria.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApresentarHistoria.Location = new System.Drawing.Point(589, 20);
            this.lblApresentarHistoria.Name = "lblApresentarHistoria";
            this.lblApresentarHistoria.Size = new System.Drawing.Size(219, 39);
            this.lblApresentarHistoria.TabIndex = 17;
            this.lblApresentarHistoria.Text = "Tema História";
            // 
            // pcbApontar
            // 
            this.pcbApontar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbApontar.BackColor = System.Drawing.Color.Transparent;
            this.pcbApontar.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbApontar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbApontar.Location = new System.Drawing.Point(785, 505);
            this.pcbApontar.Name = "pcbApontar";
            this.pcbApontar.Size = new System.Drawing.Size(100, 55);
            this.pcbApontar.TabIndex = 19;
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
            this.pcbIndicador.TabIndex = 21;
            this.pcbIndicador.TabStop = false;
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
            this.btnTelaPrincipal.TabIndex = 20;
            this.btnTelaPrincipal.Text = "Tela Inicial";
            this.btnTelaPrincipal.UseVisualStyleBackColor = false;
            this.btnTelaPrincipal.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblHistori
            // 
            this.lblHistori.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHistori.AutoSize = true;
            this.lblHistori.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHistori.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistori.ForeColor = System.Drawing.Color.White;
            this.lblHistori.Location = new System.Drawing.Point(118, 129);
            this.lblHistori.Name = "lblHistori";
            this.lblHistori.Size = new System.Drawing.Size(1226, 264);
            this.lblHistori.TabIndex = 23;
            this.lblHistori.Text = resources.GetString("lblHistori.Text");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(443, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 62);
            this.label2.TabIndex = 34;
            this.label2.Text = "Foguete e Missão Apollo 11";
            // 
            // FrmHistoria1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.GalaxiaFinal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1316, 736);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHistori);
            this.Controls.Add(this.pcbIndicador);
            this.Controls.Add(this.btnTelaPrincipal);
            this.Controls.Add(this.pcbApontar);
            this.Controls.Add(this.lblApresentarHistoria);
            this.Controls.Add(this.pcbApollo);
            this.Controls.Add(this.btnContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHistoria1";
            this.Text = "FrmHistoria1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pcbApollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbApontar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.PictureBox pcbApollo;
        private System.Windows.Forms.Label lblApresentarHistoria;
        private System.Windows.Forms.PictureBox pcbApontar;
        private System.Windows.Forms.PictureBox pcbIndicador;
        private System.Windows.Forms.Button btnTelaPrincipal;
        private System.Windows.Forms.Label lblHistori;
        private System.Windows.Forms.Label label2;
    }
}