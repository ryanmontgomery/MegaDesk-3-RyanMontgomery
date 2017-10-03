namespace MegaDesk_3_RyanMontgomery
{
    partial class AddQuote
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
            this.AddQuoteCancelButton = new System.Windows.Forms.Button();
            this.SubmitQuoteButton = new System.Windows.Forms.Button();
            this.EnterWidthLabel = new System.Windows.Forms.Label();
            this.EnterDepthLabel = new System.Windows.Forms.Label();
            this.EnterDrawersLabel = new System.Windows.Forms.Label();
            this.EnterMaterialLabel = new System.Windows.Forms.Label();
            this.RushShippingLabel = new System.Windows.Forms.Label();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DrawersTextBox = new System.Windows.Forms.TextBox();
            this.toolTipWidth = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDepth = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDrawers = new System.Windows.Forms.ToolTip(this.components);
            this.ComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.StandardShippingRadio = new System.Windows.Forms.RadioButton();
            this.ThreeShippingRadio = new System.Windows.Forms.RadioButton();
            this.FiveShippingRadio = new System.Windows.Forms.RadioButton();
            this.SevenShippingRadio = new System.Windows.Forms.RadioButton();
            this.DeskSpecificationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddQuoteCancelButton
            // 
            this.AddQuoteCancelButton.Location = new System.Drawing.Point(447, 377);
            this.AddQuoteCancelButton.Name = "AddQuoteCancelButton";
            this.AddQuoteCancelButton.Size = new System.Drawing.Size(90, 25);
            this.AddQuoteCancelButton.TabIndex = 0;
            this.AddQuoteCancelButton.Text = "Cancel";
            this.AddQuoteCancelButton.UseVisualStyleBackColor = true;
            this.AddQuoteCancelButton.Click += new System.EventHandler(this.AddQuoteCancelButton_Click);
            // 
            // SubmitQuoteButton
            // 
            this.SubmitQuoteButton.AutoSize = true;
            this.SubmitQuoteButton.Location = new System.Drawing.Point(543, 377);
            this.SubmitQuoteButton.Name = "SubmitQuoteButton";
            this.SubmitQuoteButton.Size = new System.Drawing.Size(90, 25);
            this.SubmitQuoteButton.TabIndex = 10;
            this.SubmitQuoteButton.Text = "Request Quote";
            this.SubmitQuoteButton.UseVisualStyleBackColor = true;
            this.SubmitQuoteButton.Click += new System.EventHandler(this.SubmitQuoteButton_Click);
            // 
            // EnterWidthLabel
            // 
            this.EnterWidthLabel.AutoSize = true;
            this.EnterWidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterWidthLabel.Location = new System.Drawing.Point(26, 176);
            this.EnterWidthLabel.Name = "EnterWidthLabel";
            this.EnterWidthLabel.Size = new System.Drawing.Size(63, 24);
            this.EnterWidthLabel.TabIndex = 2;
            this.EnterWidthLabel.Text = "Width:";
            // 
            // EnterDepthLabel
            // 
            this.EnterDepthLabel.AutoSize = true;
            this.EnterDepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDepthLabel.Location = new System.Drawing.Point(26, 225);
            this.EnterDepthLabel.Name = "EnterDepthLabel";
            this.EnterDepthLabel.Size = new System.Drawing.Size(65, 24);
            this.EnterDepthLabel.TabIndex = 3;
            this.EnterDepthLabel.Text = "Depth:";
            // 
            // EnterDrawersLabel
            // 
            this.EnterDrawersLabel.AutoSize = true;
            this.EnterDrawersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterDrawersLabel.Location = new System.Drawing.Point(26, 274);
            this.EnterDrawersLabel.Name = "EnterDrawersLabel";
            this.EnterDrawersLabel.Size = new System.Drawing.Size(84, 24);
            this.EnterDrawersLabel.TabIndex = 4;
            this.EnterDrawersLabel.Text = "Drawers:";
            // 
            // EnterMaterialLabel
            // 
            this.EnterMaterialLabel.AutoSize = true;
            this.EnterMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterMaterialLabel.Location = new System.Drawing.Point(26, 326);
            this.EnterMaterialLabel.Name = "EnterMaterialLabel";
            this.EnterMaterialLabel.Size = new System.Drawing.Size(80, 24);
            this.EnterMaterialLabel.TabIndex = 5;
            this.EnterMaterialLabel.Text = "Material:";
            // 
            // RushShippingLabel
            // 
            this.RushShippingLabel.AutoSize = true;
            this.RushShippingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RushShippingLabel.Location = new System.Drawing.Point(352, 115);
            this.RushShippingLabel.Name = "RushShippingLabel";
            this.RushShippingLabel.Size = new System.Drawing.Size(205, 29);
            this.RushShippingLabel.TabIndex = 6;
            this.RushShippingLabel.Text = "Shipping Options:";
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthTextBox.Location = new System.Drawing.Point(132, 220);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(121, 29);
            this.DepthTextBox.TabIndex = 3;
            this.toolTipDepth.SetToolTip(this.DepthTextBox, "Enter a depth between 12-48 inches");
            this.DepthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthTextBox_KeyPress);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthTextBox.Location = new System.Drawing.Point(132, 171);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(121, 29);
            this.WidthTextBox.TabIndex = 2;
            this.toolTipWidth.SetToolTip(this.WidthTextBox, "Enter a width between 24-96 inches");
            this.WidthTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.WidthTextBox_Validating);
            // 
            // DrawersTextBox
            // 
            this.DrawersTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrawersTextBox.Location = new System.Drawing.Point(132, 269);
            this.DrawersTextBox.Name = "DrawersTextBox";
            this.DrawersTextBox.Size = new System.Drawing.Size(121, 29);
            this.DrawersTextBox.TabIndex = 4;
            this.toolTipDrawers.SetToolTip(this.DrawersTextBox, "Enter the number of drawers ranging 0-7");
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Location = new System.Drawing.Point(132, 318);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(121, 32);
            this.ComboBoxMaterials.TabIndex = 5;
            this.ComboBoxMaterials.SelectedValueChanged += new System.EventHandler(this.ComboBoxMaterials_SelectedValueChanged);
            // 
            // StandardShippingRadio
            // 
            this.StandardShippingRadio.AutoSize = true;
            this.StandardShippingRadio.Checked = true;
            this.StandardShippingRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StandardShippingRadio.Location = new System.Drawing.Point(357, 167);
            this.StandardShippingRadio.Name = "StandardShippingRadio";
            this.StandardShippingRadio.Size = new System.Drawing.Size(103, 28);
            this.StandardShippingRadio.TabIndex = 6;
            this.StandardShippingRadio.TabStop = true;
            this.StandardShippingRadio.Text = "Standard";
            this.StandardShippingRadio.UseVisualStyleBackColor = true;
            // 
            // ThreeShippingRadio
            // 
            this.ThreeShippingRadio.AutoSize = true;
            this.ThreeShippingRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThreeShippingRadio.Location = new System.Drawing.Point(357, 201);
            this.ThreeShippingRadio.Name = "ThreeShippingRadio";
            this.ThreeShippingRadio.Size = new System.Drawing.Size(84, 28);
            this.ThreeShippingRadio.TabIndex = 7;
            this.ThreeShippingRadio.Text = "3 Days";
            this.ThreeShippingRadio.UseVisualStyleBackColor = true;
            // 
            // FiveShippingRadio
            // 
            this.FiveShippingRadio.AutoSize = true;
            this.FiveShippingRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FiveShippingRadio.Location = new System.Drawing.Point(357, 235);
            this.FiveShippingRadio.Name = "FiveShippingRadio";
            this.FiveShippingRadio.Size = new System.Drawing.Size(84, 28);
            this.FiveShippingRadio.TabIndex = 8;
            this.FiveShippingRadio.Text = "5 Days";
            this.FiveShippingRadio.UseVisualStyleBackColor = true;
            // 
            // SevenShippingRadio
            // 
            this.SevenShippingRadio.AutoSize = true;
            this.SevenShippingRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SevenShippingRadio.Location = new System.Drawing.Point(357, 269);
            this.SevenShippingRadio.Name = "SevenShippingRadio";
            this.SevenShippingRadio.Size = new System.Drawing.Size(84, 28);
            this.SevenShippingRadio.TabIndex = 9;
            this.SevenShippingRadio.Text = "7 Days";
            this.SevenShippingRadio.UseVisualStyleBackColor = true;
            // 
            // DeskSpecificationLabel
            // 
            this.DeskSpecificationLabel.AutoSize = true;
            this.DeskSpecificationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskSpecificationLabel.Location = new System.Drawing.Point(25, 115);
            this.DeskSpecificationLabel.Name = "DeskSpecificationLabel";
            this.DeskSpecificationLabel.Size = new System.Drawing.Size(230, 29);
            this.DeskSpecificationLabel.TabIndex = 16;
            this.DeskSpecificationLabel.Text = "Desk Specifications:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Customer Name:";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(30, 64);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(323, 29);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 414);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeskSpecificationLabel);
            this.Controls.Add(this.SevenShippingRadio);
            this.Controls.Add(this.FiveShippingRadio);
            this.Controls.Add(this.ThreeShippingRadio);
            this.Controls.Add(this.StandardShippingRadio);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Controls.Add(this.DrawersTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.RushShippingLabel);
            this.Controls.Add(this.EnterMaterialLabel);
            this.Controls.Add(this.EnterDrawersLabel);
            this.Controls.Add(this.EnterDepthLabel);
            this.Controls.Add(this.EnterWidthLabel);
            this.Controls.Add(this.SubmitQuoteButton);
            this.Controls.Add(this.AddQuoteCancelButton);
            this.MaximizeBox = false;
            this.Name = "AddQuote";
            this.Text = "New Quote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteCancelButton;
        private System.Windows.Forms.Button SubmitQuoteButton;
        private System.Windows.Forms.Label EnterWidthLabel;
        private System.Windows.Forms.Label EnterDepthLabel;
        private System.Windows.Forms.Label EnterDrawersLabel;
        private System.Windows.Forms.Label EnterMaterialLabel;
        private System.Windows.Forms.Label RushShippingLabel;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.ToolTip toolTipWidth;
        private System.Windows.Forms.TextBox DrawersTextBox;
        private System.Windows.Forms.ToolTip toolTipDepth;
        private System.Windows.Forms.ToolTip toolTipDrawers;
        private System.Windows.Forms.ComboBox ComboBoxMaterials;
        private System.Windows.Forms.RadioButton StandardShippingRadio;
        private System.Windows.Forms.RadioButton ThreeShippingRadio;
        private System.Windows.Forms.RadioButton FiveShippingRadio;
        private System.Windows.Forms.RadioButton SevenShippingRadio;
        private System.Windows.Forms.Label DeskSpecificationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
    }
}