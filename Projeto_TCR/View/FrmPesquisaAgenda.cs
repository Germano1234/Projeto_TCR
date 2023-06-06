using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projeto_TCR.Repository;

namespace Projeto_TCR.View
{
    public partial class FrmPesquisaAgenda : MetroFramework.Forms.MetroForm
    {
        private RAgenda ra = new RAgenda();
        public int id;
        public FrmPesquisaAgenda()
        {
            InitializeComponent();
            cbNum.DataSource = ra.GetQuadraPesquisa();
        }        

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Close();
        }

        private void btnPesquisa_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ra.Get(dtDia.Value, int.Parse(cbNum.Text));
        }

    }
}
