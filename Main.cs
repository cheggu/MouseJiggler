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
using System.Threading;
using System.Diagnostics;


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

        [DllImport("user32.dll")]
        public static extern short GetAsyncKeyState(int vKey);

        int centerX = 1920 / 2, centerY = 1080 / 2, circleRadius = 50;
        static int origThreadCount = Process.GetCurrentProcess().Threads.Count;

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

        public static void mouse_event_circle(int center_x, int center_y, int radius)
        {
            int x, y;

            mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, center_x * 65536 / 1920, center_y * 65536 / 1080, 0, 0);

            for (int i = 0; i < 720; i++)
            {
                x = Convert.ToInt32((radius * (Math.Sin(i * (Math.PI / 360.0)))) + center_x);
                y = Convert.ToInt32((radius * (Math.Cos(i * (Math.PI / 360.0)))) + center_y);

                x = x * 65536 / 1920;
                y = y * 65536 / 1080;

                mouse_event(MOUSEEVENTF_ABSOLUTE | MOUSEEVENTF_MOVE, x, y, 0, 0);
                if (i % 20 == 0)
                {
                    Thread.Sleep(1);
                }
            }
        }

        public enum JiggleType
        {
            CONSTANT, 
            EVERYX,
            RANDOM,
            UNTIL
        }

        public static void ThreadProc(Object Type, Object CenterX, Object CenterY, Object Control)
        {
            JiggleType type;
            int center_X, center_Y, control;
            try
            {
                type = (JiggleType)Type;
                center_X = (int)CenterX;
                center_Y = (int)CenterY;
                control = (int)Control;
        

            }
            catch (InvalidCastException)
            {
                type = JiggleType.CONSTANT;
                center_X = 1920/2;
                center_Y = 1080/2;
                control = 20;
            }

            if (type == JiggleType.CONSTANT)
            {
                while (GetAsyncKeyState(0x1B) != 1) {
                    mouse_event_circle(center_X, center_Y, control);
                }
                Thread.CurrentThread.Abort();
            }
            if (type == JiggleType.EVERYX)
            {

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnCancel.Enabled = true;

            if (chkJiggle.Checked)
            {
                JiggleType curType = JiggleType.CONSTANT;

                if (chkJiggleConstant.Checked)
                {
                    curType = JiggleType.CONSTANT;
                }
                else if (chkJiggleEveryX.Checked)
                {
                    curType = JiggleType.EVERYX;
                }
                else if (chkJiggleRandom.Checked)
                {
                    curType = JiggleType.RANDOM;
                }
                else if (chkJiggleUntil.Checked)
                {
                    curType = JiggleType.UNTIL;
                }
                else
                {
                    curType = JiggleType.CONSTANT;
                }

                
                var jiggleThread = new Thread(() => ThreadProc(curType, centerX, centerY, circleRadius));
                jiggleThread.Start();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnCancel.Enabled = false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int number = Process.GetCurrentProcess().Threads.Count;

            if (btnStart.Enabled)
            {
                origThreadCount = number;
            }
            else
            {
                if (number == origThreadCount + 1)
                {
                    btnStart.Enabled = false;
                    btnCancel.Enabled = true;
                }
                else 
                {
                    btnStart.Enabled = true;
                    btnCancel.Enabled = false;
                }
            } 

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
