namespace Point_Of_Sale.All_Forms
{
    partial class NewPurchase
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Search = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lbl_CDontactno = new System.Windows.Forms.Label();
            this.txt_searchSupplier = new System.Windows.Forms.TextBox();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ep_Purchase = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpPurchaseINformation = new System.Windows.Forms.GroupBox();
            this.txt_purchaseDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp_purchaseDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grpProductInformation = new System.Windows.Forms.GroupBox();
            this.lblQuality = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblProductUnitPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lvlSoldQuantity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.btnCancle = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txt_ItemCost = new System.Windows.Forms.TextBox();
            this.txtSellUnitPrice = new System.Windows.Forms.TextBox();
            this.txt_PurchaseUnitPrice = new System.Windows.Forms.TextBox();
            this.txt_PurchaseQuatity = new System.Windows.Forms.TextBox();
            this.cmb_ProductQuality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_SelectProduct = new System.Windows.Forms.ComboBox();
            this.cmb_SelectCategory = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpCategory = new System.Windows.Forms.GroupBox();
            this.linkLbl_DeleteProduct = new System.Windows.Forms.LinkLabel();
            this.linkLbl_EditProduct = new System.Windows.Forms.LinkLabel();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dgv_category = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.btnClears = new System.Windows.Forms.Button();
            this.btnCancles = new System.Windows.Forms.Button();
            this.btnFinilize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Purchase)).BeginInit();
            this.grpPurchaseINformation.SuspendLayout();
            this.grpProductInformation.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lbl_CDontactno);
            this.groupBox1.Controls.Add(this.txt_searchSupplier);
            this.groupBox1.Controls.Add(this.lbl_Description);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 245);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT SUPPLIER";
            // 
            // btn_Search
            // 
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_Search.Location = new System.Drawing.Point(118, 108);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(97, 30);
            this.btn_Search.TabIndex = 15;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // lblName
            // 
            this.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(235, 78);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(206, 33);
            this.lblName.TabIndex = 14;
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_CDontactno
            // 
            this.lbl_CDontactno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_CDontactno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CDontactno.Location = new System.Drawing.Point(9, 177);
            this.lbl_CDontactno.Name = "lbl_CDontactno";
            this.lbl_CDontactno.Size = new System.Drawing.Size(206, 33);
            this.lbl_CDontactno.TabIndex = 13;
            this.lbl_CDontactno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_searchSupplier
            // 
            this.txt_searchSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_searchSupplier.Location = new System.Drawing.Point(9, 76);
            this.txt_searchSupplier.Multiline = true;
            this.txt_searchSupplier.Name = "txt_searchSupplier";
            this.txt_searchSupplier.Size = new System.Drawing.Size(206, 26);
            this.txt_searchSupplier.TabIndex = 12;
            // 
            // lbl_Description
            // 
            this.lbl_Description.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Description.Location = new System.Drawing.Point(235, 161);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(206, 64);
            this.lbl_Description.TabIndex = 11;
            this.lbl_Description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contact NO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(231, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Supplier";
            // 
            // ep_Purchase
            // 
            this.ep_Purchase.ContainerControl = this;
            // 
            // grpPurchaseINformation
            // 
            this.grpPurchaseINformation.Controls.Add(this.txt_purchaseDescription);
            this.grpPurchaseINformation.Controls.Add(this.label5);
            this.grpPurchaseINformation.Controls.Add(this.dtp_purchaseDate);
            this.grpPurchaseINformation.Controls.Add(this.label4);
            this.grpPurchaseINformation.Enabled = false;
            this.grpPurchaseINformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPurchaseINformation.Location = new System.Drawing.Point(12, 263);
            this.grpPurchaseINformation.Name = "grpPurchaseINformation";
            this.grpPurchaseINformation.Size = new System.Drawing.Size(385, 177);
            this.grpPurchaseINformation.TabIndex = 1;
            this.grpPurchaseINformation.TabStop = false;
            this.grpPurchaseINformation.Text = "PURCHASE INFORMATION";
            // 
            // txt_purchaseDescription
            // 
            this.txt_purchaseDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_purchaseDescription.Location = new System.Drawing.Point(147, 88);
            this.txt_purchaseDescription.Multiline = true;
            this.txt_purchaseDescription.Name = "txt_purchaseDescription";
            this.txt_purchaseDescription.Size = new System.Drawing.Size(232, 76);
            this.txt_purchaseDescription.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Description";
            // 
            // dtp_purchaseDate
            // 
            this.dtp_purchaseDate.CustomFormat = "dd MMMM, yyyy";
            this.dtp_purchaseDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_purchaseDate.Location = new System.Drawing.Point(147, 44);
            this.dtp_purchaseDate.Name = "dtp_purchaseDate";
            this.dtp_purchaseDate.Size = new System.Drawing.Size(232, 26);
            this.dtp_purchaseDate.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "Purchase Date";
            // 
            // grpProductInformation
            // 
            this.grpProductInformation.Controls.Add(this.lblQuality);
            this.grpProductInformation.Controls.Add(this.label11);
            this.grpProductInformation.Controls.Add(this.lblProductUnitPrice);
            this.grpProductInformation.Controls.Add(this.label12);
            this.grpProductInformation.Controls.Add(this.lvlSoldQuantity);
            this.grpProductInformation.Controls.Add(this.label10);
            this.grpProductInformation.Controls.Add(this.lblProductName);
            this.grpProductInformation.Controls.Add(this.label7);
            this.grpProductInformation.Enabled = false;
            this.grpProductInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpProductInformation.Location = new System.Drawing.Point(12, 446);
            this.grpProductInformation.Name = "grpProductInformation";
            this.grpProductInformation.Size = new System.Drawing.Size(385, 214);
            this.grpProductInformation.TabIndex = 2;
            this.grpProductInformation.TabStop = false;
            this.grpProductInformation.Text = "SELECT PRODUCT DETAIL";
            // 
            // lblQuality
            // 
            this.lblQuality.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuality.Location = new System.Drawing.Point(156, 64);
            this.lblQuality.Name = "lblQuality";
            this.lblQuality.Size = new System.Drawing.Size(206, 33);
            this.lblQuality.TabIndex = 20;
            this.lblQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 73);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 19;
            this.label11.Text = "Quality";
            // 
            // lblProductUnitPrice
            // 
            this.lblProductUnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductUnitPrice.Location = new System.Drawing.Point(156, 159);
            this.lblProductUnitPrice.Name = "lblProductUnitPrice";
            this.lblProductUnitPrice.Size = new System.Drawing.Size(206, 33);
            this.lblProductUnitPrice.TabIndex = 18;
            this.lblProductUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(14, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 48);
            this.label12.TabIndex = 17;
            this.label12.Text = "Purchase Unit\r\n     Price";
            // 
            // lvlSoldQuantity
            // 
            this.lvlSoldQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lvlSoldQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlSoldQuantity.Location = new System.Drawing.Point(156, 109);
            this.lvlSoldQuantity.Name = "lvlSoldQuantity";
            this.lvlSoldQuantity.Size = new System.Drawing.Size(206, 33);
            this.lvlSoldQuantity.TabIndex = 16;
            this.lvlSoldQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(14, 118);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Sold Quantity";
            // 
            // lblProductName
            // 
            this.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(156, 22);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(206, 33);
            this.lblProductName.TabIndex = 14;
            this.lblProductName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Product Name";
            // 
            // grpProduct
            // 
            this.grpProduct.Controls.Add(this.btnCancle);
            this.grpProduct.Controls.Add(this.btnUpdate);
            this.grpProduct.Controls.Add(this.txt_ItemCost);
            this.grpProduct.Controls.Add(this.txtSellUnitPrice);
            this.grpProduct.Controls.Add(this.txt_PurchaseUnitPrice);
            this.grpProduct.Controls.Add(this.txt_PurchaseQuatity);
            this.grpProduct.Controls.Add(this.cmb_ProductQuality);
            this.grpProduct.Controls.Add(this.label8);
            this.grpProduct.Controls.Add(this.btn_clear);
            this.grpProduct.Controls.Add(this.btn_add);
            this.grpProduct.Controls.Add(this.cmb_SelectProduct);
            this.grpProduct.Controls.Add(this.cmb_SelectCategory);
            this.grpProduct.Controls.Add(this.label18);
            this.grpProduct.Controls.Add(this.label17);
            this.grpProduct.Controls.Add(this.label16);
            this.grpProduct.Controls.Add(this.label15);
            this.grpProduct.Controls.Add(this.label14);
            this.grpProduct.Controls.Add(this.label13);
            this.grpProduct.Enabled = false;
            this.grpProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpProduct.Location = new System.Drawing.Point(415, 263);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Size = new System.Drawing.Size(423, 423);
            this.grpProduct.TabIndex = 3;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "SELECT PRODUCT";
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.White;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancle.ForeColor = System.Drawing.Color.Black;
            this.btnCancle.Location = new System.Drawing.Point(318, 360);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(101, 37);
            this.btnCancle.TabIndex = 32;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(215, 360);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(101, 37);
            this.btnUpdate.TabIndex = 31;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txt_ItemCost
            // 
            this.txt_ItemCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_ItemCost.Location = new System.Drawing.Point(195, 306);
            this.txt_ItemCost.Multiline = true;
            this.txt_ItemCost.Name = "txt_ItemCost";
            this.txt_ItemCost.Size = new System.Drawing.Size(206, 26);
            this.txt_ItemCost.TabIndex = 16;
            // 
            // txtSellUnitPrice
            // 
            this.txtSellUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtSellUnitPrice.Location = new System.Drawing.Point(195, 267);
            this.txtSellUnitPrice.Multiline = true;
            this.txtSellUnitPrice.Name = "txtSellUnitPrice";
            this.txtSellUnitPrice.Size = new System.Drawing.Size(206, 26);
            this.txtSellUnitPrice.TabIndex = 17;
            this.txtSellUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSellUnitPrice_KeyPress);
            // 
            // txt_PurchaseUnitPrice
            // 
            this.txt_PurchaseUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_PurchaseUnitPrice.Location = new System.Drawing.Point(195, 222);
            this.txt_PurchaseUnitPrice.Multiline = true;
            this.txt_PurchaseUnitPrice.Name = "txt_PurchaseUnitPrice";
            this.txt_PurchaseUnitPrice.Size = new System.Drawing.Size(206, 26);
            this.txt_PurchaseUnitPrice.TabIndex = 18;
            this.txt_PurchaseUnitPrice.TextChanged += new System.EventHandler(this.txt_PurchaseUnitPrice_TextChanged);
            this.txt_PurchaseUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchaseUnitPrice_KeyPress);
            // 
            // txt_PurchaseQuatity
            // 
            this.txt_PurchaseQuatity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txt_PurchaseQuatity.Location = new System.Drawing.Point(195, 179);
            this.txt_PurchaseQuatity.Multiline = true;
            this.txt_PurchaseQuatity.Name = "txt_PurchaseQuatity";
            this.txt_PurchaseQuatity.Size = new System.Drawing.Size(206, 26);
            this.txt_PurchaseQuatity.TabIndex = 19;
            this.txt_PurchaseQuatity.TextChanged += new System.EventHandler(this.txt_PurchaseQuatity_TextChanged);
            this.txt_PurchaseQuatity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PurchaseQuatity_KeyPress);
            // 
            // cmb_ProductQuality
            // 
            this.cmb_ProductQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductQuality.FormattingEnabled = true;
            this.cmb_ProductQuality.Items.AddRange(new object[] {
            "Select Quality",
            "Low",
            "Normal",
            "Best"});
            this.cmb_ProductQuality.Location = new System.Drawing.Point(195, 137);
            this.cmb_ProductQuality.Name = "cmb_ProductQuality";
            this.cmb_ProductQuality.Size = new System.Drawing.Size(157, 28);
            this.cmb_ProductQuality.TabIndex = 30;
            this.cmb_ProductQuality.SelectionChangeCommitted += new System.EventHandler(this.cmb_ProductQuality_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 29;
            this.label8.Text = "Select Quality";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.White;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Location = new System.Drawing.Point(113, 360);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 37);
            this.btn_clear.TabIndex = 26;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_add.ForeColor = System.Drawing.Color.Black;
            this.btn_add.Location = new System.Drawing.Point(8, 360);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(101, 37);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_SelectProduct
            // 
            this.cmb_SelectProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelectProduct.FormattingEnabled = true;
            this.cmb_SelectProduct.Location = new System.Drawing.Point(195, 88);
            this.cmb_SelectProduct.Name = "cmb_SelectProduct";
            this.cmb_SelectProduct.Size = new System.Drawing.Size(222, 28);
            this.cmb_SelectProduct.TabIndex = 21;
            this.cmb_SelectProduct.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectProduct_SelectedIndexChanged);
            // 
            // cmb_SelectCategory
            // 
            this.cmb_SelectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SelectCategory.FormattingEnabled = true;
            this.cmb_SelectCategory.Location = new System.Drawing.Point(195, 44);
            this.cmb_SelectCategory.Name = "cmb_SelectCategory";
            this.cmb_SelectCategory.Size = new System.Drawing.Size(222, 28);
            this.cmb_SelectCategory.TabIndex = 20;
            this.cmb_SelectCategory.SelectedIndexChanged += new System.EventHandler(this.cmb_SelectCategory_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(56, 306);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(87, 24);
            this.label18.TabIndex = 19;
            this.label18.Text = "Item Cost";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(48, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(126, 24);
            this.label17.TabIndex = 18;
            this.label17.Text = "Sell Unit Price";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(19, 222);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(175, 24);
            this.label16.TabIndex = 17;
            this.label16.Text = "Purchase Unit Price";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 24);
            this.label15.TabIndex = 16;
            this.label15.Text = "Purchase Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(32, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 24);
            this.label14.TabIndex = 15;
            this.label14.Text = "Select Product";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(142, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Select Category";
            // 
            // grpCategory
            // 
            this.grpCategory.Controls.Add(this.linkLbl_DeleteProduct);
            this.grpCategory.Controls.Add(this.linkLbl_EditProduct);
            this.grpCategory.Controls.Add(this.lblTotalAmount);
            this.grpCategory.Controls.Add(this.label19);
            this.grpCategory.Controls.Add(this.dgv_category);
            this.grpCategory.Enabled = false;
            this.grpCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpCategory.Location = new System.Drawing.Point(844, 12);
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.Size = new System.Drawing.Size(507, 581);
            this.grpCategory.TabIndex = 4;
            this.grpCategory.TabStop = false;
            this.grpCategory.Text = "Purchase Cost";
            this.grpCategory.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // linkLbl_DeleteProduct
            // 
            this.linkLbl_DeleteProduct.AutoSize = true;
            this.linkLbl_DeleteProduct.LinkColor = System.Drawing.Color.Red;
            this.linkLbl_DeleteProduct.Location = new System.Drawing.Point(327, 22);
            this.linkLbl_DeleteProduct.Name = "linkLbl_DeleteProduct";
            this.linkLbl_DeleteProduct.Size = new System.Drawing.Size(182, 20);
            this.linkLbl_DeleteProduct.TabIndex = 17;
            this.linkLbl_DeleteProduct.TabStop = true;
            this.linkLbl_DeleteProduct.Text = "Delete Selected Product";
            this.linkLbl_DeleteProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_DeleteProduct_LinkClicked);
            // 
            // linkLbl_EditProduct
            // 
            this.linkLbl_EditProduct.AutoSize = true;
            this.linkLbl_EditProduct.Location = new System.Drawing.Point(158, 22);
            this.linkLbl_EditProduct.Name = "linkLbl_EditProduct";
            this.linkLbl_EditProduct.Size = new System.Drawing.Size(163, 20);
            this.linkLbl_EditProduct.TabIndex = 5;
            this.linkLbl_EditProduct.TabStop = true;
            this.linkLbl_EditProduct.Text = "Edit Selected Product";
            this.linkLbl_EditProduct.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLbl_EditProduct_LinkClicked);
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Red;
            this.lblTotalAmount.Location = new System.Drawing.Point(152, 518);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(206, 33);
            this.lblTotalAmount.TabIndex = 16;
            this.lblTotalAmount.Text = "0.0";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(24, 527);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 24);
            this.label19.TabIndex = 15;
            this.label19.Text = "Total Amount";
            // 
            // dgv_category
            // 
            this.dgv_category.AllowUserToAddRows = false;
            this.dgv_category.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_category.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8,
            this.productname,
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column6,
            this.Column3,
            this.Column5});
            this.dgv_category.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_category.Location = new System.Drawing.Point(16, 55);
            this.dgv_category.MultiSelect = false;
            this.dgv_category.Name = "dgv_category";
            this.dgv_category.ReadOnly = true;
            this.dgv_category.RowHeadersVisible = false;
            this.dgv_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_category.Size = new System.Drawing.Size(485, 441);
            this.dgv_category.TabIndex = 0;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "PID";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "CID";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // productname
            // 
            this.productname.HeaderText = "Product Name";
            this.productname.Name = "productname";
            this.productname.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Category";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Quality";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Sell Unit Price";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Purchase Quality";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Purchase Unit Price";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Item Cost";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // btnClears
            // 
            this.btnClears.BackColor = System.Drawing.Color.White;
            this.btnClears.Enabled = false;
            this.btnClears.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClears.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnClears.ForeColor = System.Drawing.Color.Black;
            this.btnClears.Location = new System.Drawing.Point(1036, 623);
            this.btnClears.Name = "btnClears";
            this.btnClears.Size = new System.Drawing.Size(151, 63);
            this.btnClears.TabIndex = 29;
            this.btnClears.Text = "Clear";
            this.btnClears.UseVisualStyleBackColor = false;
            // 
            // btnCancles
            // 
            this.btnCancles.BackColor = System.Drawing.Color.White;
            this.btnCancles.Enabled = false;
            this.btnCancles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnCancles.ForeColor = System.Drawing.Color.Black;
            this.btnCancles.Location = new System.Drawing.Point(1200, 623);
            this.btnCancles.Name = "btnCancles";
            this.btnCancles.Size = new System.Drawing.Size(151, 63);
            this.btnCancles.TabIndex = 29;
            this.btnCancles.Text = "Cancle";
            this.btnCancles.UseVisualStyleBackColor = false;
            this.btnCancles.Click += new System.EventHandler(this.btnCancles_Click);
            // 
            // btnFinilize
            // 
            this.btnFinilize.BackColor = System.Drawing.Color.White;
            this.btnFinilize.Enabled = false;
            this.btnFinilize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFinilize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnFinilize.ForeColor = System.Drawing.Color.Black;
            this.btnFinilize.Location = new System.Drawing.Point(879, 623);
            this.btnFinilize.Name = "btnFinilize";
            this.btnFinilize.Size = new System.Drawing.Size(151, 63);
            this.btnFinilize.TabIndex = 29;
            this.btnFinilize.Text = "Finilize";
            this.btnFinilize.UseVisualStyleBackColor = false;
            this.btnFinilize.Click += new System.EventHandler(this.btnFinilize_Click);
            // 
            // NewPurchase
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.SplitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1370, 731);
            this.Controls.Add(this.btnFinilize);
            this.Controls.Add(this.btnCancles);
            this.Controls.Add(this.btnClears);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.grpProduct);
            this.Controls.Add(this.grpProductInformation);
            this.Controls.Add(this.grpPurchaseINformation);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NewPurchase";
            this.Text = "Purchase";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NewPurchase_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_Purchase)).EndInit();
            this.grpPurchaseINformation.ResumeLayout(false);
            this.grpPurchaseINformation.PerformLayout();
            this.grpProductInformation.ResumeLayout(false);
            this.grpProductInformation.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.grpCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_category)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lbl_CDontactno;
        private System.Windows.Forms.TextBox txt_searchSupplier;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ErrorProvider ep_Purchase;
        private System.Windows.Forms.GroupBox grpPurchaseINformation;
        private System.Windows.Forms.TextBox txt_purchaseDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtp_purchaseDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpProduct;
        private System.Windows.Forms.GroupBox grpProductInformation;
        private System.Windows.Forms.Label lblProductUnitPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lvlSoldQuantity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_SelectCategory;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmb_SelectProduct;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox grpCategory;
        private System.Windows.Forms.LinkLabel linkLbl_DeleteProduct;
        private System.Windows.Forms.LinkLabel linkLbl_EditProduct;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dgv_category;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnFinilize;
        private System.Windows.Forms.Button btnCancles;
        private System.Windows.Forms.Button btnClears;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmb_ProductQuality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblQuality;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_ItemCost;
        private System.Windows.Forms.TextBox txtSellUnitPrice;
        private System.Windows.Forms.TextBox txt_PurchaseUnitPrice;
        private System.Windows.Forms.TextBox txt_PurchaseQuatity;
        private System.Windows.Forms.Button btnCancle;
        private System.Windows.Forms.Button btnUpdate;
    }
}