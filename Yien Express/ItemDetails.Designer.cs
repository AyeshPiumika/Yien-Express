namespace Yien_Express
{
    partial class ItemDetails
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rcontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.raddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Yien_ExpressDataSet4 = new Yien_Express.db_Yien_ExpressDataSet4();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbl_ItemsTableAdapter = new Yien_Express.db_Yien_ExpressDataSet4TableAdapters.tbl_ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yien_Express.Properties.Resources.Untitled_design__43_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(20, 444);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 27);
            this.button3.TabIndex = 57;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.detailsDataGridViewTextBoxColumn,
            this.ncidDataGridViewTextBoxColumn,
            this.rcontactDataGridViewTextBoxColumn,
            this.raddressDataGridViewTextBoxColumn,
            this.itemstatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblItemsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(55, 66);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(645, 358);
            this.dataGridView1.TabIndex = 56;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "itemid";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "itemid";
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            // 
            // detailsDataGridViewTextBoxColumn
            // 
            this.detailsDataGridViewTextBoxColumn.DataPropertyName = "details";
            this.detailsDataGridViewTextBoxColumn.HeaderText = "details";
            this.detailsDataGridViewTextBoxColumn.Name = "detailsDataGridViewTextBoxColumn";
            // 
            // ncidDataGridViewTextBoxColumn
            // 
            this.ncidDataGridViewTextBoxColumn.DataPropertyName = "ncid";
            this.ncidDataGridViewTextBoxColumn.HeaderText = "ncid";
            this.ncidDataGridViewTextBoxColumn.Name = "ncidDataGridViewTextBoxColumn";
            // 
            // rcontactDataGridViewTextBoxColumn
            // 
            this.rcontactDataGridViewTextBoxColumn.DataPropertyName = "rcontact";
            this.rcontactDataGridViewTextBoxColumn.HeaderText = "rcontact";
            this.rcontactDataGridViewTextBoxColumn.Name = "rcontactDataGridViewTextBoxColumn";
            // 
            // raddressDataGridViewTextBoxColumn
            // 
            this.raddressDataGridViewTextBoxColumn.DataPropertyName = "raddress";
            this.raddressDataGridViewTextBoxColumn.HeaderText = "raddress";
            this.raddressDataGridViewTextBoxColumn.Name = "raddressDataGridViewTextBoxColumn";
            // 
            // itemstatusDataGridViewTextBoxColumn
            // 
            this.itemstatusDataGridViewTextBoxColumn.DataPropertyName = "itemstatus";
            this.itemstatusDataGridViewTextBoxColumn.HeaderText = "itemstatus";
            this.itemstatusDataGridViewTextBoxColumn.Name = "itemstatusDataGridViewTextBoxColumn";
            // 
            // tblItemsBindingSource
            // 
            this.tblItemsBindingSource.DataMember = "tbl_Items";
            this.tblItemsBindingSource.DataSource = this.db_Yien_ExpressDataSet4;
            // 
            // db_Yien_ExpressDataSet4
            // 
            this.db_Yien_ExpressDataSet4.DataSetName = "db_Yien_ExpressDataSet4";
            this.db_Yien_ExpressDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yien_Express.Properties.Resources.Untitled_design__44_;
            this.pictureBox3.Location = new System.Drawing.Point(618, 306);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // tbl_ItemsTableAdapter
            // 
            this.tbl_ItemsTableAdapter.ClearBeforeFill = true;
            // 
            // ItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemDetails";
            this.Text = "ItemDetails";
            this.Load += new System.EventHandler(this.ItemDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private db_Yien_ExpressDataSet4 db_Yien_ExpressDataSet4;
        private System.Windows.Forms.BindingSource tblItemsBindingSource;
        private db_Yien_ExpressDataSet4TableAdapters.tbl_ItemsTableAdapter tbl_ItemsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rcontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn raddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemstatusDataGridViewTextBoxColumn;
    }
}