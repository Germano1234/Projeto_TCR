namespace Projeto_TCR
{
    partial class FrmProfessor
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
            this.TxtContatoProfessor = new MetroFramework.Controls.MetroTextBox();
            this.TxtNomeProfessor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtNivelProfessor = new MetroFramework.Controls.MetroComboBox();
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
            // TxtContatoProfessor
            // 
            this.TxtContatoProfessor.Location = new System.Drawing.Point(117, 148);
            this.TxtContatoProfessor.Name = "TxtContatoProfessor";
            this.TxtContatoProfessor.Size = new System.Drawing.Size(215, 23);
            this.TxtContatoProfessor.TabIndex = 10;
            // 
            // TxtNomeProfessor
            // 
            this.TxtNomeProfessor.Location = new System.Drawing.Point(117, 88);
            this.TxtNomeProfessor.Name = "TxtNomeProfessor";
            this.TxtNomeProfessor.Size = new System.Drawing.Size(215, 23);
            this.TxtNomeProfessor.TabIndex = 9;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(35, 207);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(41, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Level:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(35, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "Contact:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(35, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(48, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Name:";
            // 
            // TxtNivelProfessor
            // 
            this.TxtNivelProfessor.FormattingEnabled = true;
            this.TxtNivelProfessor.ItemHeight = 23;
            this.TxtNivelProfessor.Items.AddRange(new object[] {
            "Begginer",
            "Intermediate",
            "Advanced"});
            this.TxtNivelProfessor.Location = new System.Drawing.Point(117, 197);
            this.TxtNivelProfessor.Name = "TxtNivelProfessor";
            this.TxtNivelProfessor.Size = new System.Drawing.Size(209, 29);
            this.TxtNivelProfessor.TabIndex = 11;
            // 
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(627, 404);
            this.Controls.Add(this.TxtNivelProfessor);
            this.Controls.Add(this.TxtContatoProfessor);
            this.Controls.Add(this.TxtNomeProfessor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmProfessor";
            this.Text = "Register a Teacher";
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.TxtNomeProfessor, 0);
            this.Controls.SetChildIndex(this.TxtContatoProfessor, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.TxtNivelProfessor, 0);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox TxtContatoProfessor;
        private MetroFramework.Controls.MetroTextBox TxtNomeProfessor;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox TxtNivelProfessor;
    }
}