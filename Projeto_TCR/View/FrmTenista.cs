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
    public partial class FrmTenista : FrmBase
    {
        public FrmTenista()
        {
            InitializeComponent();
        }

        Tenista T = new Tenista();
        RTenista RT = new RTenista();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaTenista fp = new FrmPesquisaTenista();
            fp.ShowDialog();
            int codigo = fp.id;
            T = RT.GetId(codigo);
            TxtNomeTenista.Text = T.Name;
            TxtContatoTenista.Text = T.Contact;
            TxtUTRTenista.Text = T.Utr.ToString();
            status = "Editando";
            HabilitaControle();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            T.Name = TxtNomeTenista.Text;
            T.Contact = TxtContatoTenista.Text;
            T.Utr = Convert.ToDouble(TxtUTRTenista.Text);

            if(status == "Inserindo")
            {
                RT.adiciona(T);
                MessageBox.Show("Registro incluído com sucesso!");
            }
            if(status == "Editando")
            {
                RT.altera(T);
                MessageBox.Show("Registro alterado com sucessso!");
            }
            LimpaControle();
            status = "Navegando";
            HabilitaControle();
        }

        private void BtnExcluirT_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Deseja excluir?","Alerta",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation))
            {
                RT.exclui(T);
                MessageBox.Show("Excluido com sucesso!");
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
            }
        }

        private void BtnFecharT_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
