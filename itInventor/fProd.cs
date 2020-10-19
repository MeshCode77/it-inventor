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
    public partial class fProd : Form
    {
        public fProd()
        {
            InitializeComponent();
        }

        private void fProd_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prodDataSet.producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.prodDataSet.producer);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            producerTableAdapter.Update(prodDataSet);
        }
    }
}
