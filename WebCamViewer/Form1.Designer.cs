namespace WebCamViewer
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
            this.SourcesListBox = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.WebCamPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WebCamPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SourcesListBox
            // 
            this.SourcesListBox.FormattingEnabled = true;
            this.SourcesListBox.Location = new System.Drawing.Point(12, 522);
            this.SourcesListBox.Name = "SourcesListBox";
            this.SourcesListBox.Size = new System.Drawing.Size(120, 95);
            this.SourcesListBox.TabIndex = 0;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(12, 623);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "button1";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // WebCamPictureBox
            // 
            this.WebCamPictureBox.Location = new System.Drawing.Point(12, 0);
            this.WebCamPictureBox.Name = "WebCamPictureBox";
            this.WebCamPictureBox.Size = new System.Drawing.Size(1002, 506);
            this.WebCamPictureBox.TabIndex = 2;
            this.WebCamPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 647);
            this.Controls.Add(this.WebCamPictureBox);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.SourcesListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.WebCamPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SourcesListBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.PictureBox WebCamPictureBox;
    }
}

