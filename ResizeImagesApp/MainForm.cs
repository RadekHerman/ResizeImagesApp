using System;
using System.Windows.Forms;
using System.Drawing;
using ResizeImagesApp.Services;

namespace ResizeImagesApp
{
    public partial class MainForm : Form
    {
        private readonly ImageProcessor _imageProcessor;

        public MainForm()
        {
            InitializeComponent();
            _imageProcessor = new ImageProcessor();
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Multiselect = true;
                openFileDialog.Filter = "Image Files (*.png;*.jpg)|*.png;*.jpg|All Files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string[] selectedFiles = openFileDialog.FileNames;

                    using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                    {
                        folderDialog.Description = "Select a folder to save processed images";

                        if (folderDialog.ShowDialog() == DialogResult.OK)
                        {
                            string outputDirectory = folderDialog.SelectedPath;
                            int maxSize = GetSelectedMaxSize();
                            var savedImagePaths = _imageProcessor.LoadProcessAndSaveImages(selectedFiles, outputDirectory, maxSize);

                            MessageBox.Show($"Saved {savedImagePaths.Count} processed images to {outputDirectory}!");
                        }
                    }
                }
            }
        }

        private int GetSelectedMaxSize()
        {
            return radioButton1500.Checked ? 1500 : 1000;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                text: "ResizeImagesApp is a Windows application for resizing images in bulk with high-quality output.\n\n" +
                      "Users can select multiple images, choose a maximum size (1000 or 1500 px), " +
                      "and save resized files to a chosen folder without affecting the originals.\n\n" +
                      "The app uses advanced image processing to maintain quality, making it ideal for preparing images " +
                      "for web or presentations. Simple, efficient, and quality-focused, ResizeImagesApp " +
                      "streamlines resizing for professionals and casual users alike." +
                      "\n\nCreated by RH.",
                caption: "About ResizeImagesApp",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Information
            );
        }
    }
}
