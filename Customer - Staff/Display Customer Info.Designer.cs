
namespace Assignment_4.Customer
{
    partial class DisplayCustomer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayCustomer));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreetAddressLine2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateProvince = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PostalZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HearAboutUs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Feedback = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Suggestions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Recommend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstName,
            this.LastName,
            this.StreetAddress,
            this.StreetAddressLine2,
            this.City,
            this.StateProvince,
            this.PostalZipCode,
            this.Phone,
            this.Email,
            this.HearAboutUs,
            this.Feedback,
            this.Suggestions,
            this.Recommend});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(715, 413);
            this.dataGridView1.TabIndex = 0;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            // 
            // LastName
            // 
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            // 
            // StreetAddress
            // 
            this.StreetAddress.HeaderText = "Street Address";
            this.StreetAddress.Name = "StreetAddress";
            // 
            // StreetAddressLine2
            // 
            this.StreetAddressLine2.HeaderText = "Street Address Line 2";
            this.StreetAddressLine2.Name = "StreetAddressLine2";
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            // 
            // StateProvince
            // 
            this.StateProvince.HeaderText = "State / Province";
            this.StateProvince.Name = "StateProvince";
            // 
            // PostalZipCode
            // 
            this.PostalZipCode.HeaderText = "Postal / ZipCode";
            this.PostalZipCode.Name = "PostalZipCode";
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // HearAboutUs
            // 
            this.HearAboutUs.HeaderText = "Hear About Us";
            this.HearAboutUs.Name = "HearAboutUs";
            // 
            // Feedback
            // 
            this.Feedback.HeaderText = "Feedback";
            this.Feedback.Name = "Feedback";
            // 
            // Suggestions
            // 
            this.Suggestions.HeaderText = "Suggestions";
            this.Suggestions.Name = "Suggestions";
            // 
            // Recommend
            // 
            this.Recommend.HeaderText = "Recommend";
            this.Recommend.Name = "Recommend";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.Location = new System.Drawing.Point(316, 416);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(128, 51);
            this.buttonSubmit.TabIndex = 26;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Image = ((System.Drawing.Image)(resources.GetObject("buttonAdd.Image")));
            this.buttonAdd.Location = new System.Drawing.Point(450, 416);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(128, 51);
            this.buttonAdd.TabIndex = 27;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonView.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.Image = ((System.Drawing.Image)(resources.GetObject("buttonView.Image")));
            this.buttonView.Location = new System.Drawing.Point(584, 416);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(128, 51);
            this.buttonView.TabIndex = 27;
            this.buttonView.Text = "View";
            this.buttonView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // DisplayCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DisplayCustomer";
            this.Size = new System.Drawing.Size(715, 470);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreetAddressLine2;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn PostalZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn HearAboutUs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Feedback;
        private System.Windows.Forms.DataGridViewTextBoxColumn Suggestions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Recommend;
    }
}
