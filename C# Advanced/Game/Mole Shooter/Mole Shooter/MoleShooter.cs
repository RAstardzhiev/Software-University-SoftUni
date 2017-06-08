#define My_Debug

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mole_Shooter
{
    public partial class MoleShooter : Form
    {
#if My_Debug
        int _cursX = 0;
        int _cursY = 0;
#endif
        CMole _mole;
        CBlood _blood;
        CSign _sign;
        CScoreFrame _scoreFrame;

        public MoleShooter()
        {
            InitializeComponent();

            _scoreFrame = new CScoreFrame() { Left = 10, Top = 10 };
            _sign = new CSign() { Left  = 280, Top = 35 };
            _mole = new CMole() { Left = 10, Top = 340 }; // Top Range 340-500
            _blood = new CBlood();
        }

        private void timerGameLoop_Tick(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics dc = e.Graphics;

            _sign.DrowImage(dc);
            _scoreFrame.DrowImage(dc);
#if My_Debug
            TextFormatFlags flags = TextFormatFlags.Left | TextFormatFlags.EndEllipsis;
            Font _font = new System.Drawing.Font("Stencil", 12, FontStyle.Regular);
            TextRenderer.DrawText(dc, "X=" + _cursX.ToString() + ":" + "Y=" + _cursY.ToString(), _font, 
                new Rectangle(0, 0, 120, 20), SystemColors.ControlText, flags);
#endif
            _mole.DrowImage(dc);

            base.OnPaint(e);
        }

        private void MoleShooter_MouseMove(object sender, MouseEventArgs e)
        {
#if My_Debug
            _cursX = e.X;
            _cursY = e.Y;
#endif
            this.Refresh();
        }
    }
}
