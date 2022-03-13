using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace RedTracer
{
    public class FileCanvas : ICanvas
    {
        public readonly int Width;
        public readonly int Height;

        public Graphics Graphics => _graphics;
        public Bitmap Bitmap => _image;

        private Bitmap _image;
        private Graphics _graphics;

        private string _path;
        
        public FileCanvas(int width, int height, string path)
        {
            Width = width;
            Height = height;
            _path = path;

            _image = new Bitmap(Width, Height);
            _graphics = Graphics.FromImage(_image);
        }

        public void Dispose()
        {
            _graphics.Dispose();
            _image.Dispose();
        }
        
        public void Flush()
        {
            _image.Save(_path, ImageFormat.Png);
        }
    }
}