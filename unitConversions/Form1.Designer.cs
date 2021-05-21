
namespace unitConversions
{
    partial class Form1
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.inchToCmLabel = new System.Windows.Forms.Label();
            this.yrdToMLabel = new System.Windows.Forms.Label();
            this.milesToKmLabel = new System.Windows.Forms.Label();
            this.ftToCmLabel = new System.Windows.Forms.Label();
            this.conversionChoiceLabel = new System.Windows.Forms.Label();
            this.valueConverted = new System.Windows.Forms.Label();
            this.conversionChoiceInput = new System.Windows.Forms.TextBox();
            this.valueInput = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.Font = new System.Drawing.Font("Mongolian Baiti", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.headerLabel.Location = new System.Drawing.Point(110, 45);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(255, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Linear Conversion";
            // 
            // inchToCmLabel
            // 
            this.inchToCmLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inchToCmLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.inchToCmLabel.Location = new System.Drawing.Point(114, 104);
            this.inchToCmLabel.Name = "inchToCmLabel";
            this.inchToCmLabel.Size = new System.Drawing.Size(255, 37);
            this.inchToCmLabel.TabIndex = 1;
            this.inchToCmLabel.Text = "1. Inches to Centimetres";
            // 
            // yrdToMLabel
            // 
            this.yrdToMLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yrdToMLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.yrdToMLabel.Location = new System.Drawing.Point(112, 179);
            this.yrdToMLabel.Name = "yrdToMLabel";
            this.yrdToMLabel.Size = new System.Drawing.Size(255, 37);
            this.yrdToMLabel.TabIndex = 2;
            this.yrdToMLabel.Text = "3. Yards to Meters";
            // 
            // milesToKmLabel
            // 
            this.milesToKmLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.milesToKmLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.milesToKmLabel.Location = new System.Drawing.Point(112, 216);
            this.milesToKmLabel.Name = "milesToKmLabel";
            this.milesToKmLabel.Size = new System.Drawing.Size(255, 37);
            this.milesToKmLabel.TabIndex = 3;
            this.milesToKmLabel.Text = "4. Miles to Kilometres";
            // 
            // ftToCmLabel
            // 
            this.ftToCmLabel.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ftToCmLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.ftToCmLabel.Location = new System.Drawing.Point(112, 142);
            this.ftToCmLabel.Name = "ftToCmLabel";
            this.ftToCmLabel.Size = new System.Drawing.Size(255, 37);
            this.ftToCmLabel.TabIndex = 4;
            this.ftToCmLabel.Text = "2. Feet to Centimetres";
            // 
            // conversionChoiceLabel
            // 
            this.conversionChoiceLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionChoiceLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.conversionChoiceLabel.Location = new System.Drawing.Point(67, 252);
            this.conversionChoiceLabel.Name = "conversionChoiceLabel";
            this.conversionChoiceLabel.Size = new System.Drawing.Size(302, 37);
            this.conversionChoiceLabel.TabIndex = 5;
            this.conversionChoiceLabel.Text = "Enter conversion choice (1-4):";
            // 
            // valueConverted
            // 
            this.valueConverted.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueConverted.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.valueConverted.Location = new System.Drawing.Point(67, 289);
            this.valueConverted.Name = "valueConverted";
            this.valueConverted.Size = new System.Drawing.Size(302, 37);
            this.valueConverted.TabIndex = 6;
            this.valueConverted.Text = "Enter value to be converted:";
            // 
            // conversionChoiceInput
            // 
            this.conversionChoiceInput.Location = new System.Drawing.Point(326, 252);
            this.conversionChoiceInput.Name = "conversionChoiceInput";
            this.conversionChoiceInput.Size = new System.Drawing.Size(68, 20);
            this.conversionChoiceInput.TabIndex = 7;
            // 
            // valueInput
            // 
            this.valueInput.Location = new System.Drawing.Point(326, 289);
            this.valueInput.Name = "valueInput";
            this.valueInput.Size = new System.Drawing.Size(68, 20);
            this.valueInput.TabIndex = 8;
            // 
            // convertButton
            // 
            this.convertButton.Font = new System.Drawing.Font("Mongolian Baiti", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertButton.Location = new System.Drawing.Point(71, 329);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(323, 27);
            this.convertButton.TabIndex = 9;
            this.convertButton.Text = "Convert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.outputLabel.Location = new System.Drawing.Point(67, 379);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(327, 74);
            this.outputLabel.TabIndex = 10;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(487, 475);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.valueInput);
            this.Controls.Add(this.conversionChoiceInput);
            this.Controls.Add(this.valueConverted);
            this.Controls.Add(this.conversionChoiceLabel);
            this.Controls.Add(this.ftToCmLabel);
            this.Controls.Add(this.milesToKmLabel);
            this.Controls.Add(this.yrdToMLabel);
            this.Controls.Add(this.inchToCmLabel);
            this.Controls.Add(this.headerLabel);
            this.Name = "Form1";
            this.Text = "Linear Convertor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label inchToCmLabel;
        private System.Windows.Forms.Label yrdToMLabel;
        private System.Windows.Forms.Label milesToKmLabel;
        private System.Windows.Forms.Label ftToCmLabel;
        private System.Windows.Forms.Label conversionChoiceLabel;
        private System.Windows.Forms.Label valueConverted;
        private System.Windows.Forms.TextBox conversionChoiceInput;
        private System.Windows.Forms.TextBox valueInput;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

