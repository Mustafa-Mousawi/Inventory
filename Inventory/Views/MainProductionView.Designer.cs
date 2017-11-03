namespace Inventory.Views
{
    partial class MainProductionView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainShippingSKULabel = new System.Windows.Forms.Label();
            this.MainShippingQuantityLabel = new System.Windows.Forms.Label();
            this.MainShippingShipButton = new System.Windows.Forms.Button();
            this.MainShippingSKUTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.365738F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.86011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.34499F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.33432F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.textBox1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainShippingSKULabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainShippingQuantityLabel, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainShippingShipButton, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainShippingSKUTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.662835F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.75479F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.48659F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1683, 1156);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(870, 20);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(471, 48);
            this.textBox1.TabIndex = 4;
            // 
            // MainShippingSKULabel
            // 
            this.MainShippingSKULabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainShippingSKULabel.AutoSize = true;
            this.MainShippingSKULabel.Location = new System.Drawing.Point(3, 0);
            this.MainShippingSKULabel.Name = "MainShippingSKULabel";
            this.MainShippingSKULabel.Size = new System.Drawing.Size(151, 88);
            this.MainShippingSKULabel.TabIndex = 0;
            this.MainShippingSKULabel.Text = "Enter SKU:";
            this.MainShippingSKULabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainShippingQuantityLabel
            // 
            this.MainShippingQuantityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainShippingQuantityLabel.AutoSize = true;
            this.MainShippingQuantityLabel.Location = new System.Drawing.Point(629, 0);
            this.MainShippingQuantityLabel.Name = "MainShippingQuantityLabel";
            this.MainShippingQuantityLabel.Size = new System.Drawing.Size(235, 88);
            this.MainShippingQuantityLabel.TabIndex = 1;
            this.MainShippingQuantityLabel.Text = "Enter Quantity:";
            this.MainShippingQuantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainShippingShipButton
            // 
            this.MainShippingShipButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainShippingShipButton.Location = new System.Drawing.Point(1364, 20);
            this.MainShippingShipButton.Margin = new System.Windows.Forms.Padding(20);
            this.MainShippingShipButton.Name = "MainShippingShipButton";
            this.MainShippingShipButton.Size = new System.Drawing.Size(299, 48);
            this.MainShippingShipButton.TabIndex = 2;
            this.MainShippingShipButton.Text = "Produced";
            this.MainShippingShipButton.UseVisualStyleBackColor = true;
            this.MainShippingShipButton.Click += new System.EventHandler(this.MainShippingShipButton_Click);
            // 
            // MainShippingSKUTextBox
            // 
            this.MainShippingSKUTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainShippingSKUTextBox.Location = new System.Drawing.Point(160, 20);
            this.MainShippingSKUTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 20);
            this.MainShippingSKUTextBox.Multiline = true;
            this.MainShippingSKUTextBox.Name = "MainShippingSKUTextBox";
            this.MainShippingSKUTextBox.Size = new System.Drawing.Size(463, 48);
            this.MainShippingSKUTextBox.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.Name,
            this.Quantity,
            this.Date});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 37;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1677, 847);
            this.dataGridView1.TabIndex = 5;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            // 
            // Name
            // 
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            // 
            // MainProductionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1683, 1156);
            this.Controls.Add(this.tableLayoutPanel1);
            //this.Name = "MainProductionView";
            this.Text = "MainViewProductionView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label MainShippingSKULabel;
        private System.Windows.Forms.Label MainShippingQuantityLabel;
        private System.Windows.Forms.Button MainShippingShipButton;
        private System.Windows.Forms.TextBox MainShippingSKUTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}