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

namespace Projeto_TCR.View
{
    public partial class FrmAgenda : FrmBase
    {
        public FrmAgenda()
        {
            InitializeComponent();
            lblData.Text = "";
        }
        Professor P = new Professor();
        RProfessor RP = new RProfessor();
        Tenista T = new Tenista();
        RTenista RT = new RTenista();
        Agenda A = new Agenda();
        RAgenda RA = new RAgenda();
        public string tipo;
        private void btnProfessor_Click(object sender, EventArgs e)
        {
            FrmPesquisaProfessor fp = new FrmPesquisaProfessor();
            fp.ShowDialog();
            int codigo = fp.id;
            P = RP.GetId(codigo);
            lblNome.Text = P.Name;
            status = "Inserindo";
            tipo = "Aula";
            HabilitaControle();
        }

        private void btnTenista_Click(object sender, EventArgs e)
        {
            FrmPesquisaTenista ft = new FrmPesquisaTenista();
            ft.ShowDialog();
            int codigo = ft.id;
            T = RT.GetId(codigo);
            lblNome.Text = T.Name;
            status = "Inserindo";
            tipo = "Jogo";
            HabilitaControle();
        }

        private void BtnQuadras_Click(object sender, EventArgs e)
        {
            cbQuadra.DataSource = RA.GetQuadra(dtAgenda.Value.Date, cbHorario.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FrmPesquisaAgenda fa = new FrmPesquisaAgenda();
            fa.ShowDialog();
            int codigo = fa.id;
            A = RA.GetId(codigo);
            btnNovo.Enabled = true;
            BtnSalvar.Enabled = false;
            BtnCancelar.Enabled = false;   
            btnProfessor.Enabled = false;
            btnTenista.Enabled = false;
            BtnQuadras.Enabled = false;
            BtnExcluirT.Enabled = true;
            lblData.Text = "Reservada dia: " + A.Data_agenda.ToShortDateString() + " as " + A.Hora1 + " na Quadra " + A.IdQuadra.ToString();
            lblNome.Text = "Reservado por Usuario: " + A.IdUsuario.ToString(); 
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (tipo == "Aula")
            {
                A.Tipo = "Aula";
                A.IdUsuario = P.IdTeacher;
                A.Data_agenda = dtAgenda.Value;
                A.Hora1 = cbHorario.Text;
                A.IdQuadra = int.Parse(cbQuadra.Text);

                if (status == "Inserindo")
                {
                    RA.adiciona(A);
                    MessageBox.Show("Registro incluído com sucesso!");
                }
                if (status == "Editando")
                {
                    RA.altera(A);
                    MessageBox.Show("Registro alterado com sucessso!");
                }
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
                dtAgenda.Enabled = false;
                btnTenista.Enabled = false;
                BtnQuadras.Enabled = false;
                btnProfessor.Enabled = false;

            }
            if (tipo == "Jogo")
            {
                A.Tipo = "Jogo";
                A.IdUsuario = T.IdPlayer;
                A.Data_agenda = dtAgenda.Value;
                A.Hora1 = cbHorario.Text;
                A.IdQuadra = int.Parse(cbQuadra.Text);

                if (status == "Inserindo")
                {
                    RA.adiciona(A);
                    MessageBox.Show("Registro incluído com sucesso!");
                }
                if (status == "Editando")
                {
                    RA.altera(A);
                    MessageBox.Show("Registro alterado com sucessso!");
                }
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
                dtAgenda.Enabled = false;
                btnTenista.Enabled = false;
                BtnQuadras.Enabled = false;
                btnProfessor.Enabled = false;
            }


        }

        private void BtnExcluirT_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("Deseja excluir?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                RA.exclui(A);
                MessageBox.Show("Excluido com sucesso!");
                LimpaControle();
                status = "Navegando";
                HabilitaControle();
                lblData.Text = "";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            lblData.Text = "";
            dtAgenda.Enabled = true;
            btnTenista.Enabled = true;
            BtnQuadras.Enabled = true;
            btnProfessor.Enabled = true;
            BtnCancelar.Enabled = true;
            lblNome.Text = "Locador da Quadra";
        }
    }
}
