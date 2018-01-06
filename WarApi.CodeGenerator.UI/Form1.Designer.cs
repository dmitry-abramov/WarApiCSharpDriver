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
            this.GeneratedRequestCodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.GeneratedResponseCodeRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlLabel.Location = new System.Drawing.Point(0, 0);
            this.UrlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(36, 25);
            this.UrlLabel.TabIndex = 0;
            this.UrlLabel.Text = "Url";
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UrlTextBox.Location = new System.Drawing.Point(47, 0);
            this.UrlTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(528, 30);
            this.UrlTextBox.TabIndex = 1;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(584, 4);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(100, 28);
            this.ParseButton.TabIndex = 3;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButtonClick);
            // 
            // ParsedMethodRichTextBox
            // 
            this.ParsedMethodRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ParsedMethodRichTextBox.Location = new System.Drawing.Point(5, 39);
            this.ParsedMethodRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ParsedMethodRichTextBox.Name = "ParsedMethodRichTextBox";
            this.ParsedMethodRichTextBox.ReadOnly = true;
            this.ParsedMethodRichTextBox.Size = new System.Drawing.Size(677, 637);
            this.ParsedMethodRichTextBox.TabIndex = 4;
            this.ParsedMethodRichTextBox.Text = "Parsed method...";
            // 
            // GeneratedRequestCodeRichTextBox
            // 
            this.GeneratedRequestCodeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratedRequestCodeRichTextBox.Location = new System.Drawing.Point(692, 39);
            this.GeneratedRequestCodeRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GeneratedRequestCodeRichTextBox.Name = "GeneratedRequestCodeRichTextBox";
            this.GeneratedRequestCodeRichTextBox.ReadOnly = true;
            this.GeneratedRequestCodeRichTextBox.Size = new System.Drawing.Size(635, 214);
            this.GeneratedRequestCodeRichTextBox.TabIndex = 5;
            this.GeneratedRequestCodeRichTextBox.Text = "Generated request code...";
            // 
            // GeneratedResponseCodeRichTextBox
            // 
            this.GeneratedResponseCodeRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.GeneratedResponseCodeRichTextBox.Location = new System.Drawing.Point(692, 261);
            this.GeneratedResponseCodeRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.GeneratedResponseCodeRichTextBox.Name = "GeneratedResponseCodeRichTextBox";
            this.GeneratedResponseCodeRichTextBox.ReadOnly = true;
            this.GeneratedResponseCodeRichTextBox.Size = new System.Drawing.Size(635, 415);
            this.GeneratedResponseCodeRichTextBox.TabIndex = 6;
            this.GeneratedResponseCodeRichTextBox.Text = "Generated response code...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 692);
            this.Controls.Add(this.GeneratedResponseCodeRichTextBox);
            this.Controls.Add(this.GeneratedRequestCodeRichTextBox);
            this.Controls.Add(this.ParsedMethodRichTextBox);
            this.Controls.Add(this.ParseButton);
            this.Controls.Add(this.UrlTextBox);
            this.Controls.Add(this.UrlLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
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
        private System.Windows.Forms.RichTextBox GeneratedRequestCodeRichTextBox;
        private System.Windows.Forms.RichTextBox GeneratedResponseCodeRichTextBox;
    }
}

