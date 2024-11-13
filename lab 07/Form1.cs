using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace task_8_lab_7
{
    public partial class Form1 : Form
    {
        private List<string> imageFiles;
        private int currentImageIndex = 0;
        public Form1()
        {
            InitializeComponent();
            imageFiles = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderDialog.SelectedPath;
                    LoadImages(folderDialog.SelectedPath);
                }
            }
        }
        private void LoadImages(string folderPath)
        {
            imageFiles.Clear();
            string[] files = Directory.GetFiles(folderPath);
            foreach (string file in files)
            {
                if (file.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                    file.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                {
                    imageFiles.Add(file);
                }
            }

            if (imageFiles.Count > 0)
            {
                currentImageIndex = 0;
                DisplayImage();
            }

            label1.Text = $"Total Photos: {imageFiles.Count}";
        }
        private void DisplayImage()
        {
            if (imageFiles.Count > 0)
            {
                pictureBox1.Image = Image.FromFile(imageFiles[currentImageIndex]);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imageFiles.Count > 0)
            {
                currentImageIndex = (currentImageIndex + 1) % imageFiles.Count;
                DisplayImage();
            }
        }
    }
}