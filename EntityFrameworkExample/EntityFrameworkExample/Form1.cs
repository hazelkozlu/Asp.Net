using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {

            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            _productDal.Add(
            new Product
            {
                Name = tbxName.Text,
                UnitPrime = Convert.ToDecimal(tbxUnitPrime.Text),
                StockAmount = Convert.ToInt32(tbxStockAmount.Text)
            });
            LoadProducts();
            MessageBox.Show("New product added!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadProducts()
        {
            dgvProducts.DataSource = _productDal.GetAll();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxNameUpdate.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPrimeUpdate.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.Update(
            new Product
            {
                Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                Name = tbxNameUpdate.Text,
                UnitPrime = Convert.ToDecimal(tbxUnitPrimeUpdate.Text),
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text)
            });
            LoadProducts();
            MessageBox.Show("New product updated!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            _productDal.Delete(
             new Product
             {
                 Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
              
             });
            LoadProducts();
            MessageBox.Show("New product deleted!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts(tbxSearch.Text);
        }
        private void SearchProducts(string key)
        {
            var result= _productDal.GetByName(key);
            dgvProducts.DataSource = result;
        }
    }

}
