using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ResizeImagesApp.Services
{
    public class ImageProcessor
    {
        public List<string> LoadProcessAndSaveImages(string[] filePaths, string outputDirectory, int maxSize)
        {
            List<string> savedImagePaths = new List<string>();

            foreach (string filePath in filePaths)
            {
                try
                {
                    Bitmap originalImage = new Bitmap(filePath);
                    Bitmap processedImage = ApplyResizeEffect(originalImage, maxSize);

                    string fileName = Path.GetFileNameWithoutExtension(filePath);
                    string newFilePath = Path.Combine(outputDirectory, $"{fileName}_res.jpg");

                    processedImage.Save(newFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
                    savedImagePaths.Add(newFilePath);

                    processedImage.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing {filePath}: {ex.Message}");
                }
            }

            return savedImagePaths;
        }

        private Bitmap ApplyResizeEffect(Bitmap image, int maxSize)
        {
            if (image.Width > maxSize || image.Height > maxSize)
            {
                image = ResizeImage(image, maxSize);
            }
            return image;
        }

        private Bitmap ResizeImage(Bitmap image, int targetSize)
        {
            float scale = Math.Min((float)targetSize / image.Width, (float)targetSize / image.Height);
            int newWidth = (int)(image.Width * scale);
            int newHeight = (int)(image.Height * scale);

            Bitmap resizedImage = new Bitmap(newWidth, newHeight);

            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }

            return resizedImage;
        }
    }
}
