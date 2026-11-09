using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace ProductMaintenance
{
    public partial class frmNewProduct : Form
    {
        public frmNewProduct()
        {
            InitializeComponent();
        }

        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            return product;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(txtCode.Text,
                    txtDescription.Text,
                    Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtCode) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
