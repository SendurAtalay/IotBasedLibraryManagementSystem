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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }
        UserBusiness userBusiness = new UserBusiness();
        private void List()
        {
            dgvUsers.DataSource = userBusiness.GetAll();
        }


        private void UserForm_Load(object sender, EventArgs e)
        {
            List(); 
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value.ToString();
            txtUserName.Text = dgvUsers.Rows[e.RowIndex].Cells["UserName"].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[e.RowIndex].Cells["UserPassword"].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
            txtLastName.Text = dgvUsers.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            txtRoleName.Text = dgvUsers.Rows[e.RowIndex].Cells["RoleName"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("User will be saved. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                userBusiness.Insert(new DataLayer.User
                {
                    UserName=txtUserName.Text,
                    UserPassword=txtPassword.Text,
                    FirstName=txtFirstName.Text,
                    LastName=txtLastName.Text,
                    RoleName=txtRoleName.Text
                });
                List();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("User will be updated. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                userBusiness.Update(new DataLayer.User
                {
                    UserId=Convert.ToInt32(txtId.Text),
                    UserName = txtUserName.Text,
                    UserPassword = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    RoleName = txtRoleName.Text
                });
                List();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("User will be deleted. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                userBusiness.Delete(Convert.ToInt32(txtId.Text));
                List();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtUserName.Clear();
            txtFirstName.Clear();
            txtPassword.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtRoleName.Clear();
            dgvUsers.ClearSelection();

        }
    }
}
