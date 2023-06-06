using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_TCR.View
{
    public partial class FrmBase : MetroFramework.Forms.MetroForm
    {
        public FrmBase()
        {
            InitializeComponent();
        }
        protected string status = "Navegando";
        protected void HabilitaControle()
        {
            btnNovo.Enabled = (status == "Navegando");
            btnPesquisar.Enabled = (status == "Navegando");
            BtnSalvar.Enabled = (status == "Inserindo" || status == "Editando");
            BtnExcluirT.Enabled = (status == "Editando");

            if (status == "Inserindo" || status == "Editando")
            {
                foreach(Control ctr in this.Controls)
                {
                    if(ctr is MetroFramework.Controls.MetroTextBox || ctr is MetroFramework.Controls.MetroComboBox)
                    {
                        ctr.Enabled = true;
                    }
                }
            }
            else
            {
                foreach (Control ctr in this.Controls)
                {
                    if (ctr is MetroFramework.Controls.MetroTextBox || ctr is MetroFramework.Controls.MetroComboBox)
                    {
                        ctr.Enabled = false;
                    }
                }
            }
        }

        protected void LimpaControle()
        {
            foreach (Control ctr in this.Controls)
            {
                if (ctr is MetroFramework.Controls.MetroTextBox)
                {
                    ctr.Text = "";
                }
            }
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
            LimpaControle();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            status = "Inserindo";
            HabilitaControle();
            LimpaControle();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            status = "Navegando";
            HabilitaControle();
            LimpaControle();
        }
    }
}
