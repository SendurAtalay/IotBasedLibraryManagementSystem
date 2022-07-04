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
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        CategoryBusiness categoryBusiness = new CategoryBusiness();
        private void List()
        {
            dgvCategories.DataSource = categoryBusiness.GetAll();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            List();
        }

        private void dgvCategories_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryId"].Value.ToString();
            txtName.Text = dgvCategories.Rows[e.RowIndex].Cells["CategoryName"].Value.ToString();
            txtDesc.Text = dgvCategories.Rows[e.RowIndex].Cells["Description"].Value.ToString();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Category will be saved. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                categoryBusiness.Insert(new DataLayer.BookCategory
                {
                    CategoryName = txtName.Text,
                    Description = txtDesc.Text
                });
                List();
            }


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtName.Clear();
            txtDesc.Clear();
            dgvCategories.ClearSelection();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Category will be updated. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                categoryBusiness.Update(new DataLayer.BookCategory
                {
                    CategoryId = Convert.ToInt32(txtId.Text),
                    CategoryName = txtName.Text,
                    Description = txtDesc.Text
                });

                List();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var q = MessageBox.Show("Category will be removed. Are you sure?", "Approve", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3);
            if (q == DialogResult.Yes)
            {
                categoryBusiness.Delete(Convert.ToInt32(txtId.Text));
                List();
            }
        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvCategories_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
