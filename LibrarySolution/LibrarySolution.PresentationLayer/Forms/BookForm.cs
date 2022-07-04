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
    public partial class BookForm : Form
    {
        public BookForm()
        {
            InitializeComponent();
        }
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        PublisherBusiness publisherBusiness = new PublisherBusiness();
        BookBusiness bookBusiness = new BookBusiness();

        private void BindCategories()
        {
            var categories= categoryBusiness.GetAll();
            categories.Insert(0, new DataLayer.BookCategory
            {
                CategoryId=0,
                CategoryName="Select..."
            });
            cmbCategory.DataSource = categories;
            cmbCategory.DisplayMember = "CategoryName";
            cmbCategory.ValueMember = "CategoryId";
        }

        private void BindPublishers()
        {
            var publishers = publisherBusiness.GetAll();
            publishers.Insert(0, new DataLayer.Publisher
            {
                PublisherId = 0,
                PublisherTitle = "Select..."
            });
            cmbPublisher.DataSource = publishers;
            cmbPublisher.DisplayMember = "PublisherTitle";
            cmbPublisher.ValueMember = "PublisherId";
        }


        private void BookForm_Load(object sender, EventArgs e)
        {
            BindCategories();
            BindPublishers();
            List();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Book will be saved. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                bookBusiness.Insert(
                    new DataLayer.Book
                    {
                        Title=txtTitle.Text,
                        PublisherDate=dtpPublishDate.Value,
                        AuthorName=txtAuthorName.Text,
                        PageNumber=Convert.ToInt32( nmrPageNumber.Value),
                        CategoryId=Convert.ToInt32(cmbCategory.SelectedValue),
                        PublisherId=Convert.ToInt32(cmbPublisher.SelectedValue),
                        ISBN=txtISBN.Text,
                        LibraryCode=txtLibaryCode.Text,
                        IsAvailable=cbIsAvailable.Checked

                    }
                
                );
                List();
            }
        }

        private void List()
        {
            dgvBooks.DataSource = bookBusiness.GetBooks(); 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Book will be updated. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                bookBusiness.Update(
                    new DataLayer.Book
                    {
                        BookId=Convert.ToInt32(txtId.Text),
                        Title = txtTitle.Text,
                        PublisherDate = dtpPublishDate.Value,
                        AuthorName = txtAuthorName.Text,
                        PageNumber = Convert.ToInt32(nmrPageNumber.Value),
                        CategoryId = Convert.ToInt32(cmbCategory.SelectedValue),
                        PublisherId = Convert.ToInt32(cmbPublisher.SelectedValue),
                        ISBN = txtISBN.Text,
                        LibraryCode = txtLibaryCode.Text,
                        IsAvailable = cbIsAvailable.Checked

                    }

                );
                List();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Book will be deleted. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                bookBusiness.Delete(Convert.ToInt32(txtId.Text));
                List();
            }
        }

        private void dgvBooks_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvBooks.Rows[e.RowIndex].Cells["BookId"].Value.ToString();
            txtTitle.Text = dgvBooks.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            dtpPublishDate.Value =Convert.ToDateTime( dgvBooks.Rows[e.RowIndex].Cells["PublisherDate"].Value);
            txtAuthorName.Text = dgvBooks.Rows[e.RowIndex].Cells["AuthorName"].Value.ToString();
            nmrPageNumber.Value =Convert.ToDecimal( dgvBooks.Rows[e.RowIndex].Cells["PageNumber"].Value);
            cmbCategory.SelectedValue =Convert.ToInt32( dgvBooks.Rows[e.RowIndex].Cells["CategoryId"].Value);
            cmbPublisher.SelectedValue =Convert.ToInt32( dgvBooks.Rows[e.RowIndex].Cells["PublisherId"].Value);
            txtISBN.Text = dgvBooks.Rows[e.RowIndex].Cells["ISBN"].Value.ToString();
            txtLibaryCode.Text = dgvBooks.Rows[e.RowIndex].Cells["LibraryCode"].Value.ToString();
            cbIsAvailable.Checked =Convert.ToBoolean( dgvBooks.Rows[e.RowIndex].Cells["IsAvailable"].Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtTitle.Clear();
            dtpPublishDate.Value = DateTime.Now;
            txtAuthorName.Clear();
            nmrPageNumber.Value = 0;
            cmbCategory.SelectedIndex = 0;
            cmbPublisher.SelectedIndex = 0;
            txtISBN.Clear();
            txtLibaryCode.Clear();
            cbIsAvailable.Checked = false;

        }
    }
}
