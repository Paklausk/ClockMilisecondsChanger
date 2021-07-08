using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeChanger.Objects;

namespace TimeChanger
{
    public partial class MainWindow : Form
    {
        TimeDifference _timeDiff = new TimeDifference(0);
        public MainWindow()
        {
            InitializeComponent();
            _timeDiff.OnChanged += OnTimeDiffOnChanged;
        }
        private void MainWindow_Load(object sender, EventArgs e)
        {

        }
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetTime();
        }

        private void OnTimeDiffOnChanged(long newValue)
        {
            timeDifLabel.Text = $"{newValue} ms";
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetTime();
        }
        private void BigForwardButton_Click(object sender, EventArgs e)
        {
            Up(100);
        }
        private void smallForwardButton_Click(object sender, EventArgs e)
        {
            Up(10);
        }
        private void smallBackButton_Click(object sender, EventArgs e)
        {
            Down(10);
        }
        private void bigBackButton_Click(object sender, EventArgs e)
        {
            Down(100);
        }

        private void ResetTime()
        {
            if (_timeDiff.ValueMs > 0)
                Down(_timeDiff.ValueMs);
            else if (_timeDiff.ValueMs < 0)
                Up(-_timeDiff.ValueMs);
            SyncTime();
        }
        private void SyncTime()
        {
            Process process = new Process();

            // Stop the process from opening a new window
            process.StartInfo.RedirectStandardOutput = true;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;

            // Setup executable and parameters
            process.StartInfo.FileName = "w32tm";
            process.StartInfo.Arguments = "/resync";
            process.Start();
            process.WaitForExit(3000);
        }
        private void Up(long ms)
        {
            SystemTime time = SystemTimeHelper.GetTime();
            SystemTime newTime = SystemTimeOperationsHelper.Add(time, ms);
            try
            {
                SystemTimeHelper.SetTime(newTime);
                _timeDiff.Add(ms);
            }
            catch (Exception e) { FormHelper.ErrorMessage(e.Message); }
        }
        private void Down(long ms)
        {
            SystemTime time = SystemTimeHelper.GetTime();
            SystemTime newTime = SystemTimeOperationsHelper.Substract(time, ms);
            try
            {
                SystemTimeHelper.SetTime(newTime);
                _timeDiff.Substract(ms);
            }
            catch (Exception e) { FormHelper.ErrorMessage(e.Message); }
        }
        private void Log(SystemTime oldTime, SystemTime newTime, SystemTime checkTime, long diffMs, long elapsedMs)
        {
            string format = "HH:mm:ss.fff";
            var oldDT = SystemTimeOperationsHelper.ToDateTime(oldTime);
            var newDT = SystemTimeOperationsHelper.ToDateTime(newTime);
            var checkDT = SystemTimeOperationsHelper.ToDateTime(checkTime);
            using (StreamWriter sw = File.AppendText("log.txt"))
            {
                sw.WriteLine($"Old = {oldDT.ToString(format)} New = {newDT.ToString(format)} Check = {checkDT.ToString(format)} ({diffMs}ms) - Elapsed {elapsedMs}ms");
            }
        }
    }
}
