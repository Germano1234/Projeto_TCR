namespace Projeto_TCR
{
    partial class FrmTenista
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.TxtNomeTenista = new MetroFramework.Controls.MetroTextBox();
            this.TxtContatoTenista = new MetroFramework.Controls.MetroTextBox();
            this.TxtUTRTenista = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            this.metroPanel1.Controls.SetChildIndex(this.btnNovo, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnExcluirT, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnCancelar, 0);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
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
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(38, 85);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Name:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(38, 145);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Contact:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(38, 204);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(36, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "UTR:";
            // 
            // TxtNomeTenista
            // 
            this.TxtNomeTenista.Location = new System.Drawing.Point(120, 85);
            this.TxtNomeTenista.Name = "TxtNomeTenista";
            this.TxtNomeTenista.Size = new System.Drawing.Size(215, 23);
            this.TxtNomeTenista.TabIndex = 3;
            // 
            // TxtContatoTenista
            // 
            this.TxtContatoTenista.Location = new System.Drawing.Point(120, 145);
            this.TxtContatoTenista.Name = "TxtContatoTenista";
            this.TxtContatoTenista.Size = new System.Drawing.Size(215, 23);
            this.TxtContatoTenista.TabIndex = 4;
            // 
            // TxtUTRTenista
            // 
            this.TxtUTRTenista.Location = new System.Drawing.Point(120, 200);
            this.TxtUTRTenista.Name = "TxtUTRTenista";
            this.TxtUTRTenista.Size = new System.Drawing.Size(215, 23);
            this.TxtUTRTenista.TabIndex = 5;
            // 
            // FrmTenista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(617, 411);
            this.Controls.Add(this.TxtUTRTenista);
            this.Controls.Add(this.TxtContatoTenista);
            this.Controls.Add(this.TxtNomeTenista);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmTenista";
            this.Text = "Register a player";
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.TxtNomeTenista, 0);
            this.Controls.SetChildIndex(this.TxtContatoTenista, 0);
            this.Controls.SetChildIndex(this.TxtUTRTenista, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox TxtNomeTenista;
        private MetroFramework.Controls.MetroTextBox TxtContatoTenista;
        private MetroFramework.Controls.MetroTextBox TxtUTRTenista;
    }
}