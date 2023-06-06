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
    public partial class FrmPesquisaQuadra : MetroFramework.Forms.MetroForm
    {
        public FrmPesquisaQuadra()
        {
            InitializeComponent();
        }
        private RQuadra rq = new RQuadra();
        public int id;

        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rq.Get(txtPesquisaNome.Text);
        }


        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            Close();
        }
    }
}
