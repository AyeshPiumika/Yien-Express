namespace Yien_Express
{
    partial class NormalClientManage
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
            this.txtNCAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNCNIC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNCContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNCName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNCID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvnc = new System.Windows.Forms.DataGridView();
            this.btnNCDelete = new System.Windows.Forms.Button();
            this.btnNCFind = new System.Windows.Forms.Button();
            this.btnNCUpdate = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.db_Yien_ExpressDataSet = new Yien_Express.db_Yien_ExpressDataSet();
            this.tblNormalClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_NormalClientsTableAdapter = new Yien_Express.db_Yien_ExpressDataSetTableAdapters.tbl_NormalClientsTableAdapter();
            this.ncidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nccontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncnicDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ncaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormalClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yien_Express.Properties.Resources.Untitled_design__43_;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtNCAddress
            // 
            this.txtNCAddress.Location = new System.Drawing.Point(594, 82);
            this.txtNCAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCAddress.Name = "txtNCAddress";
            this.txtNCAddress.Size = new System.Drawing.Size(104, 20);
            this.txtNCAddress.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(592, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Address :";
            // 
            // txtNCNIC
            // 
            this.txtNCNIC.Location = new System.Drawing.Point(466, 82);
            this.txtNCNIC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCNIC.Name = "txtNCNIC";
            this.txtNCNIC.Size = new System.Drawing.Size(104, 20);
            this.txtNCNIC.TabIndex = 46;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(464, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "NIC :";
            // 
            // txtNCContact
            // 
            this.txtNCContact.Location = new System.Drawing.Point(338, 82);
            this.txtNCContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCContact.Name = "txtNCContact";
            this.txtNCContact.Size = new System.Drawing.Size(104, 20);
            this.txtNCContact.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(336, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Contact :";
            // 
            // txtNCName
            // 
            this.txtNCName.Location = new System.Drawing.Point(211, 82);
            this.txtNCName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCName.Name = "txtNCName";
            this.txtNCName.Size = new System.Drawing.Size(104, 20);
            this.txtNCName.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(208, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Name :";
            // 
            // txtNCID
            // 
            this.txtNCID.Location = new System.Drawing.Point(82, 82);
            this.txtNCID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCID.Name = "txtNCID";
            this.txtNCID.Size = new System.Drawing.Size(104, 20);
            this.txtNCID.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(80, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "ID :";
            // 
            // dgvnc
            // 
            this.dgvnc.AutoGenerateColumns = false;
            this.dgvnc.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvnc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ncidDataGridViewTextBoxColumn,
            this.ncnameDataGridViewTextBoxColumn,
            this.nccontactDataGridViewTextBoxColumn,
            this.ncnicDataGridViewTextBoxColumn,
            this.ncaddressDataGridViewTextBoxColumn});
            this.dgvnc.DataSource = this.tblNormalClientsBindingSource;
            this.dgvnc.GridColor = System.Drawing.Color.Orange;
            this.dgvnc.Location = new System.Drawing.Point(199, 132);
            this.dgvnc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvnc.Name = "dgvnc";
            this.dgvnc.RowTemplate.Height = 24;
            this.dgvnc.Size = new System.Drawing.Size(544, 311);
            this.dgvnc.TabIndex = 49;
            // 
            // btnNCDelete
            // 
            this.btnNCDelete.BackColor = System.Drawing.Color.Orange;
            this.btnNCDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNCDelete.Location = new System.Drawing.Point(26, 353);
            this.btnNCDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNCDelete.Name = "btnNCDelete";
            this.btnNCDelete.Size = new System.Drawing.Size(136, 27);
            this.btnNCDelete.TabIndex = 53;
            this.btnNCDelete.Text = "Delete";
            this.btnNCDelete.UseVisualStyleBackColor = false;
            this.btnNCDelete.Click += new System.EventHandler(this.btnNCDelete_Click);
            // 
            // btnNCFind
            // 
            this.btnNCFind.BackColor = System.Drawing.Color.Orange;
            this.btnNCFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNCFind.Location = new System.Drawing.Point(26, 227);
            this.btnNCFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNCFind.Name = "btnNCFind";
            this.btnNCFind.Size = new System.Drawing.Size(136, 27);
            this.btnNCFind.TabIndex = 52;
            this.btnNCFind.Text = "Find";
            this.btnNCFind.UseVisualStyleBackColor = false;
            this.btnNCFind.Click += new System.EventHandler(this.btnNCFind_Click);
            // 
            // btnNCUpdate
            // 
            this.btnNCUpdate.BackColor = System.Drawing.Color.Orange;
            this.btnNCUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNCUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNCUpdate.Location = new System.Drawing.Point(26, 292);
            this.btnNCUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNCUpdate.Name = "btnNCUpdate";
            this.btnNCUpdate.Size = new System.Drawing.Size(136, 27);
            this.btnNCUpdate.TabIndex = 51;
            this.btnNCUpdate.Text = "Update";
            this.btnNCUpdate.UseVisualStyleBackColor = false;
            this.btnNCUpdate.Click += new System.EventHandler(this.btnNCUpdate_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yien_Express.Properties.Resources.Untitled_design__44_;
            this.pictureBox3.Location = new System.Drawing.Point(617, 306);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // btnViewAll
            // 
            this.btnViewAll.BackColor = System.Drawing.Color.Orange;
            this.btnViewAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnViewAll.Location = new System.Drawing.Point(26, 169);
            this.btnViewAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(136, 27);
            this.btnViewAll.TabIndex = 55;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = false;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // db_Yien_ExpressDataSet
            // 
            this.db_Yien_ExpressDataSet.DataSetName = "db_Yien_ExpressDataSet";
            this.db_Yien_ExpressDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblNormalClientsBindingSource
            // 
            this.tblNormalClientsBindingSource.DataMember = "tbl_NormalClients";
            this.tblNormalClientsBindingSource.DataSource = this.db_Yien_ExpressDataSet;
            // 
            // tbl_NormalClientsTableAdapter
            // 
            this.tbl_NormalClientsTableAdapter.ClearBeforeFill = true;
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
            // NormalClientManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 480);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnNCDelete);
            this.Controls.Add(this.btnNCFind);
            this.Controls.Add(this.btnNCUpdate);
            this.Controls.Add(this.dgvnc);
            this.Controls.Add(this.txtNCAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNCNIC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNCContact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNCName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNCID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "NormalClientManage";
            this.Text = "NormalClientManage";
            this.Load += new System.EventHandler(this.NormalClientManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNormalClientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNCAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNCNIC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNCContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNCName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNCID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvnc;
        private System.Windows.Forms.Button btnNCDelete;
        private System.Windows.Forms.Button btnNCFind;
        private System.Windows.Forms.Button btnNCUpdate;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnViewAll;
        private db_Yien_ExpressDataSet db_Yien_ExpressDataSet;
        private System.Windows.Forms.BindingSource tblNormalClientsBindingSource;
        private db_Yien_ExpressDataSetTableAdapters.tbl_NormalClientsTableAdapter tbl_NormalClientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nccontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ncaddressDataGridViewTextBoxColumn;
    }
}