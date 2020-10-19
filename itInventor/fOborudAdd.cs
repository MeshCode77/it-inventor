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
    public partial class fOborudAdd : Form
    {
        int kod;
        public fOborudAdd(int kod)
        {
            this.kod = kod;

            InitializeComponent();
        }

        private void fOborudAdd_Load(object sender, EventArgs e)
        {           
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.postDataSet.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prodDataSet.producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.prodDataSet.producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindDataSet.kind". При необходимости она может быть перемещена или удалена.
            this.kindTableAdapter.Fill(this.kindDataSet.kind);

            this.usersTableAdapter.Fill(this.sortPoPodrDataSet.users, kod);

            dtEnter.Value = DateTime.Now.Date;
            dtGarant.Value = DateTime.Now.Date.AddYears(1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                CommandText = "insertOborud",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@objNote", txParam.Text);
            cmd.Parameters.AddWithValue("@cost", nuCost.Value);
            cmd.Parameters.AddWithValue("@objDate", dtEnter.Value.Date);
            cmd.Parameters.AddWithValue("@garantDate", dtGarant.Value.Date);
            cmd.Parameters.AddWithValue("@model", txModel.Text);
            cmd.Parameters.AddWithValue("@sNo", txSNo.Text);
            cmd.Parameters.AddWithValue("@id_us", cbUser.SelectedValue);
            cmd.Parameters.AddWithValue("@id_kn", cbKind.SelectedValue);
            cmd.Parameters.AddWithValue("@id_ps", cbPost.SelectedValue);
            cmd.Parameters.AddWithValue("@id_pr", cbProd.SelectedValue);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();

        }
    }
}
