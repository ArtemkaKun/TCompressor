namespace TCompressor
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
            this.uploadFileButton = new System.Windows.Forms.Button();
            this.textBoxUpload = new System.Windows.Forms.TextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(453, 39);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(75, 21);
            this.uploadFileButton.TabIndex = 0;
            this.uploadFileButton.Text = "Upload";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.Location = new System.Drawing.Point(32, 39);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.Size = new System.Drawing.Size(398, 20);
            this.textBoxUpload.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUpload);
            this.Controls.Add(this.uploadFileButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

