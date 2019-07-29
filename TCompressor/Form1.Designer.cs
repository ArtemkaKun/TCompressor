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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.compress_file_tab = new System.Windows.Forms.TabPage();
            this.decompress_file_tab = new System.Windows.Forms.TabPage();
            this.compress_file = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.compress_file_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // uploadFileButton
            // 
            this.uploadFileButton.Location = new System.Drawing.Point(343, 18);
            this.uploadFileButton.Name = "uploadFileButton";
            this.uploadFileButton.Size = new System.Drawing.Size(75, 21);
            this.uploadFileButton.TabIndex = 0;
            this.uploadFileButton.Text = "Upload";
            this.uploadFileButton.UseVisualStyleBackColor = true;
            this.uploadFileButton.Click += new System.EventHandler(this.UploadFileButton_Click);
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.Location = new System.Drawing.Point(6, 18);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.Size = new System.Drawing.Size(326, 20);
            this.textBoxUpload.TabIndex = 1;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.compress_file_tab);
            this.tabControl.Controls.Add(this.decompress_file_tab);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(450, 300);
            this.tabControl.TabIndex = 2;
            // 
            // compress_file_tab
            // 
            this.compress_file_tab.Controls.Add(this.compress_file);
            this.compress_file_tab.Controls.Add(this.textBoxUpload);
            this.compress_file_tab.Controls.Add(this.uploadFileButton);
            this.compress_file_tab.Location = new System.Drawing.Point(4, 22);
            this.compress_file_tab.Name = "compress_file_tab";
            this.compress_file_tab.Padding = new System.Windows.Forms.Padding(3);
            this.compress_file_tab.Size = new System.Drawing.Size(442, 274);
            this.compress_file_tab.TabIndex = 0;
            this.compress_file_tab.Text = "Compress File";
            this.compress_file_tab.UseVisualStyleBackColor = true;
            // 
            // decompress_file_tab
            // 
            this.decompress_file_tab.Location = new System.Drawing.Point(4, 22);
            this.decompress_file_tab.Name = "decompress_file_tab";
            this.decompress_file_tab.Padding = new System.Windows.Forms.Padding(3);
            this.decompress_file_tab.Size = new System.Drawing.Size(442, 274);
            this.decompress_file_tab.TabIndex = 1;
            this.decompress_file_tab.Text = "Decompress File";
            this.decompress_file_tab.UseVisualStyleBackColor = true;
            // 
            // compress_file
            // 
            this.compress_file.Location = new System.Drawing.Point(165, 103);
            this.compress_file.Name = "compress_file";
            this.compress_file.Size = new System.Drawing.Size(75, 23);
            this.compress_file.TabIndex = 2;
            this.compress_file.Text = "Compress";
            this.compress_file.UseVisualStyleBackColor = true;
            this.compress_file.Click += new System.EventHandler(this.Compress_file_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "TCompressor";
            this.tabControl.ResumeLayout(false);
            this.compress_file_tab.ResumeLayout(false);
            this.compress_file_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uploadFileButton;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage compress_file_tab;
        private System.Windows.Forms.TabPage decompress_file_tab;
        private System.Windows.Forms.Button compress_file;
    }
}

