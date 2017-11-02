namespace Inventory.Views
{
    partial class MainView
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
            this.MainViewStockButton = new System.Windows.Forms.Button();
            this.MainViewShippingButton = new System.Windows.Forms.Button();
            this.MainViewPeoductionButton = new System.Windows.Forms.Button();
            this.MainViewReportButton = new System.Windows.Forms.Button();
            this.MainViewTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainViewTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainViewStockButton
            // 
            this.MainViewStockButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainViewStockButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainViewStockButton.Location = new System.Drawing.Point(250, 250);
            this.MainViewStockButton.Margin = new System.Windows.Forms.Padding(250);
            this.MainViewStockButton.Name = "MainViewStockButton";
            this.MainViewStockButton.Size = new System.Drawing.Size(353, 72);
            this.MainViewStockButton.TabIndex = 0;
            this.MainViewStockButton.Text = "Stock";
            this.MainViewStockButton.UseVisualStyleBackColor = true;
            this.MainViewStockButton.Click += new System.EventHandler(this.MainViewStockButton_Click);
            // 
            // MainViewShippingButton
            // 
            this.MainViewShippingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainViewShippingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainViewShippingButton.Location = new System.Drawing.Point(1103, 250);
            this.MainViewShippingButton.Margin = new System.Windows.Forms.Padding(250);
            this.MainViewShippingButton.Name = "MainViewShippingButton";
            this.MainViewShippingButton.Size = new System.Drawing.Size(353, 72);
            this.MainViewShippingButton.TabIndex = 1;
            this.MainViewShippingButton.Text = "Shipping";
            this.MainViewShippingButton.UseVisualStyleBackColor = true;
            this.MainViewShippingButton.Click += new System.EventHandler(this.MainViewShippingButton_Click);
            // 
            // MainViewPeoductionButton
            // 
            this.MainViewPeoductionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainViewPeoductionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainViewPeoductionButton.Location = new System.Drawing.Point(250, 822);
            this.MainViewPeoductionButton.Margin = new System.Windows.Forms.Padding(250);
            this.MainViewPeoductionButton.Name = "MainViewPeoductionButton";
            this.MainViewPeoductionButton.Size = new System.Drawing.Size(353, 73);
            this.MainViewPeoductionButton.TabIndex = 2;
            this.MainViewPeoductionButton.Text = "Production";
            this.MainViewPeoductionButton.UseVisualStyleBackColor = true;
            this.MainViewPeoductionButton.Click += new System.EventHandler(this.MainViewPeoductionButton_Click);
            // 
            // MainViewReportButton
            // 
            this.MainViewReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainViewReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainViewReportButton.Location = new System.Drawing.Point(1103, 822);
            this.MainViewReportButton.Margin = new System.Windows.Forms.Padding(250);
            this.MainViewReportButton.Name = "MainViewReportButton";
            this.MainViewReportButton.Size = new System.Drawing.Size(353, 73);
            this.MainViewReportButton.TabIndex = 3;
            this.MainViewReportButton.Text = "Report";
            this.MainViewReportButton.UseVisualStyleBackColor = true;
            this.MainViewReportButton.Click += new System.EventHandler(this.MainViewReportButton_Click);
            // 
            // MainViewTableLayout
            // 
            this.MainViewTableLayout.ColumnCount = 2;
            this.MainViewTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainViewTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainViewTableLayout.Controls.Add(this.MainViewStockButton, 0, 0);
            this.MainViewTableLayout.Controls.Add(this.MainViewReportButton, 1, 1);
            this.MainViewTableLayout.Controls.Add(this.MainViewShippingButton, 1, 0);
            this.MainViewTableLayout.Controls.Add(this.MainViewPeoductionButton, 0, 1);
            this.MainViewTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainViewTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainViewTableLayout.Name = "MainViewTableLayout";
            this.MainViewTableLayout.RowCount = 2;
            this.MainViewTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainViewTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainViewTableLayout.Size = new System.Drawing.Size(1706, 1145);
            this.MainViewTableLayout.TabIndex = 4;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1706, 1145);
            this.Controls.Add(this.MainViewTableLayout);
            this.Name = "MainView";
            this.Text = "MainView";
            this.MainViewTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainViewStockButton;
        private System.Windows.Forms.Button MainViewShippingButton;
        private System.Windows.Forms.Button MainViewPeoductionButton;
        private System.Windows.Forms.Button MainViewReportButton;
        private System.Windows.Forms.TableLayoutPanel MainViewTableLayout;
    }
}

