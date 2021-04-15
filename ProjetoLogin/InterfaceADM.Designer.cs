
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
            this.lblADM = new System.Windows.Forms.Label();
            this.VoltarTelaLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblADM
            // 
            this.lblADM.AutoSize = true;
            this.lblADM.BackColor = System.Drawing.Color.Transparent;
            this.lblADM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblADM.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblADM.Location = new System.Drawing.Point(33, 54);
            this.lblADM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblADM.Name = "lblADM";
            this.lblADM.Size = new System.Drawing.Size(86, 37);
            this.lblADM.TabIndex = 0;
            this.lblADM.Text = "ADM";
            // 
            // VoltarTelaLogin
            // 
            this.VoltarTelaLogin.Location = new System.Drawing.Point(382, 320);
            this.VoltarTelaLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.VoltarTelaLogin.Name = "VoltarTelaLogin";
            this.VoltarTelaLogin.Size = new System.Drawing.Size(88, 40);
            this.VoltarTelaLogin.TabIndex = 1;
            this.VoltarTelaLogin.Text = "Sair";
            this.VoltarTelaLogin.UseVisualStyleBackColor = true;
            this.VoltarTelaLogin.Click += new System.EventHandler(this.VoltarTelaLogin_Click);
            // 
            // InterfaceADM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 396);
            this.Controls.Add(this.VoltarTelaLogin);
            this.Controls.Add(this.lblADM);
            this.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "InterfaceADM";
            this.Text = "InterfaceADM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.InterfaceADM_FormClosed);
            this.Load += new System.EventHandler(this.InterfaceADM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblADM;
        private System.Windows.Forms.Button VoltarTelaLogin;
    }
}