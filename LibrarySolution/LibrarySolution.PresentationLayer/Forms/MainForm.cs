using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySolution.PresentationLayer.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void listToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.MdiParent = this;
            categoryForm.Show();
        }

        private void listToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            PublisherForm publisherForm = new PublisherForm();
            publisherForm.MdiParent = this;
            publisherForm.Show();
        }

        private void listToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm(); 
            userForm.MdiParent = this;
            userForm.Show();
        }

        private void listToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();
            bookForm.MdiParent = this;
            bookForm.Show();
        }

        private void listToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            LoanForm loanForm = new LoanForm();
            loanForm.MdiParent = this;  
            loanForm.Show();
        }

        private void listToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            LoanBookForm LoanBookForm = new LoanBookForm();
            LoanBookForm.MdiParent = this;
            LoanBookForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(this);
            loginForm.MdiParent = this;
            loginForm.Show();
        }

        private void bookBorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoanBookForm loanBookForm = new LoanBookForm();
            loanBookForm.MdiParent = this;
            loanBookForm.Show();
        }
    }
}
