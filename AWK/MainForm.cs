using System;
using System.Windows.Forms;

namespace AWK
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            maskedTextBox1.Text = "00:00:00";
            inSpecifiedTime.Checked = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!inSpecifiedTime.Checked && !inGivenTime.Checked)
                {
                    MessageBox.Show("Nie wybrano typu odliczania do wyłączenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (maskedTextBox1.Text == "00:00:00")
                    throw new Exception();

                DateTime time = DateTime.Now;
                if (inGivenTime.Checked)
                {
                    var shutdownTime = DateTime.Parse(maskedTextBox1.Text);
                    var newDate = new TimeSpan();
                    if (shutdownTime < DateTime.Now)
                    {
                        shutdownTime = shutdownTime.AddDays(1);
                        newDate = shutdownTime.Subtract(DateTime.Now);
                    }
                    else
                        newDate = shutdownTime.Subtract(DateTime.Now);

                    time = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.AddDays(newDate.Days).Day, newDate.Hours, newDate.Minutes, newDate.Seconds);
                }
                else
                    time = DateTime.Parse(maskedTextBox1.Text);

                var countdown = new Countdown(time);
                countdown.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Niepoprawnie wprowadzony czas. Czas musi być większy niż 00:00:00 oraz mniejszy niż 23:59:59", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
