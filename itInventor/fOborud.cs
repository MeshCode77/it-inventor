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
    public partial class fOborud : Form
    {
        int indPass;    // индекс выбранный для редактирования записи
        //string knName;  // вид устройства
        int kod;        // код выбраный в trPodr
        string model;    // модель
        string parameters;
        string serNum;
        int ind;
        int tempind;
        
        public int Ind
        { 
            get
            {
                return ind;
            }
        }



        public fOborud()
        {
            InitializeComponent();

            grData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
        
        }

        private void fOborud_Load(object sender, EventArgs e)
        {
            SqlCommand selPodr = new SqlCommand
            {
                Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                CommandType = CommandType.StoredProcedure,
                CommandText = "selPodr"
            };

            selPodr.Connection.Open();
            SqlDataReader podrData = selPodr.ExecuteReader();
            if (podrData.HasRows)
            {
                while (podrData.Read())
                {
                    int kod = podrData.GetInt32(0);
                    string pName = podrData.GetString(1);

                    TreeNode tnod = new TreeNode(pName);
                    tnod.Tag = kod;
                    trPodr.Nodes.Add(tnod);

                }
            }

            selPodr.Connection.Close();          
        }

        private void trPodr_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            kod = (int)e.Node.Tag; // выбираем код подразделения

            selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod); // заполняем таблицу данными согласно выбранного кода подразделения
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {            
            EditUser eUser = new EditUser(selOborudDataSet, indPass, kod, model, parameters, serNum);
            eUser.ShowDialog();
            
            grData.CellEnter -= new System.Windows.Forms.DataGridViewCellEventHandler(grData_CellEnter); // отк событие

            selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);
              
            grData.CurrentCell = grData[columnIndex: 0, rowIndex: ind]; // установить курсор на редактируемую строку
           
            grData.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(grData_CellEnter); // вкл событие
        }

        private void grData_CellEnter(object sender, DataGridViewCellEventArgs e)
        {           
            
            // передаем только значения текстовых полей
            indPass = (int)grData.CurrentRow.Cells[0].Value;      // получить значение 0 ячейки строки
            //knName = grData.CurrentRow.Cells[1].Value.ToString(); // получить значение 1 ячейки строки
            model = grData.CurrentRow.Cells[2].Value.ToString();
            parameters = grData.CurrentRow.Cells[7].Value.ToString();
            serNum = grData.CurrentRow.Cells[6].Value.ToString();

            ind = (int)grData.CurrentRow.Index;  // получить индекс выбранной строки

            if (grData.CurrentRow.Index != 0)          // если выбранная строка не равна по индексу 0
            {                        
                grData.CurrentCell = grData[0, ind]; // установить курсор на редактируемую строку                     
            }

            if (grData.CurrentRow.Index == 0)
            {                    
                grData.CurrentCell = grData[0, 0];
            }

            textBox1.Text = grData.CurrentRow.Index.ToString();
            textBox2.Text = grData.CurrentRow.Cells[0].Value.ToString();

        }

        private void grData_SelectionChanged(object sender, EventArgs e)
        {
            //if (grData.CurrentRow.Index != 0)
            //{
            //grData.CurrentCell = grData.Rows[ind].Cells[0];
            //}

            //grData.CurrentCell = grData[0, ind]; // установить курсор на редактируемую строку  
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            kod = (int)trPodr.SelectedNode.Tag;

            if (trPodr.SelectedNode == null) return;

            fOborudAdd frm = new fOborudAdd(kod); // открываем форму добавить оборудование

            frm.ShowDialog();

            if (frm.DialogResult == DialogResult.OK)
            {               
                selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);
            }
        }

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (grData.Rows[e.RowIndex] == null) return;

            bool rdism, rrem;
            if (DBNull.Equals(grData.Rows[e.RowIndex].Cells["objDism"].Value, DBNull.Value))
                rdism = false;
            else
                rdism = (bool)grData.Rows[e.RowIndex].Cells["objDism"].Value;

            if (DBNull.Equals(grData.Rows[e.RowIndex].Cells["onRemont"].Value, DBNull.Value))
                rrem = false;
            else
                rrem = (bool)grData.Rows[e.RowIndex].Cells["onRemont"].Value;


            if (rdism)
            {
                grData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Coral;
            }
            if(rrem)
            {
                grData.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow;
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if (grData.CurrentRow == null) return;

            bool rdism, rrem;
            if (DBNull.Equals(grData.CurrentRow.Cells["objDism"].Value, DBNull.Value))
                rdism = false;
            else
                rdism = (bool)grData.CurrentRow.Cells["objDism"].Value;

            if (DBNull.Equals(grData.CurrentRow.Cells["onRemont"].Value, DBNull.Value))
                rrem = false;
            else
                rrem = (bool)grData.CurrentRow.Cells["onRemont"].Value;


            if (rdism)
            {
                MessageBox.Show("Данное устройство снято с учета!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rrem)
            {
                MessageBox.Show("Данное устройство уже в ремонте!", Text, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(MessageBox.Show("Отметить выбранное устройство как нуждающееся в ремонте?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) 
                == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "chkToRemont"
                };

                cmd.Parameters.AddWithValue("@obNo", (int)grData.CurrentRow.Cells["objNo"].Value);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                int kod = (int)trPodr.SelectedNode.Tag;
                selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);
            }
        }

        //private void trPodr_Click(object sender, EventArgs e)
        //{
           
        //}

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (grData.CurrentRow == null) return;

            if (MessageBox.Show("Удалить выбранное устройство?", Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand
                {
                    Connection = new SqlConnection(Properties.Settings.Default.itInventorConnectionString),
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "delOborud"
                };

                cmd.Parameters.AddWithValue("@objNo", (int)grData.CurrentRow.Cells["objNo"].Value);

                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                int kod = (int)trPodr.SelectedNode.Tag;
                selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);
            }
        }

        //private void toolStripButton4_Click(object sender, EventArgs e)
        //{
        //    EditUser eUser = new EditUser(indPass, kod, model, parameters, serNum);
        //    eUser.ShowDialog();

        //    if (eUser.DialogResult == DialogResult.OK)
        //    {
        //        //trPodr_NodeMouseClick(sender, (TreeNodeMouseClickEventArgs)e);
        //        //selOborudTableAdapter.Fill(selOborudDataSet.selOborud, kod);
        //    }
        //}

        

        private void grData_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //grData.CurrentCell = grData[0, ind]; // установить курсор на редактируемую строку
        }

        
    }
}
