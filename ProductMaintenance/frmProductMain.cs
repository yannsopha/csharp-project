using System;
using System.Windows.Forms;
using System.Drawing;
using ProductMaintenance;
namespace ProductMaintenance
{
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

        private ProductList products = new ProductList();

        private void frmProductMain_Load(object sender,
            System.EventArgs e)
        {
            products.Changed
                += new ProductList.ChangeHandler(HandleChange);
            products.Fill();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            Product p;
            lstProducts.Items.Clear();
            for (int i = 0; i < products.Count; i++)
            {
                p = products[i];
                lstProducts.Items.Add(p.GetDisplayText("\t"));
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                product += new product;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i != -1)
            {
                Product product = products[i];
                string message = "Are you sure you want to delete "
                    + product.Description + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    products.Remove(product);
                    ProductDB.SaveProducts(products);
                    FillProductListBox();
                }
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
