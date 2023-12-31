using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Projeto_TCR.Repository;
using Projeto_TCR.Model;
using Projeto_TCR.View;

namespace Projeto_TCR
{
    public partial class FrmQuadra : FrmBase
    {
        public FrmQuadra()
        {
            InitializeComponent();
        }
        Quadra T = new Quadra();
        RQuadra RT = new RQuadra();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaQuadra fp = new FrmPesquisaQuadra();
            fp.ShowDialog();
            int codigo = fp.id;
            T = RT.GetId(codigo);
            TxtPiso.Text = T.Surface;
            TxtCobertura.Text = T.Covered;
            status = "Editando";
            HabilitaControle();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            T.Surface = TxtPiso.Text;
            T.Covered = TxtCobertura.Text;

            if (status == "Inserindo")
            {
                RT.adiciona(T);
                MessageBox.Show("Court registered!");
            }
            if (status == "Editando")
            {
                RT.altera(T);
                MessageBox.Show("Court's info was changed!");
            }
            LimpaControle();
            status = "Navegando";
            HabilitaControle();
        }

        private void BtnExcluirT_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                RT.exclui(T);
                MessageBox.Show("Court deleted!");
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
            }
        }

        private void BtnFecharT_Click(object sender, EventArgs e)
        {

        }
    }
}
