using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string uploaded_file_path;
        // this func show openfiledialog (if input string is empty) and upload file that was choosed by user
        private void UploadFileButton_Click(object sender, EventArgs e)
        {
            const int min_path_length = 3; //I don't think that path to file can be shorter than 3 chars
            if (textBoxUpload.Text.Length > min_path_length)
            {
                var input_file_path = textBoxUpload.Text;
                System.Text.StringBuilder file_type_detector = new System.Text.StringBuilder(input_file_path);  //use a string builder for work with file path
                file_type_detector.Remove(0, input_file_path.Length - 3);   //for txt type need only 3 last symbols !!! THIS IS NOT RIGHT CODE FOR TYPE DETECTING
                if (file_type_detector.ToString() != "txt")
                {
                    MessageBox.Show(input_file_path + "not a text file.\n Please, choose correct type of text file (for example.txt)");
                } 
                else
                {
                    try //is file exist and can be open
                    {
                        FileStream FS = File.Open(input_file_path, FileMode.Open);
                        uploaded_file_path = input_file_path;
                        MessageBox.Show(input_file_path + " was uploaded");

                    }
                    catch (IOException)
                    {
                        MessageBox.Show(input_file_path + " doesn't exist!");
                    }
                 
                }
                
            }
            else
            {
                openFileDialog.Filter = "Text files (*.txt)|*.txt"; //user can choose only txt file
                if (openFileDialog.ShowDialog() == DialogResult.Cancel) //if openFileDialog can't be open
                {
                    System.Console.WriteLine("openFileMesage open error");
                }
                else
                {
                    var filename = openFileDialog.FileName;

                    try //is file exist and can be open
                    {
                        FileStream FS = File.Open(filename, FileMode.Open);
                        uploaded_file_path = filename;
                        textBoxUpload.Text = filename;
                        MessageBox.Show(filename + " was uploaded");

                    }
                    catch (IOException)
                    {
                        MessageBox.Show(filename + " doesn't exist!");
                    }
                }
            }
        }
    }
}
