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
    public partial class LoanForm : Form
    {
        public LoanForm()
        {
            InitializeComponent();
        }

        LoanBusiness loanBusiness = new LoanBusiness();
        BookBusiness bookBusiness = new BookBusiness();
        UserBusiness userBusiness = new UserBusiness();



        private void btnInsert_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Loan will be saved. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                loanBusiness.Insert(
                    new DataLayer.Loan
                    {
                        
                        UserId = Convert.ToInt32(cmbUserId.SelectedValue),
                        BookId = Convert.ToInt32(cmbBookId.SelectedValue),
                        BeginDate = dtpBeginDate.Value,
                        EndDate = dtpEndDate.Value,
                        IsReturned = cbIsReturned.Checked
                        
                    });
                list();
            }
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Loan will be updated. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                loanBusiness.Update(
                    new DataLayer.Loan
                    {
                        LoanId = Convert.ToInt32(txtId.Text),
                        UserId = Convert.ToInt32(cmbUserId.SelectedValue),
                        BookId = Convert.ToInt32(cmbBookId.SelectedValue),
                        BeginDate = dtpBeginDate.Value,
                        EndDate = dtpEndDate.Value,
                        IsReturned = cbIsReturned.Checked
                    }
                    );
                list();
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Loan will be deleted. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                loanBusiness.Delete(Convert.ToInt32(txtId.Text));
                list();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            cmbUserId.SelectedIndex = 0;
            cmbBookId.SelectedIndex = 0;
            dtpBeginDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
            cbIsReturned.Checked = false;
        }

      

        private void LoanForm_Load(object sender, EventArgs e)
        {
            BindUser();
            BindBooks();
            list();
        }

        private void BindUser()
        {
            var users = userBusiness.GetAll();
            users.Insert(0, new DataLayer.User
            {
                UserId = 0,
                UserName = "Select..."
            });
            cmbUserId.DataSource = users;
            cmbUserId.DisplayMember = "UserName";
            cmbUserId.ValueMember = "UserId";
        }

        private void BindBooks()
        {
            var books = bookBusiness.GetAll();
            books.Insert(0, new DataLayer.Book
            {
                BookId = 0,
                Title = "Select..."
            });
            cmbBookId.DataSource = books;
            cmbBookId.DisplayMember = "Title";
            cmbBookId.ValueMember = "BookId";
        }

        private void list()
        {
            dgvLoans.DataSource=loanBusiness.GetLoans();
        }

        private void dgvLoans_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvLoans.Rows[e.RowIndex].Cells["LoanId"].Value.ToString();
            cmbUserId.SelectedValue = Convert.ToInt32(dgvLoans.Rows[e.RowIndex].Cells["UserId"].Value);
            cmbBookId.SelectedValue = Convert.ToInt32(dgvLoans.Rows[e.RowIndex].Cells["BookId"].Value);
            dtpBeginDate.Value = Convert.ToDateTime(dgvLoans.Rows[e.RowIndex].Cells["BeginDate"].Value);
            dtpEndDate.Value = Convert.ToDateTime(dgvLoans.Rows[e.RowIndex].Cells["EndDate"].Value);
            cbIsReturned.Checked = Convert.ToBoolean(dgvLoans.Rows[e.RowIndex].Cells["IsReturned"].Value);

            


        }
    }

}