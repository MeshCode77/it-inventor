namespace itInventor
{
    partial class fOborudAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbUser = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sortPoPodrDataSet = new itInventor.SortPoPodrDataSet();
            this.txSNo = new System.Windows.Forms.TextBox();
            this.txParam = new System.Windows.Forms.TextBox();
            this.nuCost = new System.Windows.Forms.NumericUpDown();
            this.dtGarant = new System.Windows.Forms.DateTimePicker();
            this.dtEnter = new System.Windows.Forms.DateTimePicker();
            this.cbPost = new System.Windows.Forms.ComboBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.postDataSet = new itInventor.postDataSet();
            this.label10 = new System.Windows.Forms.Label();
            this.cbProd = new System.Windows.Forms.ComboBox();
            this.producerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodDataSet = new itInventor.prodDataSet();
            this.txModel = new System.Windows.Forms.TextBox();
            this.cbKind = new System.Windows.Forms.ComboBox();
            this.kindBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindDataSet = new itInventor.kindDataSet();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.kindTableAdapter = new itInventor.kindDataSetTableAdapters.kindTableAdapter();
            this.producerTableAdapter = new itInventor.prodDataSetTableAdapters.producerTableAdapter();
            this.postTableAdapter = new itInventor.postDataSetTableAdapters.postTableAdapter();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new itInventor.SortPoPodrDataSetTableAdapters.TableAdapterManager();
            this.usersTableAdapter = new itInventor.SortPoPodrDataSetTableAdapters.usersTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPoPodrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbUser);
            this.groupBox1.Controls.Add(this.txSNo);
            this.groupBox1.Controls.Add(this.txParam);
            this.groupBox1.Controls.Add(this.nuCost);
            this.groupBox1.Controls.Add(this.dtGarant);
            this.groupBox1.Controls.Add(this.dtEnter);
            this.groupBox1.Controls.Add(this.cbPost);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.cbProd);
            this.groupBox1.Controls.Add(this.txModel);
            this.groupBox1.Controls.Add(this.cbKind);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 281);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbUser
            // 
            this.cbUser.DataSource = this.usersBindingSource;
            this.cbUser.DisplayMember = "usFio";
            this.cbUser.FormattingEnabled = true;
            this.cbUser.Location = new System.Drawing.Point(109, 250);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(195, 21);
            this.cbUser.TabIndex = 19;
            this.cbUser.ValueMember = "id_us";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.sortPoPodrDataSet;
            // 
            // sortPoPodrDataSet
            // 
            this.sortPoPodrDataSet.DataSetName = "SortPoPodrDataSet";
            this.sortPoPodrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txSNo
            // 
            this.txSNo.Location = new System.Drawing.Point(109, 224);
            this.txSNo.MaxLength = 30;
            this.txSNo.Name = "txSNo";
            this.txSNo.Size = new System.Drawing.Size(195, 20);
            this.txSNo.TabIndex = 18;
            // 
            // txParam
            // 
            this.txParam.Location = new System.Drawing.Point(109, 198);
            this.txParam.MaxLength = 50;
            this.txParam.Name = "txParam";
            this.txParam.Size = new System.Drawing.Size(365, 20);
            this.txParam.TabIndex = 17;
            // 
            // nuCost
            // 
            this.nuCost.DecimalPlaces = 2;
            this.nuCost.Location = new System.Drawing.Point(109, 172);
            this.nuCost.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuCost.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuCost.Name = "nuCost";
            this.nuCost.Size = new System.Drawing.Size(126, 20);
            this.nuCost.TabIndex = 16;
            this.nuCost.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // dtGarant
            // 
            this.dtGarant.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtGarant.Location = new System.Drawing.Point(109, 146);
            this.dtGarant.Name = "dtGarant";
            this.dtGarant.Size = new System.Drawing.Size(126, 20);
            this.dtGarant.TabIndex = 15;
            // 
            // dtEnter
            // 
            this.dtEnter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnter.Location = new System.Drawing.Point(109, 120);
            this.dtEnter.Name = "dtEnter";
            this.dtEnter.Size = new System.Drawing.Size(126, 20);
            this.dtEnter.TabIndex = 14;
            // 
            // cbPost
            // 
            this.cbPost.DataSource = this.postBindingSource;
            this.cbPost.DisplayMember = "psName";
            this.cbPost.FormattingEnabled = true;
            this.cbPost.Location = new System.Drawing.Point(109, 93);
            this.cbPost.Name = "cbPost";
            this.cbPost.Size = new System.Drawing.Size(195, 21);
            this.cbPost.TabIndex = 13;
            this.cbPost.ValueMember = "id_ps";
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataMember = "post";
            this.postBindingSource.DataSource = this.postDataSet;
            // 
            // postDataSet
            // 
            this.postDataSet.DataSetName = "postDataSet";
            this.postDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 253);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Ответственный";
            // 
            // cbProd
            // 
            this.cbProd.DataSource = this.producerBindingSource;
            this.cbProd.DisplayMember = "prName";
            this.cbProd.FormattingEnabled = true;
            this.cbProd.Location = new System.Drawing.Point(109, 66);
            this.cbProd.Name = "cbProd";
            this.cbProd.Size = new System.Drawing.Size(195, 21);
            this.cbProd.TabIndex = 11;
            this.cbProd.ValueMember = "id_pr";
            // 
            // producerBindingSource
            // 
            this.producerBindingSource.DataMember = "producer";
            this.producerBindingSource.DataSource = this.prodDataSet;
            // 
            // prodDataSet
            // 
            this.prodDataSet.DataSetName = "prodDataSet";
            this.prodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txModel
            // 
            this.txModel.Location = new System.Drawing.Point(109, 40);
            this.txModel.Name = "txModel";
            this.txModel.Size = new System.Drawing.Size(195, 20);
            this.txModel.TabIndex = 10;
            // 
            // cbKind
            // 
            this.cbKind.DataSource = this.kindBindingSource;
            this.cbKind.DisplayMember = "knName";
            this.cbKind.FormattingEnabled = true;
            this.cbKind.Location = new System.Drawing.Point(109, 13);
            this.cbKind.Name = "cbKind";
            this.cbKind.Size = new System.Drawing.Size(195, 21);
            this.cbKind.TabIndex = 9;
            this.cbKind.ValueMember = "id_kn";
            // 
            // kindBindingSource
            // 
            this.kindBindingSource.DataMember = "kind";
            this.kindBindingSource.DataSource = this.kindDataSet;
            // 
            // kindDataSet
            // 
            this.kindDataSet.DataSetName = "kindDataSet";
            this.kindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Серийный №";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Параметры";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Гарантия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ввод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Поставщик";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Производитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Модель";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вид";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(498, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(498, 270);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // kindTableAdapter
            // 
            this.kindTableAdapter.ClearBeforeFill = true;
            // 
            // producerTableAdapter
            // 
            this.producerTableAdapter.ClearBeforeFill = true;
            // 
            // postTableAdapter
            // 
            this.postTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = itInventor.SortPoPodrDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // fOborudAdd
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(579, 300);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "fOborudAdd";
            this.Text = "Новый объект";
            this.Load += new System.EventHandler(this.fOborudAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sortPoPodrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbUser;
        private System.Windows.Forms.TextBox txSNo;
        private System.Windows.Forms.TextBox txParam;
        private System.Windows.Forms.NumericUpDown nuCost;
        private System.Windows.Forms.DateTimePicker dtGarant;
        private System.Windows.Forms.DateTimePicker dtEnter;
        private System.Windows.Forms.ComboBox cbPost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbProd;
        private System.Windows.Forms.TextBox txModel;
        private System.Windows.Forms.ComboBox cbKind;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private kindDataSet kindDataSet;
        private System.Windows.Forms.BindingSource kindBindingSource;
        private kindDataSetTableAdapters.kindTableAdapter kindTableAdapter;
        private prodDataSet prodDataSet;
        private System.Windows.Forms.BindingSource producerBindingSource;
        private prodDataSetTableAdapters.producerTableAdapter producerTableAdapter;
        private postDataSet postDataSet;
        private System.Windows.Forms.BindingSource postBindingSource;
        private postDataSetTableAdapters.postTableAdapter postTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private SortPoPodrDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SortPoPodrDataSet sortPoPodrDataSet;
        private SortPoPodrDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}