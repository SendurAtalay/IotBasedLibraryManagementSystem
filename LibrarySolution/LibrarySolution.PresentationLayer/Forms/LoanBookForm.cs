using LibrarySolution.BusinessLayer.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrarySolution.PresentationLayer.Forms
{
    public partial class LoanBookForm : Form
    {
        public LoanBookForm()
        {
            InitializeComponent();

        }

        UserBusiness userBusiness = new UserBusiness();
        BookBusiness bookBusiness = new BookBusiness();
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        PublisherBusiness publisherBusiness = new PublisherBusiness();
        LoanBusiness loanBusiness = new LoanBusiness();
        SerialPort serialPort;

        private void LoanBookForm_Load(object sender, EventArgs e)
        {
            BindUser();
            serialPort = new SerialPort("COM5");
            serialPort.Open();
            serialPort.DataReceived += SerialPort_DataReceived;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var serialport = (SerialPort)sender;
            var data = serialPort.ReadLine().Replace("\r", "").Trim();
            txtLibaryCode.Invoke((Action)(() => txtLibaryCode.Text = data));
            var book = bookBusiness.Get(b => b.LibraryCode == txtLibaryCode.Text);
            if (book != null)
            {
                txtId.Invoke((Action)(() => txtId.Text = book.BookId.ToString()));
                txtTitle.Invoke((Action)(() => txtTitle.Text = book.Title));
                txtAuthorName.Invoke((Action)(() => txtAuthorName.Text = book.AuthorName));
                txtCategory.Invoke((Action)(() => txtCategory.Text = categoryBusiness.GetById((int)book.CategoryId).CategoryName));
                txtPublisher.Invoke((Action)(() => txtPublisher.Text = publisherBusiness.GetById((int)book.CategoryId).PublisherTitle));
                txtISBN.Invoke((Action)(() => txtISBN.Text = book.ISBN.ToString()));
                dtpPublishDate.Invoke((Action)(() => dtpPublishDate.Value = (DateTime)book.PublisherDate));
                nmrPageNumber.Invoke((Action)(() => nmrPageNumber.Value = (decimal)book.PageNumber));
                cbIsAvailable.Invoke((Action)(() => cbIsAvailable.Checked = (bool)book.IsAvailable));
                if((bool)book.IsAvailable)
                    btnLoanItem.Invoke((Action)(() => btnLoanItem.Enabled = true));
                else
                    btnLoanItem.Invoke((Action)(() => btnLoanItem.Enabled = false));
            }

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

        private void cmbUserId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserId.SelectedIndex > 0)
            {
                var user = cmbUserId.SelectedItem as DataLayer.User;
                txtUserName.Text = user.UserName;

                txtFirstName.Text = user.FirstName;
                txtLastName.Text = user.LastName;

            }
        }

        private void LoanBookForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            serialPort.Close();
        }

        private void btnLoanItem_Click(object sender, EventArgs e)
        {
            loanBusiness.Insert(new DataLayer.Loan
            {
                UserId = Convert.ToInt32(cmbUserId.SelectedValue),
                BookId = Convert.ToInt32(txtId.Text),
                BeginDate = dtpBeginDate.Value,
                EndDate = dtpEndDate.Value,
                IsReturned = false
            });
        }
    }
}
