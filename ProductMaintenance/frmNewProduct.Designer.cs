namespace ProductMaintenance
{
    partial class frmNewProduct
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
            lblCode = new Label();
            lblDescription = new Label();
            lblPrice = new Label();
            txtCode = new TextBox();
            txtDescription = new TextBox();
            txtPrice = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblCode
            // 
            lblCode.Location = new Point(30, 49);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(100, 42);
            lblCode.TabIndex = 0;
            lblCode.Text = "Code:";
            // 
            // lblDescription
            // 
            lblDescription.Location = new Point(30, 130);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(138, 37);
            lblDescription.TabIndex = 2;
            lblDescription.Text = "Description:";
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(30, 201);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 46);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            lblPrice.Click += lblPrice_Click;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(174, 46);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(126, 39);
            txtCode.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(174, 130);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(276, 39);
            txtDescription.TabIndex = 3;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(174, 201);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(126, 39);
            txtPrice.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(174, 279);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(130, 39);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(355, 279);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 39);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // frmNewProduct
            // 
            ClientSize = new Size(677, 420);
            Controls.Add(lblCode);
            Controls.Add(txtCode);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblPrice);
            Controls.Add(txtPrice);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Name = "frmNewProduct";
            Text = "New Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtDescription;
        private TextBox txtPrice;
        private Button btnSave;
        private Button btnCancel;
        private Label lblCode;
        private Label lblDescription;
        private Label lblPrice;
    }
}