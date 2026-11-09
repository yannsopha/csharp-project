namespace ProductMaintenance
{
    partial class frmProductMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lstProducts = new ListBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.Location = new Point(12, 12);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(450, 292);
            lstProducts.TabIndex = 0;
            lstProducts.SelectedIndexChanged += lstProducts_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(480, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(150, 43);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Product...";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(480, 79);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 44);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete Product...";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(480, 152);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(150, 47);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.Click += btnExit_Click;
            // 
            // frmProductMain
            // 
            ClientSize = new Size(747, 350);
            Controls.Add(lstProducts);
            Controls.Add(btnAdd);
            Controls.Add(btnDelete);
            Controls.Add(btnExit);
            Name = "frmProductMain";
            Text = "Product Maintenance";
            Load += frmProductMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProducts;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnExit;
    }
}