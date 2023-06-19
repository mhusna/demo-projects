using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Northwind.WinFormsUI
{
    public partial class Form1 : Form
    {
        IProductService _productService;
        ICategoryService _categoryService;

        public Form1()
        {
            InitializeComponent();
            _productService = new ProductManager(new EfProductDal());
            _categoryService = new CategoryManager(new EfCategoryDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";
        }

        private void LoadProducts()
        {
            dgwProducts.DataSource = _productService.GetAll();
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                dgwProducts.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
            }
            catch (Exception ex)
            {

            }

        }

        private void tbxProduct_TextChanged(object sender, EventArgs e)
        {

            if (!String.IsNullOrEmpty(tbxProduct.Text))
                dgwProducts.DataSource = _productService.GetProductsByProductName(tbxProduct.Text);
            
            else
                LoadProducts(); 
        }
    }
}
