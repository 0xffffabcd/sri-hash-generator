namespace SRIHashGenerator
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
            this.generateHashesButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.sha256Radio = new System.Windows.Forms.RadioButton();
            this.sha384Radio = new System.Windows.Forms.RadioButton();
            this.sha512Radio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.hashAlgoGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hashAlgoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateHashesButton
            // 
            this.generateHashesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.generateHashesButton.Location = new System.Drawing.Point(653, 23);
            this.generateHashesButton.Name = "generateHashesButton";
            this.generateHashesButton.Size = new System.Drawing.Size(75, 23);
            this.generateHashesButton.TabIndex = 0;
            this.generateHashesButton.Text = "Generate";
            this.generateHashesButton.UseVisualStyleBackColor = true;
            this.generateHashesButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTextBox.Location = new System.Drawing.Point(12, 25);
            this.inputTextBox.Multiline = true;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputTextBox.Size = new System.Drawing.Size(635, 158);
            this.inputTextBox.TabIndex = 1;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTextBox.Location = new System.Drawing.Point(12, 258);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputTextBox.Size = new System.Drawing.Size(635, 184);
            this.outputTextBox.TabIndex = 3;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitButton.Location = new System.Drawing.Point(653, 52);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sha256Radio
            // 
            this.sha256Radio.AutoSize = true;
            this.sha256Radio.Location = new System.Drawing.Point(6, 19);
            this.sha256Radio.Name = "sha256Radio";
            this.sha256Radio.Size = new System.Drawing.Size(65, 17);
            this.sha256Radio.TabIndex = 8;
            this.sha256Radio.Text = "SHA256";
            this.sha256Radio.UseVisualStyleBackColor = true;
            // 
            // sha384Radio
            // 
            this.sha384Radio.AutoSize = true;
            this.sha384Radio.Checked = true;
            this.sha384Radio.Location = new System.Drawing.Point(77, 19);
            this.sha384Radio.Name = "sha384Radio";
            this.sha384Radio.Size = new System.Drawing.Size(65, 17);
            this.sha384Radio.TabIndex = 9;
            this.sha384Radio.TabStop = true;
            this.sha384Radio.Text = "SHA384";
            this.sha384Radio.UseVisualStyleBackColor = true;
            // 
            // sha512Radio
            // 
            this.sha512Radio.AutoSize = true;
            this.sha512Radio.Location = new System.Drawing.Point(148, 19);
            this.sha512Radio.Name = "sha512Radio";
            this.sha512Radio.Size = new System.Drawing.Size(65, 17);
            this.sha512Radio.TabIndex = 10;
            this.sha512Radio.Text = "SHA512";
            this.sha512Radio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Input URLs";
            // 
            // hashAlgoGroupBox
            // 
            this.hashAlgoGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hashAlgoGroupBox.Controls.Add(this.sha256Radio);
            this.hashAlgoGroupBox.Controls.Add(this.sha384Radio);
            this.hashAlgoGroupBox.Controls.Add(this.sha512Radio);
            this.hashAlgoGroupBox.Location = new System.Drawing.Point(12, 189);
            this.hashAlgoGroupBox.Name = "hashAlgoGroupBox";
            this.hashAlgoGroupBox.Size = new System.Drawing.Size(635, 50);
            this.hashAlgoGroupBox.TabIndex = 12;
            this.hashAlgoGroupBox.TabStop = false;
            this.hashAlgoGroupBox.Text = "Hashing Algorithms";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Output";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 454);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashAlgoGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.generateHashesButton);
            this.MinimumSize = new System.Drawing.Size(400, 400);
            this.Name = "MainForm";
            this.Text = "SRI Hash Generator";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.hashAlgoGroupBox.ResumeLayout(false);
            this.hashAlgoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateHashesButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton sha256Radio;
        private System.Windows.Forms.RadioButton sha384Radio;
        private System.Windows.Forms.RadioButton sha512Radio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox hashAlgoGroupBox;
        private System.Windows.Forms.Label label2;
    }
}

