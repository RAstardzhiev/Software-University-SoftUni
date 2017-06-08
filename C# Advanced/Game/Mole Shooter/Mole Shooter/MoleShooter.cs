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
            _mole.DrowImage(dc);

            base.OnPaint(e);
        }

        private void MoleShooter_MouseMove(object sender, MouseEventArgs e)
        {
            mouseXpos.Text = $"X:{e.X} \\ Y: {e.Y}";
        }
    }
}
