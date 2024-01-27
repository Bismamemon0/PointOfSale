namespace Point_Of_Sale.StockForm
{
    partial class Form_Category
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
            this.btn_cancle = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txt_categoryDescription = new System.Windows.Forms.TextBox();
            this.txt_categoryName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_categoryList = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_categorySearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.epcategory = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.delleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoryList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epcategory)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_cancle);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_save);
            this.groupBox1.Controls.Add(this.btn_edit);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.txt_categoryDescription);
            this.groupBox1.Controls.Add(this.txt_categoryName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1023, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Detail";
            // 
            // btn_cancle
            // 
            this.btn_cancle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_cancle.Enabled = false;
            this.btn_cancle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btn_cancle.ForeColor = System.Drawing.Color.White;
            this.btn_cancle.Location = new System.Drawing.Point(705, 124);
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
            this.btn_update.Location = new System.Drawing.Point(581, 124);
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
            this.btn_save.Location = new System.Drawing.Point(447, 16);
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
            this.btn_edit.Location = new System.Drawing.Point(447, 124);
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
            this.btn_clear.Location = new System.Drawing.Point(447, 69);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(101, 37);
            this.btn_clear.TabIndex = 4;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txt_categoryDescription
            // 
            this.txt_categoryDescription.Location = new System.Drawing.Point(174, 98);
            this.txt_categoryDescription.Multiline = true;
            this.txt_categoryDescription.Name = "txt_categoryDescription";
            this.txt_categoryDescription.Size = new System.Drawing.Size(240, 63);
            this.txt_categoryDescription.TabIndex = 3;
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.Location = new System.Drawing.Point(174, 60);
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(240, 20);
            this.txt_categoryName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category";
            // 
            // dgv_categoryList
            // 
            this.dgv_categoryList.AllowUserToAddRows = false;
            this.dgv_categoryList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgv_categoryList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dgv_categoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_categoryList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgv_categoryList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_categoryList.EnableHeadersVisualStyles = false;
            this.dgv_categoryList.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgv_categoryList.Location = new System.Drawing.Point(12, 335);
            this.dgv_categoryList.Name = "dgv_categoryList";
            this.dgv_categoryList.ReadOnly = true;
            this.dgv_categoryList.RowHeadersVisible = false;
            this.dgv_categoryList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_categoryList.Size = new System.Drawing.Size(1021, 276);
            this.dgv_categoryList.TabIndex = 1;
            this.dgv_categoryList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_categoryList_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // txt_categorySearch
            // 
            this.txt_categorySearch.Location = new System.Drawing.Point(168, 303);
            this.txt_categorySearch.Name = "txt_categorySearch";
            this.txt_categorySearch.Size = new System.Drawing.Size(240, 20);
            this.txt_categorySearch.TabIndex = 10;
            this.txt_categorySearch.TextChanged += new System.EventHandler(this.txt_categorySearch_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Search Category";
            // 
            // epcategory
            // 
            this.epcategory.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(409, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "Form Category";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.delleteToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 48);
            this.contextMenuStrip2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip2_Opening);
            // 
            // delleteToolStripMenuItem
            // 
            this.delleteToolStripMenuItem.Name = "delleteToolStripMenuItem";
            this.delleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.delleteToolStripMenuItem.Text = "dellete";
            this.delleteToolStripMenuItem.Click += new System.EventHandler(this.delleteToolStripMenuItem_Click);
            // 
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1096, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_categorySearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_categoryList);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.Name = "Form_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Category";
            this.Load += new System.EventHandler(this.Form_Category_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_categoryList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.epcategory)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txt_categoryDescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_categoryList;
        private System.Windows.Forms.Button btn_cancle;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txt_categorySearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider epcategory;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem delleteToolStripMenuItem;
    }
}