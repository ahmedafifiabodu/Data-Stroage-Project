
namespace Assignment_4
{
    partial class HomeMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeMenu));
            this.labelHomePrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelHomeName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOrderNow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomeNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // labelHomePrice
            // 
            this.labelHomePrice.AutoSize = true;
            this.labelHomePrice.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.labelHomePrice.Location = new System.Drawing.Point(15, 28);
            this.labelHomePrice.Name = "labelHomePrice";
            this.labelHomePrice.Size = new System.Drawing.Size(401, 123);
            this.labelHomePrice.TabIndex = 8;
            this.labelHomePrice.Text = "$19.99";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(15, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Only";
            // 
            // labelHomeName
            // 
            this.labelHomeName.AutoSize = true;
            this.labelHomeName.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHomeName.Location = new System.Drawing.Point(52, 151);
            this.labelHomeName.Name = "labelHomeName";
            this.labelHomeName.Size = new System.Drawing.Size(397, 41);
            this.labelHomeName.TabIndex = 7;
            this.labelHomeName.Text = "Vegetable Tagine Dish";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "With Onions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(342, 119);
            this.label6.TabIndex = 7;
            this.label6.Text = resources.GetString("label6.Text");
            // 
            // buttonOrderNow
            // 
            this.buttonOrderNow.BackColor = System.Drawing.Color.Maroon;
            this.buttonOrderNow.FlatAppearance.BorderSize = 0;
            this.buttonOrderNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOrderNow.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrderNow.ForeColor = System.Drawing.Color.White;
            this.buttonOrderNow.Location = new System.Drawing.Point(36, 400);
            this.buttonOrderNow.Name = "buttonOrderNow";
            this.buttonOrderNow.Size = new System.Drawing.Size(329, 60);
            this.buttonOrderNow.TabIndex = 10;
            this.buttonOrderNow.Text = "Order NOW";
            this.buttonOrderNow.UseVisualStyleBackColor = false;
            this.buttonOrderNow.Click += new System.EventHandler(this.buttonOrderNow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(444, 154);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 294);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // HomeNumericUpDown
            // 
            this.HomeNumericUpDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.HomeNumericUpDown.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HomeNumericUpDown.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeNumericUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(199)))), ((int)(((byte)(219)))));
            this.HomeNumericUpDown.Location = new System.Drawing.Point(377, 417);
            this.HomeNumericUpDown.Name = "HomeNumericUpDown";
            this.HomeNumericUpDown.ReadOnly = true;
            this.HomeNumericUpDown.Size = new System.Drawing.Size(54, 29);
            this.HomeNumericUpDown.TabIndex = 14;
            this.HomeNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HomeNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HomeNumericUpDown.ValueChanged += new System.EventHandler(this.HomeNumericUpDown_ValueChanged);
            // 
            // HomeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.HomeNumericUpDown);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOrderNow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelHomePrice);
            this.Controls.Add(this.labelHomeName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Name = "HomeMenu";
            this.Size = new System.Drawing.Size(770, 477);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HomeNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHomePrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelHomeName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOrderNow;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown HomeNumericUpDown;
    }
}
