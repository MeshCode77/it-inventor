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
    public partial class fPodr : Form
    {
        public fPodr()
        {
            InitializeComponent();
        }

        private void fPodr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "podrDataSet.podr". При необходимости она может быть перемещена или удалена.
            this.podrTableAdapter.Fill(this.podrDataSet.podr);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            podrTableAdapter.Update(podrDataSet.podr);
        }
    }
}
