namespace Project_Pim
{
    partial class FrmPrincipal
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
            this.pcbMenu = new System.Windows.Forms.PictureBox();
            this.pcbIndicador = new System.Windows.Forms.PictureBox();
            this.lblInstruir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbMenu
            // 
            this.pcbMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pcbMenu.BackColor = System.Drawing.Color.Transparent;
            this.pcbMenu.Image = global::Project_Pim.Properties.Resources.LuaPrincipal2;
            this.pcbMenu.Location = new System.Drawing.Point(112, 12);
            this.pcbMenu.Name = "pcbMenu";
            this.pcbMenu.Size = new System.Drawing.Size(391, 316);
            this.pcbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbMenu.TabIndex = 0;
            this.pcbMenu.TabStop = false;
            this.pcbMenu.Click += new System.EventHandler(this.pcbMenu_Click);
            // 
            // pcbIndicador
            // 
            this.pcbIndicador.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pcbIndicador.BackColor = System.Drawing.Color.Transparent;
            this.pcbIndicador.BackgroundImage = global::Project_Pim.Properties.Resources.Apontando1;
            this.pcbIndicador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbIndicador.Location = new System.Drawing.Point(538, 339);
            this.pcbIndicador.Name = "pcbIndicador";
            this.pcbIndicador.Size = new System.Drawing.Size(100, 50);
            this.pcbIndicador.TabIndex = 53;
            this.pcbIndicador.TabStop = false;
            // 
            // lblInstruir
            // 
            this.lblInstruir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblInstruir.AutoSize = true;
            this.lblInstruir.BackColor = System.Drawing.Color.Black;
            this.lblInstruir.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruir.ForeColor = System.Drawing.Color.White;
            this.lblInstruir.Location = new System.Drawing.Point(76, 355);
            this.lblInstruir.Name = "lblInstruir";
            this.lblInstruir.Size = new System.Drawing.Size(456, 22);
            this.lblInstruir.TabIndex = 54;
            this.lblInstruir.Text = "\"Todo lugar que aparecer \'indicador\' é clicável.\"";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Galaxy2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 398);
            this.Controls.Add(this.lblInstruir);
            this.Controls.Add(this.pcbIndicador);
            this.Controls.Add(this.pcbMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbIndicador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbMenu;
        private System.Windows.Forms.PictureBox pcbIndicador;
        private System.Windows.Forms.Label lblInstruir;
    }
}

