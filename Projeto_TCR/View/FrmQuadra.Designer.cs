namespace Projeto_TCR
{
    partial class FrmQuadra
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
            this.TxtCobertura = new MetroFramework.Controls.MetroTextBox();
            this.TxtPiso = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Location = new System.Drawing.Point(38, 217);
            this.metroPanel1.Controls.SetChildIndex(this.btnNovo, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnExcluirT, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnCancelar, 0);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Click += new System.EventHandler(this.BtnFecharT_Click);
            // 
            // BtnExcluirT
            // 
            this.BtnExcluirT.Click += new System.EventHandler(this.BtnExcluirT_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // TxtCobertura
            // 
            this.TxtCobertura.Location = new System.Drawing.Point(120, 126);
            this.TxtCobertura.Name = "TxtCobertura";
            this.TxtCobertura.Size = new System.Drawing.Size(215, 23);
            this.TxtCobertura.TabIndex = 17;
            // 
            // TxtPiso
            // 
            this.TxtPiso.Location = new System.Drawing.Point(120, 79);
            this.TxtPiso.Name = "TxtPiso";
            this.TxtPiso.Size = new System.Drawing.Size(215, 23);
            this.TxtPiso.TabIndex = 16;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 126);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(62, 19);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "Covered:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 79);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(55, 19);
            this.metroLabel1.TabIndex = 13;
            this.metroLabel1.Text = "Surface:";
            // 
            // FrmQuadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(670, 376);
            this.Controls.Add(this.TxtCobertura);
            this.Controls.Add(this.TxtPiso);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmQuadra";
            this.Text = "Register a court";
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.TxtPiso, 0);
            this.Controls.SetChildIndex(this.TxtCobertura, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox TxtCobertura;
        private MetroFramework.Controls.MetroTextBox TxtPiso;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}