namespace itInventor
{
    partial class fMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mUchet = new System.Windows.Forms.ToolStripMenuItem();
            this.mOborud = new System.Windows.Forms.ToolStripMenuItem();
            this.mRemont = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mSprav = new System.Windows.Forms.ToolStripMenuItem();
            this.mPolz = new System.Windows.Forms.ToolStripMenuItem();
            this.mOtdel = new System.Windows.Forms.ToolStripMenuItem();
            this.mDolgn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mKind = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mProizv = new System.Windows.Forms.ToolStripMenuItem();
            this.mPost = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 608);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1034, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUchet,
            this.mSprav});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1034, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mUchet
            // 
            this.mUchet.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mOborud,
            this.mRemont,
            this.toolStripMenuItem3,
            this.mExit});
            this.mUchet.Name = "mUchet";
            this.mUchet.Size = new System.Drawing.Size(44, 20);
            this.mUchet.Text = "Учет";
            // 
            // mOborud
            // 
            this.mOborud.Name = "mOborud";
            this.mOborud.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mOborud.Size = new System.Drawing.Size(249, 22);
            this.mOborud.Text = "Оборудование";
            this.mOborud.Click += new System.EventHandler(this.mOborud_Click);
            // 
            // mRemont
            // 
            this.mRemont.Name = "mRemont";
            this.mRemont.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.mRemont.Size = new System.Drawing.Size(221, 22);
            this.mRemont.Text = "Ремонт / Списание";
            this.mRemont.Click += new System.EventHandler(this.mRemont_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(246, 6);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mExit.Size = new System.Drawing.Size(249, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // mSprav
            // 
            this.mSprav.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPolz,
            this.mOtdel,
            this.mDolgn,
            this.toolStripMenuItem1,
            this.mKind,
            this.toolStripMenuItem2,
            this.mProizv,
            this.mPost});
            this.mSprav.Name = "mSprav";
            this.mSprav.Size = new System.Drawing.Size(94, 20);
            this.mSprav.Text = "Справочники";
            // 
            // mPolz
            // 
            this.mPolz.Name = "mPolz";
            this.mPolz.Size = new System.Drawing.Size(229, 22);
            this.mPolz.Text = "Пользователи / Сотрудники";
            this.mPolz.Click += new System.EventHandler(this.mPolz_Click);
            // 
            // mOtdel
            // 
            this.mOtdel.Name = "mOtdel";
            this.mOtdel.Size = new System.Drawing.Size(229, 22);
            this.mOtdel.Text = "Подразделения / Отделы";
            this.mOtdel.Click += new System.EventHandler(this.mOtdel_Click);
            // 
            // mDolgn
            // 
            this.mDolgn.Name = "mDolgn";
            this.mDolgn.Size = new System.Drawing.Size(229, 22);
            this.mDolgn.Text = "Должности";
            this.mDolgn.Click += new System.EventHandler(this.mDolgn_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 6);
            // 
            // mKind
            // 
            this.mKind.Name = "mKind";
            this.mKind.Size = new System.Drawing.Size(229, 22);
            this.mKind.Text = "Виды устройств";
            this.mKind.Click += new System.EventHandler(this.mKind_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(226, 6);
            // 
            // mProizv
            // 
            this.mProizv.Name = "mProizv";
            this.mProizv.Size = new System.Drawing.Size(229, 22);
            this.mProizv.Text = "Производители";
            this.mProizv.Click += new System.EventHandler(this.mProizv_Click);
            // 
            // mPost
            // 
            this.mPost.Name = "mPost";
            this.mPost.Size = new System.Drawing.Size(229, 22);
            this.mPost.Text = "Поставщики";
            this.mPost.Click += new System.EventHandler(this.mPost_Click);
            // 
            // fMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 630);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IT - Инвентор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mUchet;
        private System.Windows.Forms.ToolStripMenuItem mOborud;
        private System.Windows.Forms.ToolStripMenuItem mRemont;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mExit;
        private System.Windows.Forms.ToolStripMenuItem mSprav;
        private System.Windows.Forms.ToolStripMenuItem mPolz;
        private System.Windows.Forms.ToolStripMenuItem mOtdel;
        private System.Windows.Forms.ToolStripMenuItem mDolgn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mKind;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mProizv;
        private System.Windows.Forms.ToolStripMenuItem mPost;
    }
}

