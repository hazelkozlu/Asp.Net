using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewMyProje
{
    public partial class Form1 : Form
    {
        public void SearchProduct(string key)
        {
            var result = _productDal.GetByProductName(key);
            dgwProduct.DataSource = result;
        }
        public void LoadProducts()
        {
            dgwProduct.DataSource = _productDal.GetAll();
        }
        public void LoadProducts(int key)
        {
            dgwProduct.DataSource = _productDal.GetByCategoryID(key);
           
        }
        public void ListCategory()
        {
            cbxCategory.DataSource = _productDal.GetCategory();
            cbxCategory.ValueMember = "CategoryID";
            cbxCategory.DisplayMember = "CategoryName";
        }
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();
        private void Form1_Load(object sender, EventArgs e)
        {
            using (DatabaseContext context = new DatabaseContext())
            {
                ListCategory();
                LoadProducts();

            }
        }
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProduct(tbxSearch.Text);
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LoadProducts(Convert.ToInt32(cbxCategory.SelectedValue));

             
            }
            catch 
            {
                LoadProducts();
                
            }
           
        }
    }
}
