namespace Point_Of_Sale.All_Forms
{
    partial class formProducts
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_cProductSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Quantity = new System.Windows.Forms.TextBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.cmb_Quality = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_productName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_selectProduct = new System.Windows.Forms.ComboBox();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_ProductDescription = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ep_product = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgv_product = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cProductSearch
            // 
            this.txt_cProductSearch.Location = new System.Drawing.Point(292, 411);
            this.txt_cProductSearch.Name = "txt_cProductSearch";
            this.txt_cProductSearch.Size = new System.Drawing.Size(240, 20);
            this.txt_cProductSearch.TabIndex = 14;
            this.txt_cProductSearch.TextChanged += new System.EventHandler(this.txt_cProductSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Search Category";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_Quantity);
            this.groupBox1.Controls.Add(this.txt_UnitPrice);
            this.groupBox1.Controls.Add(this.cmb_Quality);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_productName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.comboBox_selectProduct);
            this.groupBox1.Controls.Add(this.btn_cancle);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_ProductDescription);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(133, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(846, 357);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Detail";
            // 
            // txt_Quantity
            // 
            this.txt_Quantity.Location = new System.Drawing.Point(180, 194);
            this.txt_Quantity.Name = "txt_Quantity";
            this.txt_Quantity.Size = new System.Drawing.Size(240, 20);
            this.txt_Quantity.TabIndex = 34;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.Location = new System.Drawing.Point(182, 155);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(240, 20);
            this.txt_UnitPrice.TabIndex = 33;
            this.txt_UnitPrice.TextChanged += new System.EventHandler(this.txt_UnitPrice_TextChanged);
            // 
            // cmb_Quality
            // 
            this.cmb_Quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Quality.FormattingEnabled = true;
            this.cmb_Quality.Items.AddRange(new object[] {
            "Select Quality",
            "Low",
            "Normal",
            "Best"});
            this.cmb_Quality.Location = new System.Drawing.Point(180, 246);
            this.cmb_Quality.Name = "cmb_Quality";
            this.cmb_Quality.Size = new System.Drawing.Size(238, 21);
            this.cmb_Quality.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 24);
            this.label8.TabIndex = 31;
            this.label8.Text = "Select Quality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(57, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "Quantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Unit Price";
            // 
            // txt_productName
            // 
            this.txt_productName.Location = new System.Drawing.Point(178, 112);
            this.txt_productName.Name = "txt_productName";
            this.txt_productName.Size = new System.Drawing.Size(240, 20);
            this.txt_productName.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "Product Name";
            // 
            // comboBox_selectProduct
            // 
            this.comboBox_selectProduct.FormattingEnabled = true;
            this.comboBox_selectProduct.Location = new System.Drawing.Point(178, 65);
            this.comboBox_selectProduct.Name = "comboBox_selectProduct";
            this.comboBox_selectProduct.Size = new System.Drawing.Size(242, 21);
            this.comboBox_selectProduct.TabIndex = 9;
            this.comboBox_selectProduct.SelectedIndexChanged += new System.EventHandler(this.comboBox_selectProduct_SelectedIndexChanged);
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancle.Enabled = false;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancle.ForeColor = System.Drawing.Color.White;
            this.btn_cancle.Location = new System.Drawing.Point(729, 298);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(101, 37);
            this.btn_cancle.TabIndex = 8;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(605, 298);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 37);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(471, 190);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(101, 37);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_edit.ForeColor = System.Drawing.Color.White;
            this.btn_edit.Location = new System.Drawing.Point(471, 298);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 37);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(471, 243);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_ProductDescription
            // 
            this.txt_ProductDescription.Location = new System.Drawing.Point(180, 285);
            this.txt_ProductDescription.Multiline = true;
            this.txt_ProductDescription.Name = "txt_ProductDescription";
            this.txt_ProductDescription.Size = new System.Drawing.Size(242, 50);
            this.txt_ProductDescription.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Category";
            // 
            // ep_product
            // 
            this.ep_product.ContainerControl = this;
            // 
            // dgv_product
            // 
            this.dgv_product.AllowUserToAddRows = false;
            this.dgv_product.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column3});
            this.dgv_product.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_product.EnableHeadersVisualStyles = false;
            this.dgv_product.Location = new System.Drawing.Point(51, 437);
            this.dgv_product.Name = "dgv_product";
            this.dgv_product.ReadOnly = true;
            this.dgv_product.RowHeadersVisible = false;
            this.dgv_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_product.Size = new System.Drawing.Size(1021, 276);
            this.dgv_product.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "product Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Unit Price";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Quantity";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Item Cost";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Quality";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // formProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1093, 725);
            this.Controls.Add(this.dgv_product);
            this.Controls.Add(this.txt_cProductSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "formProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formProducts";
            this.Load += new System.EventHandler(this.formProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_product)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txt_cProductSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_ProductDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_productName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_selectProduct;
        private System.Windows.Forms.ErrorProvider ep_product;
        private System.Windows.Forms.DataGridView dgv_product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmb_Quality;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Quantity;
        private System.Windows.Forms.TextBox txt_UnitPrice;
    }
}