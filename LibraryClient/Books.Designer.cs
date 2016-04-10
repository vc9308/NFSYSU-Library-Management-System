namespace LibraryClient
{
    partial class Books
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
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.libraryManagerDataSet_Books = new LibraryClient.LibraryManagerDataSet_Books();
            this.booksBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksTableAdapter = new LibraryClient.LibraryManagerDataSet_BooksTableAdapters.BooksTableAdapter();
            this.booksNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Books)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.booksNameDataGridViewTextBoxColumn,
            this.countTotalDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(983, 576);
            this.dataGridView1.TabIndex = 2;
            // 
            // libraryManagerDataSet_Books
            // 
            this.libraryManagerDataSet_Books.DataSetName = "LibraryManagerDataSet_Books";
            this.libraryManagerDataSet_Books.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksBindingSource1
            // 
            this.booksBindingSource1.DataMember = "Books";
            this.booksBindingSource1.DataSource = this.libraryManagerDataSet_Books;
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksNameDataGridViewTextBoxColumn
            // 
            this.booksNameDataGridViewTextBoxColumn.DataPropertyName = "BooksName";
            this.booksNameDataGridViewTextBoxColumn.HeaderText = "BooksName";
            this.booksNameDataGridViewTextBoxColumn.Name = "booksNameDataGridViewTextBoxColumn";
            // 
            // countTotalDataGridViewTextBoxColumn
            // 
            this.countTotalDataGridViewTextBoxColumn.DataPropertyName = "Count_Total";
            this.countTotalDataGridViewTextBoxColumn.HeaderText = "Count_Total";
            this.countTotalDataGridViewTextBoxColumn.Name = "countTotalDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 579);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1000, 618);
            this.MinimumSize = new System.Drawing.Size(1000, 618);
            this.Name = "Books";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagerDataSet_Books)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LibraryManagerDataSet_Books libraryManagerDataSet_Books;
        private System.Windows.Forms.BindingSource booksBindingSource1;
        private LibraryManagerDataSet_BooksTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn booksNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}