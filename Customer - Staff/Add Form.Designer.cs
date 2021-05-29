
namespace Assignment_4
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.panelSelect = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.buttonDisplayCustomer = new System.Windows.Forms.Button();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonAddStaff = new System.Windows.Forms.Button();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonExit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.panelCustomer = new System.Windows.Forms.Panel();
            this.display_Staff1 = new Assignment_4.Customer___Staff.Display_Staff();
            this.add_Customer1 = new Assignment_4.Customer___Staff.Add_Customer();
            this.DisplayCustomerInfo = new Assignment_4.Customer.DisplayCustomer();
            this.add_Staff1 = new Assignment_4.Customer___Staff.Add_Staff();
            this.panelSelect.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSelect
            // 
            this.panelSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.panelSelect.Controls.Add(this.Sidepanel);
            this.panelSelect.Controls.Add(this.buttonDisplayCustomer);
            this.panelSelect.Controls.Add(this.buttonView);
            this.panelSelect.Controls.Add(this.buttonAddStaff);
            this.panelSelect.Controls.Add(this.buttonAddCustomer);
            this.panelSelect.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelect.Location = new System.Drawing.Point(0, 0);
            this.panelSelect.Name = "panelSelect";
            this.panelSelect.Size = new System.Drawing.Size(173, 663);
            this.panelSelect.TabIndex = 0;
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.Sidepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sidepanel.Location = new System.Drawing.Point(0, 76);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(10, 77);
            this.Sidepanel.TabIndex = 3;
            // 
            // buttonDisplayCustomer
            // 
            this.buttonDisplayCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayCustomer.FlatAppearance.BorderSize = 0;
            this.buttonDisplayCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDisplayCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonDisplayCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonDisplayCustomer.Image")));
            this.buttonDisplayCustomer.Location = new System.Drawing.Point(11, 325);
            this.buttonDisplayCustomer.Name = "buttonDisplayCustomer";
            this.buttonDisplayCustomer.Size = new System.Drawing.Size(159, 77);
            this.buttonDisplayCustomer.TabIndex = 4;
            this.buttonDisplayCustomer.Text = "   Display Staff";
            this.buttonDisplayCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDisplayCustomer.UseVisualStyleBackColor = true;
            this.buttonDisplayCustomer.Click += new System.EventHandler(this.buttonDisplayCustomer_Click);
            // 
            // buttonView
            // 
            this.buttonView.FlatAppearance.BorderSize = 0;
            this.buttonView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonView.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonView.ForeColor = System.Drawing.Color.White;
            this.buttonView.Image = ((System.Drawing.Image)(resources.GetObject("buttonView.Image")));
            this.buttonView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonView.Location = new System.Drawing.Point(11, 242);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(159, 77);
            this.buttonView.TabIndex = 4;
            this.buttonView.Text = "Display Customers";
            this.buttonView.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.ButtonView_Click);
            // 
            // buttonAddStaff
            // 
            this.buttonAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddStaff.FlatAppearance.BorderSize = 0;
            this.buttonAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStaff.ForeColor = System.Drawing.Color.White;
            this.buttonAddStaff.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddStaff.Image")));
            this.buttonAddStaff.Location = new System.Drawing.Point(11, 159);
            this.buttonAddStaff.Name = "buttonAddStaff";
            this.buttonAddStaff.Size = new System.Drawing.Size(159, 77);
            this.buttonAddStaff.TabIndex = 3;
            this.buttonAddStaff.Text = "Add Staff";
            this.buttonAddStaff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddStaff.UseVisualStyleBackColor = true;
            this.buttonAddStaff.Click += new System.EventHandler(this.buttonAddStaff_Click);
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCustomer.ForeColor = System.Drawing.Color.White;
            this.buttonAddCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddCustomer.Image")));
            this.buttonAddCustomer.Location = new System.Drawing.Point(11, 76);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(159, 77);
            this.buttonAddCustomer.TabIndex = 3;
            this.buttonAddCustomer.Text = "Add Customer";
            this.buttonAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.buttonExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(715, 31);
            this.panel2.TabIndex = 1;
            // 
            // buttonExit
            // 
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExit.Location = new System.Drawing.Point(674, -1);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(41, 32);
            this.buttonExit.TabIndex = 13;
            this.buttonExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(222, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(109, 152);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Restourent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(19, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fast Food";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(103, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Customer Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(337, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "By: Ahmed Afifi Abdou Afifi - Class 20";
            // 
            // buttonMenu
            // 
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonMenu.Image")));
            this.buttonMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMenu.Location = new System.Drawing.Point(776, 34);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(109, 50);
            this.buttonMenu.TabIndex = 12;
            this.buttonMenu.Text = "Back To Menu";
            this.buttonMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panelCustomer
            // 
            this.panelCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.panelCustomer.Controls.Add(this.display_Staff1);
            this.panelCustomer.Controls.Add(this.add_Customer1);
            this.panelCustomer.Controls.Add(this.DisplayCustomerInfo);
            this.panelCustomer.Controls.Add(this.add_Staff1);
            this.panelCustomer.Location = new System.Drawing.Point(173, 193);
            this.panelCustomer.Name = "panelCustomer";
            this.panelCustomer.Size = new System.Drawing.Size(715, 470);
            this.panelCustomer.TabIndex = 26;
            // 
            // display_Staff1
            // 
            this.display_Staff1.Location = new System.Drawing.Point(0, 0);
            this.display_Staff1.Name = "display_Staff1";
            this.display_Staff1.Size = new System.Drawing.Size(715, 470);
            this.display_Staff1.TabIndex = 64;
            this.display_Staff1.Load += new System.EventHandler(this.display_Staff1_Load);
            // 
            // add_Customer1
            // 
            this.add_Customer1.Location = new System.Drawing.Point(0, 0);
            this.add_Customer1.Name = "add_Customer1";
            this.add_Customer1.Size = new System.Drawing.Size(715, 470);
            this.add_Customer1.TabIndex = 0;
            // 
            // DisplayCustomerInfo
            // 
            this.DisplayCustomerInfo.Location = new System.Drawing.Point(0, 0);
            this.DisplayCustomerInfo.Name = "DisplayCustomerInfo";
            this.DisplayCustomerInfo.Size = new System.Drawing.Size(715, 470);
            this.DisplayCustomerInfo.TabIndex = 62;
            // 
            // add_Staff1
            // 
            this.add_Staff1.Location = new System.Drawing.Point(0, 0);
            this.add_Staff1.Name = "add_Staff1";
            this.add_Staff1.Size = new System.Drawing.Size(715, 470);
            this.add_Staff1.TabIndex = 63;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(888, 663);
            this.Controls.Add(this.panelCustomer);
            this.Controls.Add(this.buttonMenu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Menu";
            this.panelSelect.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelCustomer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelSelect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAddCustomer;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonExit;
        private Customer.DisplayCustomer DisplayCustomerInfo;
        private System.Windows.Forms.Button buttonDisplayCustomer;
        private System.Windows.Forms.Button buttonAddStaff;
        public System.Windows.Forms.Panel panelCustomer;
        private Customer___Staff.Add_Customer add_Customer1;
        private Customer___Staff.Add_Staff add_Staff1;
        private Customer___Staff.Display_Staff display_Staff1;
    }
}

