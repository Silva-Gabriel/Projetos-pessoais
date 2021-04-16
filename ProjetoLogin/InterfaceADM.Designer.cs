
namespace ProjetoLogin
{
    partial class InterfaceADM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceADM));
            this.lblADM = new System.Windows.Forms.Label();
            this.VoltarTelaLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblADM
            // 
            this.lblADM.AutoSize = true;
            this.lblADM.BackColor = System.Drawing.Color.Transparent;
            this.lblADM.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADM.ForeColor = System.Drawing.Color.Black;
            this.lblADM.Location = new System.Drawing.Point(23, 15);
            this.lblADM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADM.Name = "lblADM";
            this.lblADM.Size = new System.Drawing.Size(120, 31);
            this.lblADM.TabIndex = 0;
            this.lblADM.Text = "Usuario";
            // 
            // VoltarTelaLogin
            // 
            this.VoltarTelaLogin.BackColor = System.Drawing.Color.Black;
            this.VoltarTelaLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VoltarTelaLogin.ForeColor = System.Drawing.Color.White;
            this.VoltarTelaLogin.Location = new System.Drawing.Point(420, 351);
            this.VoltarTelaLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VoltarTelaLogin.Name = "VoltarTelaLogin";
            this.VoltarTelaLogin.Size = new System.Drawing.Size(112, 45);
            this.VoltarTelaLogin.TabIndex = 1;
            this.VoltarTelaLogin.Text = "Encerrar Sessão";
            this.VoltarTelaLogin.UseVisualStyleBackColor = false;
            this.VoltarTelaLogin.Click += new System.EventHandler(this.VoltarTelaLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lblADM);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 130);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::ProjetoLogin.Properties.Resources.unnamed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 212);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(391, 204);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // InterfaceADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(573, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.VoltarTelaLogin);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InterfaceADM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfaceADM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceADM_FormClosed);
            this.Load += new System.EventHandler(this.InterfaceADM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblADM;
        private System.Windows.Forms.Button VoltarTelaLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}