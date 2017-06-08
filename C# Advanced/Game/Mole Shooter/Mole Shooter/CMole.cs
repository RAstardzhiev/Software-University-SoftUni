using Mole_Shooter.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mole_Shooter
{
    class CMole : CImageBase
    {
        private Rectangle _moleHotSpot = new Rectangle();

        public CMole() : base(Resources.Mole)
        {
            _moleHotSpot.X = Left + 20;
            _moleHotSpot.Y = Top - 1;
            _moleHotSpot.Width = 30;
            _moleHotSpot.Height = 40;
        }

        public void Update(int x, int y)
        {
            Left = x;
            Top = y;
            _moleHotSpot.X = Left + 20;
            _moleHotSpot.Y = Top - 1;
        }

        public bool IsHit(int x, int y)
        {
            Rectangle cursor = new Rectangle(x, y, 1, 1); // Cursor Rectangle (quick way to check for hit)

            if (_moleHotSpot.Contains(cursor))
            {
                return true;
            }

            return false;
        }
    }
}
