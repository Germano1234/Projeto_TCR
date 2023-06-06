namespace Projeto_TCR.View
{
    partial class FrmAgenda
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
            this.dtAgenda = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbHorario = new MetroFramework.Controls.MetroComboBox();
            this.btnProfessor = new MetroFramework.Controls.MetroButton();
            this.btnTenista = new MetroFramework.Controls.MetroButton();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.cbQuadra = new MetroFramework.Controls.MetroComboBox();
            this.BtnQuadras = new MetroFramework.Controls.MetroButton();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Location = new System.Drawing.Point(49, 323);
            this.metroPanel1.Controls.SetChildIndex(this.btnNovo, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnSalvar, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnExcluirT, 0);
            this.metroPanel1.Controls.SetChildIndex(this.BtnCancelar, 0);
            // 
            // BtnExcluirT
            // 
            this.BtnExcluirT.Click += new System.EventHandler(this.BtnExcluirT_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Text = "Schedule";
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Size = new System.Drawing.Size(153, 23);
            this.btnPesquisar.Text = "Delete a match";
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dtAgenda
            // 
            this.dtAgenda.CustomFormat = "dd/MM/yyyy HH";
            this.dtAgenda.Enabled = false;
            this.dtAgenda.Location = new System.Drawing.Point(110, 106);
            this.dtAgenda.Name = "dtAgenda";
            this.dtAgenda.Size = new System.Drawing.Size(200, 20);
            this.dtAgenda.TabIndex = 9;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 106);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(39, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "Date:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(49, 156);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(41, 19);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Time:";
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.ItemHeight = 23;
            this.cbHorario.Items.AddRange(new object[] {
            "07:00",
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00",
            "21:00",
            "22:00"});
            this.cbHorario.Location = new System.Drawing.Point(112, 146);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(113, 29);
            this.cbHorario.TabIndex = 12;
            // 
            // btnProfessor
            // 
            this.btnProfessor.Enabled = false;
            this.btnProfessor.Location = new System.Drawing.Point(49, 256);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(75, 23);
            this.btnProfessor.TabIndex = 13;
            this.btnProfessor.Text = "Teacher";
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnTenista
            // 
            this.btnTenista.Enabled = false;
            this.btnTenista.Location = new System.Drawing.Point(150, 256);
            this.btnTenista.Name = "btnTenista";
            this.btnTenista.Size = new System.Drawing.Size(75, 23);
            this.btnTenista.TabIndex = 14;
            this.btnTenista.Text = "Player";
            this.btnTenista.Click += new System.EventHandler(this.btnTenista_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(248, 256);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(93, 19);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Person renting";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(49, 203);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(46, 19);
            this.metroLabel3.TabIndex = 16;
            this.metroLabel3.Text = "Court:";
            // 
            // cbQuadra
            // 
            this.cbQuadra.FormattingEnabled = true;
            this.cbQuadra.ItemHeight = 23;
            this.cbQuadra.Location = new System.Drawing.Point(112, 193);
            this.cbQuadra.Name = "cbQuadra";
            this.cbQuadra.Size = new System.Drawing.Size(173, 29);
            this.cbQuadra.TabIndex = 17;
            // 
            // BtnQuadras
            // 
            this.BtnQuadras.Enabled = false;
            this.BtnQuadras.Location = new System.Drawing.Point(237, 146);
            this.BtnQuadras.Name = "BtnQuadras";
            this.BtnQuadras.Size = new System.Drawing.Size(136, 29);
            this.BtnQuadras.TabIndex = 18;
            this.BtnQuadras.Text = "Available courts";
            this.BtnQuadras.Click += new System.EventHandler(this.BtnQuadras_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(49, 301);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(83, 19);
            this.lblData.TabIndex = 19;
            this.lblData.Text = "metroLabel4";
            // 
            // FrmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.BtnQuadras);
            this.Controls.Add(this.cbQuadra);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnTenista);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtAgenda);
            this.Name = "FrmAgenda";
            this.Text = "Schedule a match";
            this.Controls.SetChildIndex(this.dtAgenda, 0);
            this.Controls.SetChildIndex(this.metroLabel1, 0);
            this.Controls.SetChildIndex(this.metroLabel2, 0);
            this.Controls.SetChildIndex(this.metroPanel1, 0);
            this.Controls.SetChildIndex(this.btnPesquisar, 0);
            this.Controls.SetChildIndex(this.cbHorario, 0);
            this.Controls.SetChildIndex(this.btnProfessor, 0);
            this.Controls.SetChildIndex(this.btnTenista, 0);
            this.Controls.SetChildIndex(this.lblNome, 0);
            this.Controls.SetChildIndex(this.metroLabel3, 0);
            this.Controls.SetChildIndex(this.cbQuadra, 0);
            this.Controls.SetChildIndex(this.BtnQuadras, 0);
            this.Controls.SetChildIndex(this.lblData, 0);
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtAgenda;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbHorario;
        private MetroFramework.Controls.MetroButton btnProfessor;
        private MetroFramework.Controls.MetroButton btnTenista;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroComboBox cbQuadra;
        private MetroFramework.Controls.MetroButton BtnQuadras;
        private MetroFramework.Controls.MetroLabel lblData;
    }
}