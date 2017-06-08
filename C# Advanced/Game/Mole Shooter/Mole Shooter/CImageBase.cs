using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mole_Shooter
{
    class CImageBase : IDisposable
    {
        bool isDisposed = false;

        Bitmap _bitmap;
        private int X;
        private int Y;

        public int Left { get { return X; } set { X = value; } }
        public int Top { get { return Y; } set { Y = value; } }

        public CImageBase(Bitmap _resource) // Constructor
        {
            _bitmap = new Bitmap(_resource);
        }

        public void DrowImage(Graphics gfs) // Puts the image on the window
        {
            gfs.DrawImage(_bitmap, X, Y);
        }

        public void Dispose() // Public method calling the protected one
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing) // Freeing memory
        {
            if (isDisposed)
            {
                return;
            }

            if (disposing)
            {
                _bitmap.Dispose();
            }

            isDisposed = true;
        }
    }
}
