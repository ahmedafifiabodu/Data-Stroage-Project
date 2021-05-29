
namespace Assignment_4
{
    partial class Menu_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.buttonDesserts = new System.Windows.Forms.Button();
            this.buttonSteaks = new System.Windows.Forms.Button();
            this.buttonSalads = new System.Windows.Forms.Button();
            this.buttonSeafood = new System.Windows.Forms.Button();
            this.buttonDrinks = new System.Windows.Forms.Button();
            this.buttonStarter = new System.Windows.Forms.Button();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonNotify = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonDeserialization = new System.Windows.Forms.Button();
            this.buttonAddStaffCustomer = new System.Windows.Forms.Button();
            this.toolTipAddCustomerOrStaff = new System.Windows.Forms.ToolTip(this.components);
            this.OrderView = new Assignment_4.OrderView();
            this.DessertMenu = new Assignment_4.DessertMenu();
            this.SteaksMenu = new Assignment_4.SteaksMenu();
            this.SaladsMenu = new Assignment_4.SaladsMenu();
            this.SeaFoodMenu = new Assignment_4.SeafoodMenu();
            this.DrinksMenu = new Assignment_4.DrinksMenu();
            this.StarterMenu = new Assignment_4.StarterMenu();
            this.HomeOrder = new Assignment_4.HomeMenu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.buttonDesserts);
            this.panel1.Controls.Add(this.buttonSteaks);
            this.panel1.Controls.Add(this.buttonSalads);
            this.panel1.Controls.Add(this.buttonSeafood);
            this.panel1.Controls.Add(this.buttonDrinks);
            this.panel1.Controls.Add(this.buttonStarter);
            this.panel1.Controls.Add(this.buttonHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 670);
            this.panel1.TabIndex = 0;
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
            // buttonDesserts
            // 
            this.buttonDesserts.FlatAppearance.BorderSize = 0;
            this.buttonDesserts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDesserts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDesserts.ForeColor = System.Drawing.Color.White;
            this.buttonDesserts.Image = ((System.Drawing.Image)(resources.GetObject("buttonDesserts.Image")));
            this.buttonDesserts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDesserts.Location = new System.Drawing.Point(11, 574);
            this.buttonDesserts.Name = "buttonDesserts";
            this.buttonDesserts.Size = new System.Drawing.Size(159, 77);
            this.buttonDesserts.TabIndex = 9;
            this.buttonDesserts.Text = "   Desserts";
            this.buttonDesserts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDesserts.UseVisualStyleBackColor = true;
            this.buttonDesserts.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonSteaks
            // 
            this.buttonSteaks.FlatAppearance.BorderSize = 0;
            this.buttonSteaks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSteaks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSteaks.ForeColor = System.Drawing.Color.White;
            this.buttonSteaks.Image = ((System.Drawing.Image)(resources.GetObject("buttonSteaks.Image")));
            this.buttonSteaks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSteaks.Location = new System.Drawing.Point(11, 491);
            this.buttonSteaks.Name = "buttonSteaks";
            this.buttonSteaks.Size = new System.Drawing.Size(159, 77);
            this.buttonSteaks.TabIndex = 8;
            this.buttonSteaks.Text = "   Steaks";
            this.buttonSteaks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSteaks.UseVisualStyleBackColor = true;
            this.buttonSteaks.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonSalads
            // 
            this.buttonSalads.FlatAppearance.BorderSize = 0;
            this.buttonSalads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalads.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalads.ForeColor = System.Drawing.Color.White;
            this.buttonSalads.Image = ((System.Drawing.Image)(resources.GetObject("buttonSalads.Image")));
            this.buttonSalads.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSalads.Location = new System.Drawing.Point(11, 408);
            this.buttonSalads.Name = "buttonSalads";
            this.buttonSalads.Size = new System.Drawing.Size(159, 77);
            this.buttonSalads.TabIndex = 7;
            this.buttonSalads.Text = "   Salads";
            this.buttonSalads.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSalads.UseVisualStyleBackColor = true;
            this.buttonSalads.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonSeafood
            // 
            this.buttonSeafood.FlatAppearance.BorderSize = 0;
            this.buttonSeafood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeafood.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSeafood.ForeColor = System.Drawing.Color.White;
            this.buttonSeafood.Image = ((System.Drawing.Image)(resources.GetObject("buttonSeafood.Image")));
            this.buttonSeafood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSeafood.Location = new System.Drawing.Point(11, 325);
            this.buttonSeafood.Name = "buttonSeafood";
            this.buttonSeafood.Size = new System.Drawing.Size(159, 77);
            this.buttonSeafood.TabIndex = 6;
            this.buttonSeafood.Text = "   Seafood";
            this.buttonSeafood.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSeafood.UseVisualStyleBackColor = true;
            this.buttonSeafood.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonDrinks
            // 
            this.buttonDrinks.FlatAppearance.BorderSize = 0;
            this.buttonDrinks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrinks.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrinks.ForeColor = System.Drawing.Color.White;
            this.buttonDrinks.Image = ((System.Drawing.Image)(resources.GetObject("buttonDrinks.Image")));
            this.buttonDrinks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrinks.Location = new System.Drawing.Point(11, 242);
            this.buttonDrinks.Name = "buttonDrinks";
            this.buttonDrinks.Size = new System.Drawing.Size(159, 77);
            this.buttonDrinks.TabIndex = 5;
            this.buttonDrinks.Text = "   Drinks";
            this.buttonDrinks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDrinks.UseVisualStyleBackColor = true;
            this.buttonDrinks.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonStarter
            // 
            this.buttonStarter.FlatAppearance.BorderSize = 0;
            this.buttonStarter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStarter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStarter.ForeColor = System.Drawing.Color.White;
            this.buttonStarter.Image = ((System.Drawing.Image)(resources.GetObject("buttonStarter.Image")));
            this.buttonStarter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStarter.Location = new System.Drawing.Point(11, 159);
            this.buttonStarter.Name = "buttonStarter";
            this.buttonStarter.Size = new System.Drawing.Size(159, 77);
            this.buttonStarter.TabIndex = 4;
            this.buttonStarter.Text = "   Starter";
            this.buttonStarter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStarter.UseVisualStyleBackColor = true;
            this.buttonStarter.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // buttonHome
            // 
            this.buttonHome.FlatAppearance.BorderSize = 0;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.ForeColor = System.Drawing.Color.White;
            this.buttonHome.Image = ((System.Drawing.Image)(resources.GetObject("buttonHome.Image")));
            this.buttonHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonHome.Location = new System.Drawing.Point(11, 76);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(159, 77);
            this.buttonHome.TabIndex = 3;
            this.buttonHome.Text = "   Home";
            this.buttonHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.Navigation_Buttons_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.panel2.Controls.Add(this.buttonNotify);
            this.panel2.Controls.Add(this.button11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(173, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 31);
            this.panel2.TabIndex = 1;
            this.panel2.Click += new System.EventHandler(this.HomeOrder_Click);
            this.panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
            // 
            // buttonNotify
            // 
            this.buttonNotify.FlatAppearance.BorderSize = 0;
            this.buttonNotify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNotify.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNotify.Image = ((System.Drawing.Image)(resources.GetObject("buttonNotify.Image")));
            this.buttonNotify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNotify.Location = new System.Drawing.Point(682, -1);
            this.buttonNotify.Name = "buttonNotify";
            this.buttonNotify.Size = new System.Drawing.Size(41, 32);
            this.buttonNotify.TabIndex = 28;
            this.buttonNotify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonNotify.UseVisualStyleBackColor = true;
            this.buttonNotify.MouseHover += new System.EventHandler(this.buttonNotify_MouseHover);
            // 
            // button11
            // 
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(729, -1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(41, 32);
            this.button11.TabIndex = 13;
            this.button11.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
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
            this.panel3.Click += new System.EventHandler(this.HomeOrder_Click);
            this.panel3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
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
            this.label2.Click += new System.EventHandler(this.HomeOrder_Click);
            this.label2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
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
            this.label1.Click += new System.EventHandler(this.HomeOrder_Click);
            this.label1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
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
            this.pictureBox1.Click += new System.EventHandler(this.HomeOrder_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Menu";
            this.label4.Click += new System.EventHandler(this.HomeOrder_Click);
            this.label4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
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
            this.label5.Click += new System.EventHandler(this.HomeOrder_Click);
            this.label5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
            // 
            // buttonDeserialization
            // 
            this.buttonDeserialization.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDeserialization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeserialization.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeserialization.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeserialization.Image")));
            this.buttonDeserialization.Location = new System.Drawing.Point(776, 146);
            this.buttonDeserialization.Name = "buttonDeserialization";
            this.buttonDeserialization.Size = new System.Drawing.Size(155, 41);
            this.buttonDeserialization.TabIndex = 25;
            this.buttonDeserialization.Text = "Deserialization";
            this.buttonDeserialization.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDeserialization.UseVisualStyleBackColor = true;
            this.buttonDeserialization.Click += new System.EventHandler(this.buttonDeserialization_Click);
            // 
            // buttonAddStaffCustomer
            // 
            this.buttonAddStaffCustomer.FlatAppearance.BorderSize = 0;
            this.buttonAddStaffCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStaffCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddStaffCustomer.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddStaffCustomer.Image")));
            this.buttonAddStaffCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddStaffCustomer.Location = new System.Drawing.Point(738, 37);
            this.buttonAddStaffCustomer.Name = "buttonAddStaffCustomer";
            this.buttonAddStaffCustomer.Size = new System.Drawing.Size(193, 46);
            this.buttonAddStaffCustomer.TabIndex = 31;
            this.buttonAddStaffCustomer.Text = "Add Staff/Customer";
            this.buttonAddStaffCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddStaffCustomer.UseVisualStyleBackColor = true;
            this.buttonAddStaffCustomer.Click += new System.EventHandler(this.buttonAddStaffCustomer_Click);
            this.buttonAddStaffCustomer.MouseHover += new System.EventHandler(this.buttonAddStaffCustomer_MouseHover);
            // 
            // toolTipAddCustomerOrStaff
            // 
            this.toolTipAddCustomerOrStaff.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipAddCustomerOrStaff.ToolTipTitle = "Messages";
            // 
            // OrderView
            // 
            this.OrderView.AutoScroll = true;
            this.OrderView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.OrderView.Location = new System.Drawing.Point(514, 32);
            this.OrderView.Name = "OrderView";
            this.OrderView.Size = new System.Drawing.Size(382, 370);
            this.OrderView.TabIndex = 30;
            this.OrderView.Visible = false;
            // 
            // DessertMenu
            // 
            this.DessertMenu.Location = new System.Drawing.Point(173, 193);
            this.DessertMenu.Name = "DessertMenu";
            this.DessertMenu.Size = new System.Drawing.Size(770, 477);
            this.DessertMenu.TabIndex = 20;
            this.DessertMenu.Load += new System.EventHandler(this.DessertMenu_Load);
            // 
            // SteaksMenu
            // 
            this.SteaksMenu.Location = new System.Drawing.Point(173, 193);
            this.SteaksMenu.Name = "SteaksMenu";
            this.SteaksMenu.Size = new System.Drawing.Size(770, 477);
            this.SteaksMenu.TabIndex = 19;
            // 
            // SaladsMenu
            // 
            this.SaladsMenu.Location = new System.Drawing.Point(173, 193);
            this.SaladsMenu.Name = "SaladsMenu";
            this.SaladsMenu.Size = new System.Drawing.Size(770, 477);
            this.SaladsMenu.TabIndex = 18;
            // 
            // SeaFoodMenu
            // 
            this.SeaFoodMenu.Location = new System.Drawing.Point(173, 193);
            this.SeaFoodMenu.Name = "SeaFoodMenu";
            this.SeaFoodMenu.Size = new System.Drawing.Size(770, 477);
            this.SeaFoodMenu.TabIndex = 17;
            // 
            // DrinksMenu
            // 
            this.DrinksMenu.Location = new System.Drawing.Point(173, 193);
            this.DrinksMenu.Name = "DrinksMenu";
            this.DrinksMenu.Size = new System.Drawing.Size(770, 477);
            this.DrinksMenu.TabIndex = 16;
            // 
            // StarterMenu
            // 
            this.StarterMenu.Location = new System.Drawing.Point(173, 193);
            this.StarterMenu.Name = "StarterMenu";
            this.StarterMenu.Size = new System.Drawing.Size(770, 477);
            this.StarterMenu.TabIndex = 15;
            // 
            // HomeOrder
            // 
            this.HomeOrder.Location = new System.Drawing.Point(173, 193);
            this.HomeOrder.Name = "HomeOrder";
            this.HomeOrder.Size = new System.Drawing.Size(770, 477);
            this.HomeOrder.TabIndex = 14;
            this.HomeOrder.Click += new System.EventHandler(this.HomeOrder_Click);
            this.HomeOrder.MouseClick += new System.Windows.Forms.MouseEventHandler(this.HomeOrder_Click);
            // 
            // Menu_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.ClientSize = new System.Drawing.Size(943, 670);
            this.Controls.Add(this.buttonAddStaffCustomer);
            this.Controls.Add(this.OrderView);
            this.Controls.Add(this.buttonDeserialization);
            this.Controls.Add(this.DessertMenu);
            this.Controls.Add(this.SteaksMenu);
            this.Controls.Add(this.SaladsMenu);
            this.Controls.Add(this.SeaFoodMenu);
            this.Controls.Add(this.DrinksMenu);
            this.Controls.Add(this.StarterMenu);
            this.Controls.Add(this.HomeOrder);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Menu";
            this.Click += new System.EventHandler(this.OrderView_MouseLeave);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Button buttonDrinks;
        private System.Windows.Forms.Button buttonStarter;
        private System.Windows.Forms.Button buttonSeafood;
        private System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button buttonDeserialization;
        private System.Windows.Forms.Button buttonNotify;
        private System.Windows.Forms.Button buttonDesserts;
        private System.Windows.Forms.Button buttonSteaks;
        private System.Windows.Forms.Button buttonSalads;
        private HomeMenu HomeOrder;
        private StarterMenu StarterMenu;
        private DrinksMenu DrinksMenu;
        private SeafoodMenu SeaFoodMenu;
        private SaladsMenu SaladsMenu;
        private SteaksMenu SteaksMenu;
        private DessertMenu DessertMenu;
        public OrderView OrderView;
        private System.Windows.Forms.Button buttonAddStaffCustomer;
        private System.Windows.Forms.ToolTip toolTipAddCustomerOrStaff;
    }
}

