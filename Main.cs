using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;


namespace MouseJiggler
{
    public partial class Main : Form
    {
        static uint DOWN = 0x0002;
        static uint UP = 0x0004;
        static uint MOUSEEVENTF_ABSOLUTE = 0x8000;
        static uint MOUSEEVENTF_MOVE = 0x0001;
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);

        static int SM_CXSCREEN = 0;
        static int SM_CYSCREEN = 1;
        [DllImport("user32.dll")]
        static extern int GetSystemMetrics(int nIndex);
        public Main()
        {
            InitializeComponent();

           
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;

            //jiggle
            chkJiggleConstant.Enabled = false;
            chkJiggleEveryX.Enabled = false;
            chkJiggleRandom.Enabled = false;
            chkJiggleUntil.Enabled = false;


            //click
            chkClickEvery.Enabled = false;
            chkClickRandom.Enabled = false;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnCancel.Enabled = true;

            int x = (1920/2) * 65536 / 1920;
            int y = (1080/2) * 65536 / 1080;

            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);

            while (btnCancel.Enabled != false)
            {
                if (chkJiggleConstant.Checked)
                {

                }
                else if (chkJiggleEveryX.Checked)
                {

                }
                else if (chkJiggleRandom.Checked)
                {
                    
                }
                else if (chkJiggleUntil.Checked)
                {

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnCancel.Enabled = false;
        }

        private void chkJiggle_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggle.CheckState == CheckState.Checked)
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
            else
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;
                
            }
        }

        private void chkClick_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClick.CheckState == CheckState.Checked)
            {
                chkClickEvery.Enabled = true;
                chkClickRandom.Enabled = true;
            }
            else
            {
                chkClickEvery.Checked = false;
                chkClickRandom.Checked = false;

                chkClickEvery.Enabled = false;
                chkClickRandom.Enabled = false;
                
            }
        }

        private void chkJiggleConstant_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleConstant.Checked)
            {
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;
                
            }
            else
            {
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
        }

        private void chkJiggleEveryX_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleEveryX.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleRandom.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleRandom.Enabled = false;
                chkJiggleUntil.Enabled = false;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
        }

        private void chkJiggleRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleRandom.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleUntil.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleUntil.Enabled = false;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleUntil.Enabled = true;
            }
        }

        private void chkJiggleUntil_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJiggleUntil.Checked)
            {
                chkJiggleConstant.Checked = false;
                chkJiggleEveryX.Checked = false;
                chkJiggleRandom.Checked = false;

                chkJiggleConstant.Enabled = false;
                chkJiggleEveryX.Enabled = false;
                chkJiggleRandom.Enabled = false;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;
            }
        }

        private void chkClickEvery_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClickEvery.Checked)
            {
                chkClickRandom.Checked = false;

                chkClickRandom.Enabled = false;
            }
            else
            {
                chkClickRandom.Enabled = true;
            }
        }

        private void chkClickRandom_CheckedChanged(object sender, EventArgs e)
        {
            if (chkClickRandom.Checked)
            {
                chkClickEvery.Checked = false;

                chkClickEvery.Enabled = false;
            }
            else
            {
                chkClickEvery.Enabled = true;
            }
        }
    }
}
