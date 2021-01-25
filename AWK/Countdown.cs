using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AWK
{
    public partial class Countdown : Form
    {
        private int totalSeconds;
        public Countdown(DateTime time)
        {
            InitializeComponent();
            totalSeconds = (time.Hour * 3600) + (time.Minute * 60) + time.Second;
            timeLabel.Text = time.ToString("HH:mm:ss");
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                if (totalSeconds <= 10)
                {
                    var waveOut = new WaveOut();
                    var mp3FileReader = new WaveFileReader(@"Sounds/beep.wav");
                    var x = WaveFormatConversionStream.CreatePcmStream(mp3FileReader);

                    waveOut.Init(x);
                    waveOut.Play();
                }

                totalSeconds--;
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds / 60) - (hours * 60);
                int seconds = totalSeconds - (minutes * 60) - (hours * 3600);

                timeLabel.Text = string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, seconds);
            }
            else
            {
                this.timer1.Stop();
                Process.Start("shutdown", "/s /t 0");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Hide();
            var mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
