using System;
using System.Drawing;

namespace RedTracer
{
    public interface ICanvas : IDisposable
    {
        public Graphics Graphics { get; }

        public Bitmap Bitmap { get; }
        
        public void Flush();
    }
}