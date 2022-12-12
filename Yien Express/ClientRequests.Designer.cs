namespace Yien_Express
{
    partial class ClientRequests
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnApprove = new System.Windows.Forms.Button();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCCID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.db_Yien_ExpressDataSet1 = new Yien_Express.db_Yien_ExpressDataSet1();
            this.tblCorporateClientRequestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CorporateClientRequestTableAdapter = new Yien_Express.db_Yien_ExpressDataSet1TableAdapters.tbl_CorporateClientRequestTableAdapter();
            this.ccidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccontactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccaddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccusernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccpasswordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSelect = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCorporateClientRequestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Yien_Express.Properties.Resources.Untitled_design__43_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(852, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ccidDataGridViewTextBoxColumn,
            this.ccnameDataGridViewTextBoxColumn,
            this.cccontactDataGridViewTextBoxColumn,
            this.ccaddressDataGridViewTextBoxColumn,
            this.ccusernameDataGridViewTextBoxColumn,
            this.ccpasswordDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblCorporateClientRequestBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Orange;
            this.dataGridView1.Location = new System.Drawing.Point(212, 98);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(624, 335);
            this.dataGridView1.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Yien_Express.Properties.Resources.Untitled_design__44_;
            this.pictureBox3.Location = new System.Drawing.Point(687, 321);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(164, 176);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSelect);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCCID);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 52);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 426);
            this.panel1.TabIndex = 21;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(14, 319);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(168, 20);
            this.txtPassword.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(11, 296);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Password :";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(14, 269);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(168, 20);
            this.txtUsername.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(11, 245);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Username :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(14, 221);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(168, 20);
            this.txtAddress.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(11, 197);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Address :";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(14, 171);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(168, 20);
            this.txtContact.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Contact :";
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Orange;
            this.btnApprove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnApprove.Location = new System.Drawing.Point(26, 386);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(136, 27);
            this.btnApprove.TabIndex = 18;
            this.btnApprove.Text = "Approve";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Location = new System.Drawing.Point(14, 119);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(168, 20);
            this.txtCompanyName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(11, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Company Name :";
            // 
            // txtCCID
            // 
            this.txtCCID.Location = new System.Drawing.Point(14, 69);
            this.txtCCID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCID.Name = "txtCCID";
            this.txtCCID.Size = new System.Drawing.Size(168, 20);
            this.txtCCID.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(11, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "ID :";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(34, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Client Requests";
            // 
            // db_Yien_ExpressDataSet1
            // 
            this.db_Yien_ExpressDataSet1.DataSetName = "db_Yien_ExpressDataSet1";
            this.db_Yien_ExpressDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblCorporateClientRequestBindingSource
            // 
            this.tblCorporateClientRequestBindingSource.DataMember = "tbl_CorporateClientRequest";
            this.tblCorporateClientRequestBindingSource.DataSource = this.db_Yien_ExpressDataSet1;
            // 
            // tbl_CorporateClientRequestTableAdapter
            // 
            this.tbl_CorporateClientRequestTableAdapter.ClearBeforeFill = true;
            // 
            // ccidDataGridViewTextBoxColumn
            // 
            this.ccidDataGridViewTextBoxColumn.DataPropertyName = "ccid";
            this.ccidDataGridViewTextBoxColumn.HeaderText = "ccid";
            this.ccidDataGridViewTextBoxColumn.Name = "ccidDataGridViewTextBoxColumn";
            this.ccidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ccnameDataGridViewTextBoxColumn
            // 
            this.ccnameDataGridViewTextBoxColumn.DataPropertyName = "ccname";
            this.ccnameDataGridViewTextBoxColumn.HeaderText = "ccname";
            this.ccnameDataGridViewTextBoxColumn.Name = "ccnameDataGridViewTextBoxColumn";
            // 
            // cccontactDataGridViewTextBoxColumn
            // 
            this.cccontactDataGridViewTextBoxColumn.DataPropertyName = "cccontact";
            this.cccontactDataGridViewTextBoxColumn.HeaderText = "cccontact";
            this.cccontactDataGridViewTextBoxColumn.Name = "cccontactDataGridViewTextBoxColumn";
            // 
            // ccaddressDataGridViewTextBoxColumn
            // 
            this.ccaddressDataGridViewTextBoxColumn.DataPropertyName = "ccaddress";
            this.ccaddressDataGridViewTextBoxColumn.HeaderText = "ccaddress";
            this.ccaddressDataGridViewTextBoxColumn.Name = "ccaddressDataGridViewTextBoxColumn";
            // 
            // ccusernameDataGridViewTextBoxColumn
            // 
            this.ccusernameDataGridViewTextBoxColumn.DataPropertyName = "ccusername";
            this.ccusernameDataGridViewTextBoxColumn.HeaderText = "ccusername";
            this.ccusernameDataGridViewTextBoxColumn.Name = "ccusernameDataGridViewTextBoxColumn";
            // 
            // ccpasswordDataGridViewTextBoxColumn
            // 
            this.ccpasswordDataGridViewTextBoxColumn.DataPropertyName = "ccpassword";
            this.ccpasswordDataGridViewTextBoxColumn.HeaderText = "ccpassword";
            this.ccpasswordDataGridViewTextBoxColumn.Name = "ccpasswordDataGridViewTextBoxColumn";
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.Orange;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSelect.Location = new System.Drawing.Point(26, 354);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(136, 27);
            this.btnSelect.TabIndex = 27;
            this.btnSelect.Text = "Select";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // ClientRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 490);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ClientRequests";
            this.Text = "ClientRequests";
            this.Load += new System.EventHandler(this.ClientRequests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_Yien_ExpressDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCorporateClientRequestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCCID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private db_Yien_ExpressDataSet1 db_Yien_ExpressDataSet1;
        private System.Windows.Forms.BindingSource tblCorporateClientRequestBindingSource;
        private db_Yien_ExpressDataSet1TableAdapters.tbl_CorporateClientRequestTableAdapter tbl_CorporateClientRequestTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccontactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccusernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccpasswordDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSelect;
    }
}