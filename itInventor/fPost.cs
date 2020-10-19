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
    public partial class fPost : Form
    {
        public fPost()
        {
            InitializeComponent();
        }

        private void fPost_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.postDataSet.post);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            postTableAdapter.Update(postDataSet);
        }
    }
}
