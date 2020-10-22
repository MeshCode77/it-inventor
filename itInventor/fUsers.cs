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
    public partial class fUsers : Form
    {
        public fUsers()
        {
            InitializeComponent();
        }

        private void fUsers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "podrDataSet.podr". При необходимости она может быть перемещена или удалена.
            this.podrTableAdapter.Fill(this.podrDataSet.podr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dolgnDataSet.dolgn". При необходимости она может быть перемещена или удалена.
            this.dolgnTableAdapter.Fill(this.dolgnDataSet.dolgn);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "usersDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.usersDataSet.users);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            usersTableAdapter.Update(usersDataSet);
            
        }

        private void bFilter_Click(object sender, EventArgs e)
        {
            if (txFind.Text == string.Empty) return;
            usersBindingSource.Filter = $"usFio LIKE %{txFind.Text.Trim()}%";
        }

        private void bReset_Click(object sender, EventArgs e)
        {
            txFind.Text = usersBindingSource.Filter = string.Empty;
        }
    }
}
