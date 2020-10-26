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
    public partial class fMainForm : Form
    {

        public fMainForm()
        {
            InitializeComponent();
        }

        private void mExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mOtdel_Click(object sender, EventArgs e)
        {
            fPodr frm = new fPodr();

            frm.Text = mOtdel.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mDolgn_Click(object sender, EventArgs e)
        {
            fDolgn frm = new fDolgn();

            frm.Text = mDolgn.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mKind_Click(object sender, EventArgs e)
        {
            fKind frm = new fKind();

            frm.Text = mKind.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mProizv_Click(object sender, EventArgs e)
        {
            fProd frm = new fProd();

            frm.Text = mProizv.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mPost_Click(object sender, EventArgs e)
        {
            fPost frm = new fPost();

            frm.Text = mPost.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mPolz_Click(object sender, EventArgs e)
        {
            fUsers frm = new fUsers();

            frm.Text = mPolz.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mOborud_Click(object sender, EventArgs e)
        {           
            fOborud frm = new fOborud();

            frm.Text = mOborud.Text;
            frm.MdiParent = this;
            frm.Show();
        }

        private void mRemont_Click(object sender, EventArgs e)
        {
            fRemont frm = new fRemont();

            frm.Text = mRemont.Text;
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
