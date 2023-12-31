using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_TCR.View;
using Projeto_TCR.Model;
using Projeto_TCR.Repository;

namespace Projeto_TCR
{
    public partial class FrmProfessor : FrmBase
    {
        public FrmProfessor()
        {
            InitializeComponent();
        }
        Professor T = new Professor();
        RProfessor RT = new RProfessor();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaProfessor fp = new FrmPesquisaProfessor();
            fp.ShowDialog();
            int codigo = fp.id;
            T = RT.GetId(codigo);
            TxtNomeProfessor.Text = T.Name;
            TxtContatoProfessor.Text = T.Contact;
            TxtNivelProfessor.Text = T.Level;
            status = "Editando";
            HabilitaControle();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            T.Name = TxtNomeProfessor.Text;
            T.Contact = TxtContatoProfessor.Text;
            T.Level = TxtNivelProfessor.Text;

            if (status == "Inserindo")
            {
                RT.adiciona(T);
                MessageBox.Show("Professor regitered!");
            }
            if (status == "Editando")
            {
                RT.altera(T);
                MessageBox.Show("Professor's info was changed!");
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
                MessageBox.Show("Professor deleted!");
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
