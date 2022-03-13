using System;
using System.Drawing;

namespace RedTracer
{
    public class Tracer : IDisposable
    {
        private ICanvas _canvas;
        
        public void Init(ICanvas canvas)
        {
            Console.WriteLine("Start");

            _canvas = canvas;
        }

        public void Draw()
        {
            _canvas.Graphics.Clear(Color.Black);
            for (int i = 0; i < _canvas.Bitmap.Width; i++)
            {
                for (int j = 0; j < _canvas.Bitmap.Height; j++)
                {
                    int circleSqr = i * i + j * j;
                    if (circleSqr <= 2500)
                    {
                        _canvas.Bitmap.SetPixel(i,j,Color.Aqua);
                    }
                }
            }
            _canvas.Flush();
        }

        public void Dispose()
        {
            _canvas.Dispose();
        }
    }
}