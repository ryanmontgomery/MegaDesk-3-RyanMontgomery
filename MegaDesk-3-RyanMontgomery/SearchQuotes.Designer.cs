namespace MegaDesk_3_RyanMontgomery
{
    partial class SearchQuotes
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
            this.SearchQuotesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SubmitQuoteButton = new System.Windows.Forms.Button();
            this.AddQuoteCancelButton = new System.Windows.Forms.Button();
            this.ComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // SearchQuotesLabel
            // 
            this.SearchQuotesLabel.AutoSize = true;
            this.SearchQuotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.SearchQuotesLabel.Location = new System.Drawing.Point(29, 38);
            this.SearchQuotesLabel.Name = "SearchQuotesLabel";
            this.SearchQuotesLabel.Size = new System.Drawing.Size(131, 40);
            this.SearchQuotesLabel.TabIndex = 1;
            this.SearchQuotesLabel.Text = "Search";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(52, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Materials:";
            // 
            // SubmitQuoteButton
            // 
            this.SubmitQuoteButton.AutoSize = true;
            this.SubmitQuoteButton.Location = new System.Drawing.Point(441, 457);
            this.SubmitQuoteButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitQuoteButton.Name = "SubmitQuoteButton";
            this.SubmitQuoteButton.Size = new System.Drawing.Size(135, 38);
            this.SubmitQuoteButton.TabIndex = 13;
            this.SubmitQuoteButton.Text = "Search Quotes";
            this.SubmitQuoteButton.UseVisualStyleBackColor = true;
            this.SubmitQuoteButton.Click += new System.EventHandler(this.SubmitQuoteButton_Click);
            // 
            // AddQuoteCancelButton
            // 
            this.AddQuoteCancelButton.Location = new System.Drawing.Point(297, 457);
            this.AddQuoteCancelButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddQuoteCancelButton.Name = "AddQuoteCancelButton";
            this.AddQuoteCancelButton.Size = new System.Drawing.Size(135, 38);
            this.AddQuoteCancelButton.TabIndex = 12;
            this.AddQuoteCancelButton.Text = "Cancel";
            this.AddQuoteCancelButton.UseVisualStyleBackColor = true;
            this.AddQuoteCancelButton.Click += new System.EventHandler(this.AddQuoteCancelButton_Click);
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Location = new System.Drawing.Point(221, 148);
            this.ComboBoxMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(180, 40);
            this.ComboBoxMaterials.TabIndex = 14;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 509);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Controls.Add(this.SubmitQuoteButton);
            this.Controls.Add(this.AddQuoteCancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchQuotesLabel);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label SearchQuotesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SubmitQuoteButton;
        private System.Windows.Forms.Button AddQuoteCancelButton;
        private System.Windows.Forms.ComboBox ComboBoxMaterials;
    }
}