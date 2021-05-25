
namespace Assignment_4
{
    partial class OrderView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.labelOrderNumber = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelOrderCount = new System.Windows.Forms.Label();
            this.labelPriceTotal = new System.Windows.Forms.Label();
            this.saladsMenu1 = new Assignment_4.SaladsMenu();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainPanal = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Order Number";
            // 
            // labelOrderNumber
            // 
            this.labelOrderNumber.AutoSize = true;
            this.labelOrderNumber.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderNumber.ForeColor = System.Drawing.Color.White;
            this.labelOrderNumber.Location = new System.Drawing.Point(130, 9);
            this.labelOrderNumber.Name = "labelOrderNumber";
            this.labelOrderNumber.Size = new System.Drawing.Size(28, 19);
            this.labelOrderNumber.TabIndex = 8;
            this.labelOrderNumber.Text = "#0";
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(11, 28);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(81, 17);
            this.labelTimer.TabIndex = 8;
            this.labelTimer.Text = "23 Feb 2021";
            // 
            // labelOrderCount
            // 
            this.labelOrderCount.AutoSize = true;
            this.labelOrderCount.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOrderCount.ForeColor = System.Drawing.Color.White;
            this.labelOrderCount.Location = new System.Drawing.Point(303, 328);
            this.labelOrderCount.Name = "labelOrderCount";
            this.labelOrderCount.Size = new System.Drawing.Size(61, 17);
            this.labelOrderCount.TabIndex = 8;
            this.labelOrderCount.Text = "X0 Items";
            // 
            // labelPriceTotal
            // 
            this.labelPriceTotal.AutoSize = true;
            this.labelPriceTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceTotal.ForeColor = System.Drawing.Color.White;
            this.labelPriceTotal.Location = new System.Drawing.Point(302, 345);
            this.labelPriceTotal.Name = "labelPriceTotal";
            this.labelPriceTotal.Size = new System.Drawing.Size(49, 19);
            this.labelPriceTotal.TabIndex = 8;
            this.labelPriceTotal.Text = "$0.00";
            // 
            // saladsMenu1
            // 
            this.saladsMenu1.Location = new System.Drawing.Point(55, 63);
            this.saladsMenu1.Name = "saladsMenu1";
            this.saladsMenu1.Size = new System.Drawing.Size(8, 8);
            this.saladsMenu1.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(13)))), ((int)(((byte)(80)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(-4, -6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 10);
            this.textBox1.TabIndex = 18;
            // 
            // MainPanal
            // 
            this.MainPanal.AutoScroll = true;
            this.MainPanal.Controls.Add(this.dataGridView1);
            this.MainPanal.Controls.Add(this.textBox1);
            this.MainPanal.Location = new System.Drawing.Point(0, 48);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(379, 273);
            this.MainPanal.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(70)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderName,
            this.OrderPrice,
            this.OrderQuantity});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Size = new System.Drawing.Size(376, 267);
            this.dataGridView1.TabIndex = 19;
            // 
            // OrderName
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderName.DefaultCellStyle = dataGridViewCellStyle2;
            this.OrderName.HeaderText = "Order Name";
            this.OrderName.Name = "OrderName";
            this.OrderName.ReadOnly = true;
            this.OrderName.Width = 150;
            // 
            // OrderPrice
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderPrice.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderPrice.HeaderText = "Price";
            this.OrderPrice.Name = "OrderPrice";
            this.OrderPrice.ReadOnly = true;
            // 
            // OrderQuantity
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.OrderQuantity.DefaultCellStyle = dataGridViewCellStyle4;
            this.OrderQuantity.HeaderText = "Quantity";
            this.OrderQuantity.Name = "OrderQuantity";
            this.OrderQuantity.ReadOnly = true;
            // 
            // OrderView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(54)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.MainPanal);
            this.Controls.Add(this.labelPriceTotal);
            this.Controls.Add(this.saladsMenu1);
            this.Controls.Add(this.labelOrderNumber);
            this.Controls.Add(this.labelOrderCount);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.label5);
            this.Name = "OrderView";
            this.Size = new System.Drawing.Size(382, 370);
            this.Load += new System.EventHandler(this.OrderView_Load);
            this.MainPanal.ResumeLayout(false);
            this.MainPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelOrderNumber;
        public SaladsMenu saladsMenu1;
        public System.Windows.Forms.Label labelTimer;
        public System.Windows.Forms.Label labelOrderCount;
        public System.Windows.Forms.Label labelPriceTotal;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Panel MainPanal;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderQuantity;
    }
}
