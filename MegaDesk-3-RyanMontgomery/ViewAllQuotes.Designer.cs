namespace MegaDesk_3_RyanMontgomery
{
    partial class ViewAllQuotes
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
            this.QuotesTable = new System.Windows.Forms.TableLayoutPanel();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.DeskSizeLabel = new System.Windows.Forms.Label();
            this.DeskMaterialLabel = new System.Windows.Forms.Label();
            this.DrawersLabel = new System.Windows.Forms.Label();
            this.DeskCostLabel = new System.Windows.Forms.Label();
            this.ShippingTypeLabel = new System.Windows.Forms.Label();
            this.ShippingCostLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.QuotesTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuotesTable
            // 
            this.QuotesTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.QuotesTable.ColumnCount = 8;
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.QuotesTable.Controls.Add(this.CustomerNameLabel, 0, 0);
            this.QuotesTable.Controls.Add(this.DeskSizeLabel, 1, 0);
            this.QuotesTable.Controls.Add(this.DeskMaterialLabel, 2, 0);
            this.QuotesTable.Controls.Add(this.DrawersLabel, 3, 0);
            this.QuotesTable.Controls.Add(this.DeskCostLabel, 4, 0);
            this.QuotesTable.Controls.Add(this.ShippingCostLabel, 6, 0);
            this.QuotesTable.Controls.Add(this.TotalCostLabel, 7, 0);
            this.QuotesTable.Controls.Add(this.ShippingTypeLabel, 5, 0);
            this.QuotesTable.Location = new System.Drawing.Point(12, 12);
            this.QuotesTable.Name = "QuotesTable";
            this.QuotesTable.RowCount = 1;
            this.QuotesTable.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.QuotesTable.Size = new System.Drawing.Size(1202, 587);
            this.QuotesTable.TabIndex = 0;
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(4, 1);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerNameLabel.Size = new System.Drawing.Size(143, 26);
            this.CustomerNameLabel.TabIndex = 0;
            this.CustomerNameLabel.Text = "Customer Name";
            // 
            // DeskSizeLabel
            // 
            this.DeskSizeLabel.AutoSize = true;
            this.DeskSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSizeLabel.Location = new System.Drawing.Point(362, 1);
            this.DeskSizeLabel.Name = "DeskSizeLabel";
            this.DeskSizeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DeskSizeLabel.Size = new System.Drawing.Size(101, 46);
            this.DeskSizeLabel.TabIndex = 1;
            this.DeskSizeLabel.Text = "Desk Size (in²)";
            // 
            // DeskMaterialLabel
            // 
            this.DeskMaterialLabel.AutoSize = true;
            this.DeskMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskMaterialLabel.Location = new System.Drawing.Point(482, 1);
            this.DeskMaterialLabel.Name = "DeskMaterialLabel";
            this.DeskMaterialLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DeskMaterialLabel.Size = new System.Drawing.Size(79, 46);
            this.DeskMaterialLabel.TabIndex = 2;
            this.DeskMaterialLabel.Text = "Desk Material";
            // 
            // DrawersLabel
            // 
            this.DrawersLabel.AutoSize = true;
            this.DrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersLabel.Location = new System.Drawing.Point(602, 1);
            this.DrawersLabel.Name = "DrawersLabel";
            this.DrawersLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DrawersLabel.Size = new System.Drawing.Size(81, 46);
            this.DrawersLabel.TabIndex = 3;
            this.DrawersLabel.Text = "# Of Drawers";
            // 
            // DeskCostLabel
            // 
            this.DeskCostLabel.AutoSize = true;
            this.DeskCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskCostLabel.Location = new System.Drawing.Point(722, 1);
            this.DeskCostLabel.Name = "DeskCostLabel";
            this.DeskCostLabel.Padding = new System.Windows.Forms.Padding(3);
            this.DeskCostLabel.Size = new System.Drawing.Size(101, 26);
            this.DeskCostLabel.TabIndex = 4;
            this.DeskCostLabel.Text = "Desk Price";
            // 
            // ShippingTypeLabel
            // 
            this.ShippingTypeLabel.AutoSize = true;
            this.ShippingTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingTypeLabel.Location = new System.Drawing.Point(842, 1);
            this.ShippingTypeLabel.Name = "ShippingTypeLabel";
            this.ShippingTypeLabel.Padding = new System.Windows.Forms.Padding(3);
            this.ShippingTypeLabel.Size = new System.Drawing.Size(90, 46);
            this.ShippingTypeLabel.TabIndex = 5;
            this.ShippingTypeLabel.Text = "Shipping Speed";
            // 
            // ShippingCostLabel
            // 
            this.ShippingCostLabel.AutoSize = true;
            this.ShippingCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingCostLabel.Location = new System.Drawing.Point(962, 1);
            this.ShippingCostLabel.Name = "ShippingCostLabel";
            this.ShippingCostLabel.Padding = new System.Windows.Forms.Padding(3);
            this.ShippingCostLabel.Size = new System.Drawing.Size(90, 46);
            this.ShippingCostLabel.TabIndex = 6;
            this.ShippingCostLabel.Text = "Shipping Cost";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(1082, 1);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Padding = new System.Windows.Forms.Padding(3);
            this.TotalCostLabel.Size = new System.Drawing.Size(100, 26);
            this.TotalCostLabel.TabIndex = 7;
            this.TotalCostLabel.Text = "Total Price";
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1114, 605);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 50);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 667);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.QuotesTable);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.QuotesTable.ResumeLayout(false);
            this.QuotesTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel QuotesTable;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label DeskSizeLabel;
        private System.Windows.Forms.Label DeskMaterialLabel;
        private System.Windows.Forms.Label DrawersLabel;
        private System.Windows.Forms.Label DeskCostLabel;
        private System.Windows.Forms.Label ShippingTypeLabel;
        private System.Windows.Forms.Label ShippingCostLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Button CloseButton;
    }
}