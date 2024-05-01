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
            this.btnHistoria2 = new System.Windows.Forms.Button();
            this.btnHistoria3 = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnAdmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHistoria1
            // 
            this.btnHistoria1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistoria1.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoria1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria1.ForeColor = System.Drawing.Color.Cyan;
            this.btnHistoria1.Location = new System.Drawing.Point(232, 62);
            this.btnHistoria1.Name = "btnHistoria1";
            this.btnHistoria1.Size = new System.Drawing.Size(237, 50);
            this.btnHistoria1.TabIndex = 0;
            this.btnHistoria1.Text = "História Do Foguete";
            this.btnHistoria1.UseVisualStyleBackColor = false;
            this.btnHistoria1.Click += new System.EventHandler(this.btnHistoria1_Click);
            // 
            // btnHistoria2
            // 
            this.btnHistoria2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistoria2.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoria2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria2.ForeColor = System.Drawing.Color.Cyan;
            this.btnHistoria2.Location = new System.Drawing.Point(232, 118);
            this.btnHistoria2.Name = "btnHistoria2";
            this.btnHistoria2.Size = new System.Drawing.Size(237, 50);
            this.btnHistoria2.TabIndex = 4;
            this.btnHistoria2.Text = "História Apollo 11";
            this.btnHistoria2.UseVisualStyleBackColor = false;
            this.btnHistoria2.Click += new System.EventHandler(this.btnHistoria2_Click);
            // 
            // btnHistoria3
            // 
            this.btnHistoria3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnHistoria3.BackColor = System.Drawing.Color.Transparent;
            this.btnHistoria3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistoria3.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistoria3.ForeColor = System.Drawing.Color.Cyan;
            this.btnHistoria3.Location = new System.Drawing.Point(232, 174);
            this.btnHistoria3.Name = "btnHistoria3";
            this.btnHistoria3.Size = new System.Drawing.Size(237, 50);
            this.btnHistoria3.TabIndex = 5;
            this.btnHistoria3.Text = "História dos Astrounautas";
            this.btnHistoria3.UseVisualStyleBackColor = false;
            this.btnHistoria3.Click += new System.EventHandler(this.btnHistoria3_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFinalizar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.Cyan;
            this.btnFinalizar.Location = new System.Drawing.Point(251, 288);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(200, 50);
            this.btnFinalizar.TabIndex = 6;
            this.btnFinalizar.Text = "Avançar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmin.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btnAdmin.Location = new System.Drawing.Point(590, 364);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(106, 34);
            this.btnAdmin.TabIndex = 7;
            this.btnAdmin.Text = "Admin";
            this.btnAdmin.UseVisualStyleBackColor = false;
            this.btnAdmin.Click += new System.EventHandler(this.btnAdmin_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pim.Properties.Resources.Menu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(708, 410);
            this.Controls.Add(this.btnAdmin);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnHistoria3);
            this.Controls.Add(this.btnHistoria2);
            this.Controls.Add(this.btnHistoria1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "FrmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistoria1;
        private System.Windows.Forms.Button btnHistoria2;
        private System.Windows.Forms.Button btnHistoria3;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnAdmin;
    }
}