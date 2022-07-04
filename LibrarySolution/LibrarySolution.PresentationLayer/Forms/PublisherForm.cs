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
    public partial class PublisherForm : Form
    {
        public PublisherForm()
        {
            InitializeComponent();
        }

        PublisherBusiness publisherBusiness = new PublisherBusiness();

        private void List()
        {
            dgvPublishers.DataSource = publisherBusiness.GetAll();
        }

        private void PublisherForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Publisher will be saved. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                publisherBusiness.Insert(new DataLayer.Publisher
                {
                    PublisherTitle=txtTitle.Text
                });
                List();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Publisher will be updated. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                publisherBusiness.Update(new DataLayer.Publisher
                {
                    PublisherId=Convert.ToInt32(txtId.Text),
                    PublisherTitle = txtTitle.Text
                });
                List();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Publisher will be removed. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                publisherBusiness.Delete(Convert.ToInt32(txtId.Text));
                List();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtTitle.Clear();
            dgvPublishers.ClearSelection();
        }

        private void dgvPublishers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvPublishers.Rows[e.RowIndex].Cells["PublisherId"].Value.ToString();
            txtTitle.Text = dgvPublishers.Rows[e.RowIndex].Cells["PublisherTitle"].Value.ToString();
        }
    }
}
