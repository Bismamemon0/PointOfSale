namespace Point_Of_Sale.All_Forms
{
    partial class FrmCustomers
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
            this.label4 = new System.Windows.Forms.Label();
            this.txt_scustomerSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_customerList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_goupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contactNO = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_cCustomerDescription = new System.Windows.Forms.TextBox();
            this.txt_CustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.epCustomer = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerList)).BeginInit();
            this.Contact_goupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(510, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(234, 33);
            this.label4.TabIndex = 18;
            this.label4.Text = "Form Customers";
            // 
            // txt_scustomerSearch
            // 
            this.txt_scustomerSearch.Location = new System.Drawing.Point(264, 344);
            this.txt_scustomerSearch.Name = "txt_scustomerSearch";
            this.txt_scustomerSearch.Size = new System.Drawing.Size(240, 20);
            this.txt_scustomerSearch.TabIndex = 20;
            this.txt_scustomerSearch.TextChanged += new System.EventHandler(this.txt_scustomerSearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search Supplier";
            // 
            // dgv_customerList
            // 
            this.dgv_customerList.AllowUserToAddRows = false;
            this.dgv_customerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_customerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_customerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column3});
            this.dgv_customerList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_customerList.EnableHeadersVisualStyles = false;
            this.dgv_customerList.Location = new System.Drawing.Point(112, 379);
            this.dgv_customerList.Name = "dgv_customerList";
            this.dgv_customerList.ReadOnly = true;
            this.dgv_customerList.RowHeadersVisible = false;
            this.dgv_customerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_customerList.Size = new System.Drawing.Size(1021, 323);
            this.dgv_customerList.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Customer Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Contact NO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Description";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Contact_goupBox1
            // 
            this.Contact_goupBox1.Controls.Add(this.txt_address);
            this.Contact_goupBox1.Controls.Add(this.label6);
            this.Contact_goupBox1.Controls.Add(this.txt_contactNO);
            this.Contact_goupBox1.Controls.Add(this.label5);
            this.Contact_goupBox1.Controls.Add(this.btn_cancle);
            this.Contact_goupBox1.Controls.Add(this.btn_update);
            this.Contact_goupBox1.Controls.Add(this.btn_save);
            this.Contact_goupBox1.Controls.Add(this.btn_edit);
            this.Contact_goupBox1.Controls.Add(this.btn_clear);
            this.Contact_goupBox1.Controls.Add(this.txt_cCustomerDescription);
            this.Contact_goupBox1.Controls.Add(this.txt_CustomerName);
            this.Contact_goupBox1.Controls.Add(this.label2);
            this.Contact_goupBox1.Controls.Add(this.label1);
            this.Contact_goupBox1.Location = new System.Drawing.Point(96, 70);
            this.Contact_goupBox1.Name = "Contact_goupBox1";
            this.Contact_goupBox1.Size = new System.Drawing.Size(1069, 258);
            this.Contact_goupBox1.TabIndex = 16;
            this.Contact_goupBox1.TabStop = false;
            this.Contact_goupBox1.Text = "  ";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(200, 84);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(240, 20);
            this.txt_address.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Customer Address";
            // 
            // txt_contactNO
            // 
            this.txt_contactNO.Location = new System.Drawing.Point(200, 134);
            this.txt_contactNO.Mask = "+00000-00000000";
            this.txt_contactNO.Name = "txt_contactNO";
            this.txt_contactNO.Size = new System.Drawing.Size(240, 20);
            this.txt_contactNO.TabIndex = 10;
            this.txt_contactNO.Leave += new System.EventHandler(this.txt_contactNO_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Contct NO";
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancle.Enabled = false;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancle.ForeColor = System.Drawing.Color.White;
            this.btn_cancle.Location = new System.Drawing.Point(734, 178);
            this.btn_cancle.Name = "btn_cancle";
            this.btn_cancle.Size = new System.Drawing.Size(101, 37);
            this.btn_cancle.TabIndex = 8;
            this.btn_cancle.Text = "Cancle";
            this.btn_cancle.UseVisualStyleBackColor = false;
            this.btn_cancle.Click += new System.EventHandler(this.btn_cancle_Click_1);
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_update.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(610, 178);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(101, 37);
            this.btn_update.TabIndex = 7;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click_1);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(476, 73);
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
            this.btn_edit.Location = new System.Drawing.Point(476, 178);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(101, 37);
            this.btn_edit.TabIndex = 5;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(476, 123);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_cCustomerDescription
            // 
            this.txt_cCustomerDescription.Location = new System.Drawing.Point(200, 178);
            this.txt_cCustomerDescription.Multiline = true;
            this.txt_cCustomerDescription.Name = "txt_cCustomerDescription";
            this.txt_cCustomerDescription.Size = new System.Drawing.Size(240, 63);
            this.txt_cCustomerDescription.TabIndex = 3;
            // 
            // txt_CustomerName
            // 
            this.txt_CustomerName.Location = new System.Drawing.Point(200, 43);
            this.txt_CustomerName.Name = "txt_CustomerName";
            this.txt_CustomerName.Size = new System.Drawing.Size(240, 20);
            this.txt_CustomerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Customer";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // epCustomer
            // 
            this.epCustomer.ContainerControl = this;
            // 
            // FrmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1242, 714);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_scustomerSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_customerList);
            this.Controls.Add(this.Contact_goupBox1);
            this.Name = "FrmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCustomers";
            this.Load += new System.EventHandler(this.FrmCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_customerList)).EndInit();
            this.Contact_goupBox1.ResumeLayout(false);
            this.Contact_goupBox1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_scustomerSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_customerList;
        private System.Windows.Forms.GroupBox Contact_goupBox1;
        private System.Windows.Forms.MaskedTextBox txt_contactNO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_cCustomerDescription;
        private System.Windows.Forms.TextBox txt_CustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider epCustomer;
    }
}