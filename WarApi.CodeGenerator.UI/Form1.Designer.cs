namespace WarApi.CodeGenerator.UI
{
    partial class MainForm
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
            this.UrlLabel = new System.Windows.Forms.Label();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.ParseButton = new System.Windows.Forms.Button();
            this.ParsedMethodRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GeneratedCodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlLabel.Location = new System.Drawing.Point(0, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(29, 20);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "Url";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlTextBox.Location = new System.Drawing.Point(35, 0);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(397, 26);
            this.UrlTextBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(438, 3);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButtonClick);
            // 
            // ParsedMethodRichTextBox
            // 
            this.ParsedMethodRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ParsedMethodRichTextBox.Location = new System.Drawing.Point(4, 32);
            this.ParsedMethodRichTextBox.Name = "ParsedMethodRichTextBox";
            this.ParsedMethodRichTextBox.ReadOnly = true;
            this.ParsedMethodRichTextBox.Size = new System.Drawing.Size(509, 518);
            this.ParsedMethodRichTextBox.TabIndex = 4;
            this.ParsedMethodRichTextBox.Text = "Parsed method...";
            // 
            // GeneratedCodeRichTextBox
            // 
            this.GeneratedCodeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratedCodeRichTextBox.Location = new System.Drawing.Point(519, 32);
            this.GeneratedCodeRichTextBox.Name = "GeneratedCodeRichTextBox";
            this.GeneratedCodeRichTextBox.ReadOnly = true;
            this.GeneratedCodeRichTextBox.Size = new System.Drawing.Size(477, 518);
            this.GeneratedCodeRichTextBox.TabIndex = 5;
            this.GeneratedCodeRichTextBox.Text = "Generated code...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.GeneratedCodeRichTextBox);
            this.Controls.Add(this.ParsedMethodRichTextBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.UrlLabel);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "WarApi Code Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UrlLabel;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.RichTextBox ParsedMethodRichTextBox;
        private System.Windows.Forms.RichTextBox GeneratedCodeRichTextBox;
    }
}

