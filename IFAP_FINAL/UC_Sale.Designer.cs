namespace IFAP_FINAL
{
    partial class UC_Sale
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lviCustomer = new System.Windows.Forms.ListView();
            this.cID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lviBasket = new System.Windows.Forms.ListView();
            this.pID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pCompany = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaleSold = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel8.Controls.Add(this.btnCustomerDelete);
            this.panel8.Location = new System.Drawing.Point(459, 220);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(402, 50);
            this.panel8.TabIndex = 22;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(10, 10);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(110, 30);
            this.btnCustomerDelete.TabIndex = 2;
            this.btnCustomerDelete.Text = "Müşteri Sil";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.panel7.Controls.Add(this.lviCustomer);
            this.panel7.Location = new System.Drawing.Point(459, 276);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10);
            this.panel7.Size = new System.Drawing.Size(402, 156);
            this.panel7.TabIndex = 21;
            // 
            // lviCustomer
            // 
            this.lviCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cID,
            this.cName,
            this.cSurname,
            this.cPhone});
            this.lviCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviCustomer.FullRowSelect = true;
            this.lviCustomer.HideSelection = false;
            this.lviCustomer.Location = new System.Drawing.Point(10, 10);
            this.lviCustomer.Name = "lviCustomer";
            this.lviCustomer.Size = new System.Drawing.Size(382, 136);
            this.lviCustomer.TabIndex = 1;
            this.lviCustomer.UseCompatibleStateImageBehavior = false;
            this.lviCustomer.View = System.Windows.Forms.View.Details;
            // 
            // cID
            // 
            this.cID.Text = "ID";
            // 
            // cName
            // 
            this.cName.Text = "Ad";
            // 
            // cSurname
            // 
            this.cSurname.Text = "Soyad";
            // 
            // cPhone
            // 
            this.cPhone.Text = "Telefon";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.lviBasket);
            this.panel3.Location = new System.Drawing.Point(459, 59);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10);
            this.panel3.Size = new System.Drawing.Size(402, 155);
            this.panel3.TabIndex = 20;
            // 
            // lviBasket
            // 
            this.lviBasket.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.pID,
            this.pName,
            this.pQuantity,
            this.pPrice,
            this.pCompany});
            this.lviBasket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lviBasket.FullRowSelect = true;
            this.lviBasket.HideSelection = false;
            this.lviBasket.Location = new System.Drawing.Point(10, 10);
            this.lviBasket.Name = "lviBasket";
            this.lviBasket.Size = new System.Drawing.Size(382, 135);
            this.lviBasket.TabIndex = 0;
            this.lviBasket.UseCompatibleStateImageBehavior = false;
            this.lviBasket.View = System.Windows.Forms.View.Details;
            this.lviBasket.DoubleClick += new System.EventHandler(this.lviBasket_DoubleClick);
            // 
            // pID
            // 
            this.pID.Text = "ID";
            // 
            // pName
            // 
            this.pName.Text = "Ad";
            // 
            // pQuantity
            // 
            this.pQuantity.Text = "Miktar";
            // 
            // pPrice
            // 
            this.pPrice.Text = "Fiyat";
            // 
            // pCompany
            // 
            this.pCompany.Text = "Şirket";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnSaleSold);
            this.panel2.Location = new System.Drawing.Point(459, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 50);
            this.panel2.TabIndex = 19;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalPrice.Location = new System.Drawing.Point(283, 19);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(19, 20);
            this.lblTotalPrice.TabIndex = 4;
            this.lblTotalPrice.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(151, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Toplam Tutar:";
            // 
            // btnSaleSold
            // 
            this.btnSaleSold.Location = new System.Drawing.Point(10, 10);
            this.btnSaleSold.Name = "btnSaleSold";
            this.btnSaleSold.Size = new System.Drawing.Size(75, 30);
            this.btnSaleSold.TabIndex = 2;
            this.btnSaleSold.Text = "Satış";
            this.btnSaleSold.UseVisualStyleBackColor = true;
            this.btnSaleSold.Click += new System.EventHandler(this.btnSaleSold_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel6.Controls.Add(this.btnSearchProduct);
            this.panel6.Controls.Add(this.txtSearchProduct);
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(450, 50);
            this.panel6.TabIndex = 18;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(330, 9);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(110, 30);
            this.btnSearchProduct.TabIndex = 2;
            this.btnSearchProduct.Text = "Ürün Ara";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(15, 14);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(240, 22);
            this.txtSearchProduct.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.dgvProduct);
            this.panel5.Location = new System.Drawing.Point(3, 59);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10);
            this.panel5.Size = new System.Drawing.Size(450, 155);
            this.panel5.TabIndex = 17;
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduct.Location = new System.Drawing.Point(10, 10);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduct.ShowEditingIcon = false;
            this.dgvProduct.Size = new System.Drawing.Size(430, 135);
            this.dgvProduct.TabIndex = 0;
            this.dgvProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellDoubleClick);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.dgvCustomer);
            this.panel4.Location = new System.Drawing.Point(3, 276);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(450, 156);
            this.panel4.TabIndex = 16;
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.AllowUserToAddRows = false;
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomer.Location = new System.Drawing.Point(10, 10);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.ReadOnly = true;
            this.dgvCustomer.RowHeadersWidth = 51;
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomer.ShowEditingIcon = false;
            this.dgvCustomer.Size = new System.Drawing.Size(430, 136);
            this.dgvCustomer.TabIndex = 0;
            this.dgvCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomer_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(113)))), ((int)(((byte)(116)))));
            this.panel1.Controls.Add(this.btnSearchCustomer);
            this.panel1.Controls.Add(this.txtSearchCustomer);
            this.panel1.Location = new System.Drawing.Point(3, 220);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 50);
            this.panel1.TabIndex = 15;
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(330, 10);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(110, 30);
            this.btnSearchCustomer.TabIndex = 1;
            this.btnSearchCustomer.Text = "Müşteri Ara";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(15, 14);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(240, 22);
            this.txtSearchCustomer.TabIndex = 0;
            // 
            // UC_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Sale";
            this.Size = new System.Drawing.Size(865, 435);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ListView lviCustomer;
        private System.Windows.Forms.ColumnHeader cID;
        private System.Windows.Forms.ColumnHeader cName;
        private System.Windows.Forms.ColumnHeader cSurname;
        private System.Windows.Forms.ColumnHeader cPhone;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lviBasket;
        private System.Windows.Forms.ColumnHeader pID;
        private System.Windows.Forms.ColumnHeader pName;
        private System.Windows.Forms.ColumnHeader pQuantity;
        private System.Windows.Forms.ColumnHeader pPrice;
        private System.Windows.Forms.ColumnHeader pCompany;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaleSold;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
    }
}
