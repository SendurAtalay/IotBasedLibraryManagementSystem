using LibrarySolution.BusinessLayer.Repository.Concrete;
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
    public partial class LoginForm : Form
    {

        UserBusiness userBusiness = new UserBusiness();

        private MainForm mainForm;
        public LoginForm(MainForm form)
        {
            InitializeComponent();
            this.mainForm = form;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = userBusiness.Get(u => u.UserName == txtUsername.Text && u.UserPassword == txtPassword.Text);
            if (user!=null)
            {
                mainForm.menuStrip1.Visible = true;
                LoanBookForm loan = new LoanBookForm();
                loan.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("User does not exist!!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
