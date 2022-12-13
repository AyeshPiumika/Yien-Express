namespace Yien_Express
{
    partial class CustomerDetails
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ncidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nccontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNormalClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_Yien_ExpressDataSet5 = new Yien_Express.db_Yien_ExpressDataSet5();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbl_NormalClientsTableAdapter = new Yien_Express.db_Yien_ExpressDataSet5TableAdapters.tbl_NormalClientsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormalClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yien_Express.Properties.Resources.Untitled_design__43_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ncidDataGridViewTextBoxColumn,
            this.ncnameDataGridViewTextBoxColumn,
            this.nccontactDataGridViewTextBoxColumn,
            this.ncnicDataGridViewTextBoxColumn,
            this.ncaddressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblNormalClientsBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(82, 67);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(543, 358);
            this.dataGridView1.TabIndex = 50;
            // 
            // ncidDataGridViewTextBoxColumn
            // 
            this.ncidDataGridViewTextBoxColumn.DataPropertyName = "ncid";
            this.ncidDataGridViewTextBoxColumn.HeaderText = "ncid";
            this.ncidDataGridViewTextBoxColumn.Name = "ncidDataGridViewTextBoxColumn";
            this.ncidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ncnameDataGridViewTextBoxColumn
            // 
            this.ncnameDataGridViewTextBoxColumn.DataPropertyName = "ncname";
            this.ncnameDataGridViewTextBoxColumn.HeaderText = "ncname";
            this.ncnameDataGridViewTextBoxColumn.Name = "ncnameDataGridViewTextBoxColumn";
            // 
            // nccontactDataGridViewTextBoxColumn
            // 
            this.nccontactDataGridViewTextBoxColumn.DataPropertyName = "nccontact";
            this.nccontactDataGridViewTextBoxColumn.HeaderText = "nccontact";
            this.nccontactDataGridViewTextBoxColumn.Name = "nccontactDataGridViewTextBoxColumn";
            // 
            // ncnicDataGridViewTextBoxColumn
            // 
            this.ncnicDataGridViewTextBoxColumn.DataPropertyName = "ncnic";
            this.ncnicDataGridViewTextBoxColumn.HeaderText = "ncnic";
            this.ncnicDataGridViewTextBoxColumn.Name = "ncnicDataGridViewTextBoxColumn";
            // 
            // ncaddressDataGridViewTextBoxColumn
            // 
            this.ncaddressDataGridViewTextBoxColumn.DataPropertyName = "ncaddress";
            this.ncaddressDataGridViewTextBoxColumn.HeaderText = "ncaddress";
            this.ncaddressDataGridViewTextBoxColumn.Name = "ncaddressDataGridViewTextBoxColumn";
            // 
            // tblNormalClientsBindingSource
            // 
            this.tblNormalClientsBindingSource.DataMember = "tbl_NormalClients";
            this.tblNormalClientsBindingSource.DataSource = this.db_Yien_ExpressDataSet5;
            // 
            // db_Yien_ExpressDataSet5
            // 
            this.db_Yien_ExpressDataSet5.DataSetName = "db_Yien_ExpressDataSet5";
            this.db_Yien_ExpressDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.button3.TabIndex = 53;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yien_Express.Properties.Resources.Untitled_design__44_;
            this.pictureBox3.Location = new System.Drawing.Point(618, 306);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // tbl_NormalClientsTableAdapter
            // 
            this.tbl_NormalClientsTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CustomerDetails";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.CustomerDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormalClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private db_Yien_ExpressDataSet5 db_Yien_ExpressDataSet5;
        private System.Windows.Forms.BindingSource tblNormalClientsBindingSource;
        private db_Yien_ExpressDataSet5TableAdapters.tbl_NormalClientsTableAdapter tbl_NormalClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nccontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncaddressDataGridViewTextBoxColumn;
    }
}