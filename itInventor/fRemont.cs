using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace itInventor
{
    public partial class fRemont : Form
    {
        public fRemont()
        {
            InitializeComponent();
        }

        private void fRemont_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "objOnRemontDataSet.objOnRemont". При необходимости она может быть перемещена или удалена.
            this.objOnRemontTableAdapter.Fill(this.objOnRemontDataSet.objOnRemont);

            txYear.Text = DateTime.Now.Year.ToString();
            cbMonth.ComboBox.SelectedIndex = DateTime.Now.Month - 1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (grRemont.CurrentRow == null) return;

            SqlCommand cmd = new SqlCommand
            {
                Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                CommandText = "objRemReady",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@objNo", grRemont.CurrentRow.Cells["objNo"].Value);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            this.objOnRemontTableAdapter.Fill(this.objOnRemontDataSet.objOnRemont);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grRemont.CurrentRow == null) return;

            SqlCommand cmd = new SqlCommand
            {
                Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                CommandText = "objRemDism",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@objNo", grRemont.CurrentRow.Cells["objNo"].Value);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

            this.objOnRemontTableAdapter.Fill(this.objOnRemontDataSet.objOnRemont);
        }

        private void txYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) || !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
