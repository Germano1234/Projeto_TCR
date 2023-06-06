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

namespace Projeto_TCR
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tenistaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTenista fTenista = new FrmTenista();
            fTenista.ShowDialog();

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor fProfessor = new FrmProfessor();
            fProfessor.ShowDialog();
        }

        private void quadraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQuadra fQuadra = new FrmQuadra();
            fQuadra.ShowDialog();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda fAgenda = new FrmAgenda();
            fAgenda.ShowDialog();
        }

        private void agendaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmPesquisaAgenda fa = new FrmPesquisaAgenda();
            fa.ShowDialog();
        }
    }
}
