using itInventor.selOborudDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itInventor
{
    public partial class EditUser : Form
    {
        int indPass;
        string knName;
        int kod;
        string model;
        string parameters;
        string serNum;
        //int ind;  
        


        public EditUser(DataSet selOb, int indPass, int kod, string model, string parameters, string serNum)
        {
            this.indPass = indPass; //
            //this.knName = knName; // вид устройства 
            this.kod = kod;         // значение выбранного подразделения
            this.model = model;     // значение поля Модель
            this.parameters = parameters;
            this.serNum = serNum;
            //this.ind = ind;

            //DataSet selOborudDataSet = selOb;

            InitializeComponent();
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sortPoPodrDataSet.users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.sortPoPodrDataSet.users, kod); // пользователи по подразделениям       
            // TODO: данная строка кода позволяет загрузить данные в таблицу "postDataSet.post". При необходимости она может быть перемещена или удалена.
            this.postTableAdapter.Fill(this.postDataSet.post);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "prodDataSet.producer". При необходимости она может быть перемещена или удалена.
            this.producerTableAdapter.Fill(this.prodDataSet.producer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kindDataSet.kind". При необходимости она может быть перемещена или удалена.
            this.kindTableAdapter.Fill(this.kindDataSet.kind);

            textBox1.Text = indPass.ToString();
            //cbKind.Text = knName;

            //txModel.Text = objectsTableAdapter.Fill(editObject.objects.modelColumn.Table, indPass);
            txModel.Text = model;
            txParam.Text = parameters;
            txSNo.Text = serNum;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fOborud fOb = new fOborud();
            //objectsTableAdapter.Update(objectsDataSet);  

            try
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                    CommandText = "updateOborud",
                    CommandType = CommandType.StoredProcedure
                };

                cmd.Parameters.AddWithValue("@indPass", indPass);

                cmd.Parameters.AddWithValue("@objNote", txParam.Text); // параметры
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

                //objectsTableAdapter.Fill(objectsDataSet.objects);
                

                //fOb.grData.DataSource = selOborudBindingSource;
                //SelObjects();
                //fOb.fOborud_Load(sender, e);
                //selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);

                MessageBox.Show("Успешно обновлено");

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Close();
        }

        public void SelObjects()
        {
            SqlCommand cmd = new SqlCommand
            {
                Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                CommandText = "selOborud",
                CommandType = CommandType.StoredProcedure
            };

            cmd.Parameters.AddWithValue("@kod", kod);

            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
        }

    }
}
