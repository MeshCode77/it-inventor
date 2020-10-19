using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itInventor
{
    public partial class fDolgn : Form
    {
        public fDolgn()
        {
            InitializeComponent();
        }

        private void fDolgn_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dolgnDataSet.dolgn". При необходимости она может быть перемещена или удалена.
            this.dolgnTableAdapter.Fill(this.dolgnDataSet.dolgn);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            dolgnTableAdapter.Update(dolgnDataSet);
        }
    }
}
