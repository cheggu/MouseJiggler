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

        private List<String> SharedThreadData = new List<string>();

        public Main()
        {
            InitializeComponent();

        }
        //https://coolors.co/edffec-61e786-5a5766-48435c-9792e3

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

            cboJiggleEveryOptions.SelectedIndex = 1;
            cboJiggleEveryOptions.DropDownStyle = ComboBoxStyle.DropDownList;
            cboJiggleEveryOptions.Enabled = false;

            dtpJiggleUntil.Enabled = false;
            dtpJiggleUntil.Value = DateTime.Today.AddDays(1);

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

        public static void ThreadProc(Object Type, Object CenterX, Object CenterY, Object Control, Object SharedData)
        {
            JiggleType type;
            int center_X, center_Y;
            Object control;
            List<String> sharedData;
            try
            {
                type = (JiggleType)Type;
                center_X = (int)CenterX;
                center_Y = (int)CenterY;
                control = Control;
                sharedData = (List<String>)SharedData;
                sharedData.Clear();
                sharedData.Add(Thread.CurrentThread.IsAlive.ToString());
                if (type == JiggleType.CONSTANT)
                {
                    control = (int)Control;
                    while (GetAsyncKeyState(0x1B) != 1)
                    {
                        mouse_event_circle(center_X, center_Y, (int)control);
                    }
                    sharedData.Clear();
                    Thread.CurrentThread.Abort();
                } 
                else if (type == JiggleType.EVERYX)
                {
                    List<String> arr = (List<string>)control;

                    int duration = Convert.ToInt32(arr[0]);
                    string timeset = arr[1];
                    int radius = Convert.ToInt32(arr[2]);

                    if (timeset == "seconds")
                    {
                        duration *= 1000;
                    }
                    else if (timeset == "minutes")
                    {
                        duration = duration * 60 * 1000;
                    }
                    else if (timeset == "hours")
                    {
                        duration = duration * 60 * 60 * 1000;
                    }
                    else if (timeset == "days")
                    {
                        duration = duration * 24 * 60 * 60 * 1000;
                    }

                    while (GetAsyncKeyState(0x1B) != 1)
                    {
                        mouse_event_circle(center_X, center_Y, radius);
                        Thread.Sleep(duration);
                    }
                    sharedData.Clear();
                    Thread.CurrentThread.Abort();
                }
                else if (type == JiggleType.RANDOM)
                {
                    Random random = new Random();
                    int duration;
                    int radius = (int)control;
                    while (GetAsyncKeyState(0x1B) != 1)
                    {
                        duration = random.Next(60) * 1000;
                        mouse_event_circle(center_X, center_Y, radius);
                        Thread.Sleep(duration);
                    }
                    sharedData.Clear();
                    Thread.CurrentThread.Abort();
                }
                else if (type == JiggleType.UNTIL)
                {
                    List<String> arr = (List<string>)control;

                    int day, month, year;
                    int radius = Convert.ToInt32(arr[3]);
                    day = Convert.ToInt32(arr[0]);
                    month = Convert.ToInt32(arr[1]);
                    year = Convert.ToInt32(arr[2]);
                    DateTime target = new DateTime(year, month, day);

                    while (GetAsyncKeyState(0x1B) != 1)
                    {
                        if (DateTime.Today != target)
                        {
                            mouse_event_circle(center_X, center_Y, radius);
                        }
                    }
                    sharedData.Clear();
                    Thread.CurrentThread.Abort();
                }
            
            }
            catch (Exception e)
            {
                type = JiggleType.CONSTANT;
                center_X = 1920/2;
                center_Y = 1080/2;
                control = 20;
                MessageBox.Show(e.ToString());
                Thread.CurrentThread.Abort();
            }
            Thread.CurrentThread.Abort();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            btnCancel.Enabled = true;
            Object control = 0;
            if (chkJiggle.Checked)
            {
                JiggleType curType = JiggleType.CONSTANT;

                if (chkJiggleConstant.Checked)
                {
                    curType = JiggleType.CONSTANT;
                    control = circleRadius;
                }
                else if (chkJiggleEveryX.Checked)
                {
                    curType = JiggleType.EVERYX;
                    control = new List<String> { mskEveryXMinutes.Text, cboJiggleEveryOptions.SelectedItem.ToString(), circleRadius.ToString() }; 
                }
                else if (chkJiggleRandom.Checked)
                {
                    curType = JiggleType.RANDOM;
                    control = circleRadius;
                }
                else if (chkJiggleUntil.Checked)
                {
                    curType = JiggleType.UNTIL;
                    DateTime date = dtpJiggleUntil.Value;
                    control = new List<String> { date.Day.ToString(), date.Month.ToString(), date.Year.ToString(), circleRadius.ToString() };
                }
                else
                {
                    curType = JiggleType.CONSTANT;
                    control = circleRadius;
                }

                var jiggleThread = new Thread(() => ThreadProc(curType, centerX, centerY, control, SharedThreadData));
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
            if (SharedThreadData.Count > 0)
            {
                if (SharedThreadData.ElementAt(0) == "True")
                {
                    btnStart.Enabled = false;
                    btnCancel.Enabled = true;
                }
            }
            else
            {
                btnStart.Enabled = true;
                btnCancel.Enabled = false;
                SharedThreadData.Clear();
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

                mskEveryXMinutes.Enabled = true;
                cboJiggleEveryOptions.Enabled = true;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleRandom.Enabled = true;
                chkJiggleUntil.Enabled = true;

                mskEveryXMinutes.Enabled = false;
                cboJiggleEveryOptions.Enabled = false;
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

                dtpJiggleUntil.Enabled = true;

            }
            else
            {
                chkJiggleConstant.Enabled = true;
                chkJiggleEveryX.Enabled = true;
                chkJiggleRandom.Enabled = true;

                dtpJiggleUntil.Enabled = false;
            }
        }

        private void dtpJiggleUntil_ValueChanged(object sender, EventArgs e)
        {
            if (dtpJiggleUntil.Value <= DateTime.Today)
            {
                dtpJiggleUntil.Value = DateTime.Today.AddDays(1);
            }
        }

        private void mskEveryXMinutes_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

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
