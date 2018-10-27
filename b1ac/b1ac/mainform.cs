﻿using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace b1ac
{
    public partial class mainform : Form
    {
        [DllImport("user32", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);
        private const int MOUSEEVENTF_MOVE = 0x0001;
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002;
        private const int MOUSEEVENTF_LEFTUP = 0x0004;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const int MOUSEEVENTF_RIGHTUP = 0x0016;
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern int GetWindowThreadProcessId(IntPtr handle, out int processId);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder text, int count);
        public static bool ApplicationIsActivated()
        {
            IntPtr foregroundWindow = GetForegroundWindow();
            bool result;
            if (foregroundWindow == IntPtr.Zero)
            {
                result = false;
            }
            else
            {
                int id = Process.GetCurrentProcess().Id;
                int num;
                GetWindowThreadProcessId(foregroundWindow, out num);
                result = (num == id);
            }
            return result;
        }
        private string GetCaptionOfActiveWindow()
        {
            var strTitle = string.Empty;
            var handle = GetForegroundWindow();
            var intLength = GetWindowTextLength(handle) + 1;
            var stringBuilder = new StringBuilder(intLength);
            if (GetWindowText(handle, stringBuilder, intLength) > 0)
            {
                strTitle = stringBuilder.ToString();
            }
            return strTitle;
        }
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
        bool estado = false;
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (GetCaptionOfActiveWindow().Contains("Minecraft") || GetCaptionOfActiveWindow().Contains("Badlion") || GetCaptionOfActiveWindow().Contains("Labymod") || GetCaptionOfActiveWindow().Contains("OCMC") || GetCaptionOfActiveWindow().Contains("Cheatbreaker"))
                {
                    if (estado == true)
                    {
                        estado = false;
                        Show();
                    }
                    else
                    {
                        estado = true;
                        Hide();
                    }
                }
            }
            base.WndProc(ref m);
        }
        public mainform()
        {
            InitializeComponent();
            bool success = RegisterHotKey(Handle, GetType().GetHashCode(), 0x0000, 0x42);
            try
            {
                if (success == true)
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, RandomString(5), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
        }
        private void btnAC_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Estado: OFF")
            {
                label1.Text = "Estado: ON";
                rodar.Start();
            }
            else if (label1.Text == "Estado: ON")
            {
                label1.Text = "Estado: OFF";
                rodar.Stop();
            }
        }
        private void btnExtender_Click(object sender, EventArgs e)
        {
            if (panel2.Visible == false)
            {
                panel2.Visible = true;
            }
            else if (panel2.Visible == true)
            {
                label1.Text = "Estado: OFF";
                panel2.Visible = false;
            }
        }

        private void rangelol_RangeChanged(object sender, EventArgs e)
        {
            lblMin.Text = rangelol.RangeMin.ToString();
            lblMax.Text = rangelol.RangeMax.ToString();
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            Bunifu.Framework.Lib.Elipse.Apply(panel2, 5);
            lblMin.Text = rangelol.RangeMin.ToString();
            lblMax.Text = rangelol.RangeMax.ToString();
        }
        Random rnd = new Random();
        int cps = 1000 / 1;
        private void rodar_Tick(object sender, EventArgs e)
        {

            int minval;
            int maxval;
            if (rangelol.RangeMin > 0)
            {
                minval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.2;
                maxval = 1000 / rangelol.RangeMin + rangelol.RangeMax * (int)0.48;
                rodar.Interval = rnd.Next(minval, maxval);
            }
            if (bunifuCheckbox1.Checked == true)
            {
                if (GetCaptionOfActiveWindow().Contains("Minecraft") || GetCaptionOfActiveWindow().Contains("Badlion") || GetCaptionOfActiveWindow().Contains("Labymod") || GetCaptionOfActiveWindow().Contains("OCMC") || GetCaptionOfActiveWindow().Contains("Cheatbreaker"))
                {
                    if (!ApplicationIsActivated())
                    {
                        if (MouseButtons == MouseButtons.Left)
                        {
                            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        }
                    }
                }
            }
            else
            {
                if (!ApplicationIsActivated())
                {
                    if (MouseButtons == MouseButtons.Left)
                    {
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                    }
                }
            }
        }
        private void deletarlol()
        {
            try
            {
                foreach (Process process in Process.GetProcesses())
                {
                    if (process.ProcessName == "explorer")
                    {
                        process.Kill();
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, RandomString(5), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            string location = Path.Combine(Directory.GetCurrentDirectory() + @"\" + AppDomain.CurrentDomain.FriendlyName);
            string dll = Path.Combine(Directory.GetCurrentDirectory() + @"\" + "Bunifu_UI_v1.5.4.dll");
            Console.WriteLine(location);
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = "/C ping 1.1.1.1 -n 1 & Del " + location + " & Del " + dll,
                CreateNoWindow = true,
                WindowStyle = ProcessWindowStyle.Hidden
            });
            Environment.Exit(0);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (chkDeletar.Checked == true)
            {
                deletarlol();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
