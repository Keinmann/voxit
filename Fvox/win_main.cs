using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Media;
namespace Fvox
{
    public partial class win_main : Form
    {
        private bool powerlow=false,powercrit=false;
        public win_main()
        {
            InitializeComponent();
        }
        private void vh_CheckStateChanged(object sender, EventArgs e)
        {
            if (vh.Checked)
            {
                vh_period.ForeColor = Color.Black;
                vh_period.Enabled = true;
                internaltimer.Start();
            }
            else 
            {
                vh_period.ForeColor = Color.DimGray;
                vh_period.Enabled = vh_period.Checked = false;
                internaltimer.Stop();
            }
        }
        private void vh_period_CheckStateChanged(object sender, EventArgs e)
        {
            if (vh_period.Checked)
            {
                label_FROM.ForeColor =
                label_TO.ForeColor =
                label_zeros1.ForeColor =
                label_zeros2.ForeColor =
                vh_period_from.ForeColor =
                vh_period_to.ForeColor = Color.Black;
                vh_period_from.Enabled = vh_period_to.Enabled = true;
            }
            else 
            {
                label_FROM.ForeColor =
                label_TO.ForeColor =
                label_zeros1.ForeColor =
                label_zeros2.ForeColor =
                vh_period_from.ForeColor =
                vh_period_to.ForeColor = Color.DimGray;
                vh_period_from.Enabled = vh_period_to.Enabled = false;
                vh_period_from.Text = "08";
                vh_period_to.Text = "22";
            }
        }
        private bool DigitsValidated(string line) 
        {
            if (line == "") return false;
            if (line == null) return false;
            for (int i = 0; i < line.Length;i++)
            {
                if (!Char.IsDigit(line[i])) return false;
            }
            return true;
        }
        private void vh_period_from_TextChanged(object sender, EventArgs e)
        {
            if (DigitsValidated(vh_period_from.Text))
            {
                int vh_per_from = Convert.ToInt32(vh_period_from.Text);
                if (vh_per_from > 23)
                {
                    vh_per_from = 23;
                    vh_period_from.Text = vh_per_from.ToString();
                }
                if (vh_per_from < 0)
                {
                    vh_per_from = 0;
                    vh_period_from.Text = vh_per_from.ToString();
                }
            }
            else { vh_period_from.Text = ""; }
        }
        private void vh_period_to_TextChanged(object sender, EventArgs e)
        {
            if (DigitsValidated(vh_period_to.Text))
            {
                int vh_per_to = Convert.ToInt32(vh_period_to.Text);
                if (vh_per_to > 23)
                {
                    vh_per_to = 23;
                    vh_period_to.Text = vh_per_to.ToString();
                }
                if (vh_per_to < 0)
                {
                    vh_per_to = 0;
                    vh_period_to.Text = vh_per_to.ToString();
                }
            }
            else { vh_period_to.Text = ""; }
        }
        private void vpow_threshold_CheckStateChanged(object sender, EventArgs e)
        {
            if (vpow_threshold.Checked)
            {
                label_LOWERTHAN.ForeColor =
                vpow_threshold_percent.ForeColor =
                label_PERCENT1.ForeColor = Color.Black;
                vpow_threshold_percent.Enabled = true;
            }
            else 
            {
                label_LOWERTHAN.ForeColor =
                vpow_threshold_percent.ForeColor =
                label_PERCENT1.ForeColor = Color.DimGray;
                vpow_threshold_percent.Enabled = false;
                vpow_threshold_percent.Text = "30";
            }
        }
        private void vpow_threshold_percent_TextChanged(object sender, EventArgs e)
        {
            if (DigitsValidated(vpow_threshold_percent.Text))
            {
                int vpow_thr_percent = Convert.ToInt32(vpow_threshold_percent.Text);
                if (vpow_thr_percent > 99)
                {
                    vpow_thr_percent = 99;
                    vpow_threshold_percent.Text = vpow_thr_percent.ToString();
                }
                if (vpow_thr_percent < 0)
                {
                    vpow_thr_percent = 0;
                    vpow_threshold_percent.Text = vpow_thr_percent.ToString();
                }
            }
            else { vpow_threshold_percent.Text = ""; }
        }
        private void button_SAVE_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.everyhour = vh.Checked;
            Properties.Settings.Default.period = vh_period.Checked;
            Properties.Settings.Default.power = vpow.Checked;
            Properties.Settings.Default.threshold = vpow_threshold.Checked;
            Properties.Settings.Default.from = Convert.ToInt32(vh_period_from.Text);
            Properties.Settings.Default.to = Convert.ToInt32(vh_period_to.Text);
            Properties.Settings.Default.thresholdpercent = Convert.ToInt32(vpow_threshold_percent.Text);
            Properties.Settings.Default.Save();
            SoundPlayer player = new SoundPlayer();
            if (vh.Checked == true)
            {
                player.Stream = Properties.Resources.voice_on;
            }
            else 
            {
                player.Stream = Properties.Resources.voice_off;
            }
            player.PlaySync();
        }
        private void win_main_Load(object sender, EventArgs e)
        {
            vh.Checked = Properties.Settings.Default.everyhour;
            vh_period.Checked = Properties.Settings.Default.period;
            vpow.Checked = Properties.Settings.Default.power;
            vpow_threshold.Checked = Properties.Settings.Default.threshold;
            vh_period_from.Text = Properties.Settings.Default.from.ToString();
            vh_period_to.Text = Properties.Settings.Default.to.ToString();
            vpow_threshold_percent.Text = Properties.Settings.Default.thresholdpercent.ToString();
            notify.Visible = false;
            notify.Icon = Properties.Resources.hl;
            this.Icon = Properties.Resources.hl;
            notify.BalloonTipTitle = this.Text;
            notify.BalloonTipText = "Приложение свёрнуто";
            SoundPlayer player = new SoundPlayer(Properties.Resources.communications_on);
            player.PlaySync();
            if (Properties.Settings.Default.trayed)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private string IdentifyNumber(int number,bool tens= false)
        {
            string num = "";
            if (number <= 19&&number >= 0)
            {
                switch (number)
                {
                    case 0: num = "twelve"; break;
                    case 1: num = "one"; break;
                    case 2: num = "two"; break;
                    case 3: num = "three"; break;
                    case 4: num = "four"; break;
                    case 5: num = "five"; break;
                    case 6: num = "six"; break;
                    case 7: num = "seven"; break;
                    case 8: num = "eight"; break;
                    case 9: num = "nine"; break;
                    case 10: num = "ten"; break;
                    case 11: num = "eleven"; break;
                    case 12: num = "twelve"; break;
                    case 13: num = "thirteen"; break;
                    case 14: num = "fourteen"; break;
                    case 15: num = "fifteen"; break;
                    case 16: num = "sixteen"; break;
                    case 17: num = "seventeen"; break;
                    case 18: num = "eighteen"; break;
                    case 19: num = "nineteen"; break;
                }
            }
            else if(tens)
            {
                switch (number/10)
                {
                    case 2: num = "twenty"; break;
                    case 3: num = "thirty"; break;
                    case 4: num = "fourty"; break;
                    case 5: num = "fifty"; break;
                    case 6: num = "sixty"; break;
                    case 7: num = "seventy"; break;
                    case 8: num = "eighty"; break;
                    case 9: num = "ninety"; break;
                }
            }
            else if(!tens)
            switch (number%10)
            {
                case 1: num = "one"; break;
                case 2: num = "two"; break;
                case 3: num = "three"; break;
                case 4: num = "four"; break;
                case 5: num = "five"; break;
                case 6: num = "six"; break;
                case 7: num = "seven"; break;
                case 8: num = "eight"; break;
                case 9: num = "nine"; break;
            }
            return num;
        }
        private void AnnounceTime()
        {
            DateTime nowtime = DateTime.Now;
            SoundPlayer player = new SoundPlayer(Properties.Resources.time_is_now);
            player.PlaySync();
            string filename = IdentifyNumber(nowtime.Hour%12, false);
            player.Stream = Properties.Resources.ResourceManager.GetStream(filename);
            player.PlaySync();
            if (nowtime.Minute != 0) 
            {
                if (nowtime.Minute <= 19 && nowtime.Minute >= 1)
                {
                    filename = IdentifyNumber(nowtime.Minute, false);
                    player = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(filename));
                    player.PlaySync();
                }
                else 
                {
                    filename = IdentifyNumber(nowtime.Minute, true);
                    player = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(filename));
                    player.PlaySync();
                    if (nowtime.Minute / 10 != 0) 
                    {
                        filename = IdentifyNumber(nowtime.Minute, false);
                        player = new SoundPlayer(Properties.Resources.ResourceManager.GetStream(filename));
                        player.PlaySync();
                    }
                }
            }
            if (nowtime.Hour == 0 || (nowtime.Hour > 12 && nowtime.Hour <= 23))
            {
                player.Stream = Properties.Resources.pm;
            }
            else
            {
                player.Stream = Properties.Resources.am;
            }
            player.PlaySync();
            bool ACpresent = SystemPower.ACPowerPluggedIn();
            if (!ACpresent && vpow.Checked==true)
            {
                int relcharge = SystemPower.BatteryCharge();
                player.Stream = Properties.Resources.power_level_is;
                player.PlaySync();
                if (relcharge > 0 && relcharge <= 19)
                {
                    player.Stream = Properties.Resources.ResourceManager.GetStream(IdentifyNumber(relcharge, false));
                    player.PlaySync();
                }
                else if (relcharge > 19 && relcharge < 100)
                {
                    player.Stream = Properties.Resources.ResourceManager.GetStream(IdentifyNumber(relcharge, true));
                    player.PlaySync();
                    player.Stream = Properties.Resources.ResourceManager.GetStream(IdentifyNumber(relcharge, false));
                    player.PlaySync();
                }
                else 
                {
                    player.Stream = Properties.Resources.onehundred;
                    player.PlaySync();
                }                
                player.Stream = Properties.Resources.percent;
                player.PlaySync();
            }
        }
        private void internaltimer_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now.Minute == 0 && DateTime.Now.Second == 0 && vh.Checked)
            {
                if (vh_period.Checked == true && (DateTime.Now.Hour < Properties.Settings.Default.from || DateTime.Now.Hour > Properties.Settings.Default.to)) { return; }
               
                AnnounceTime();
                
            }
            if (vpow.Checked) 
            { int chg = SystemPower.BatteryCharge();
                if (chg < Properties.Settings.Default.thresholdpercent&&!powerlow)
                {
                    powerlow = true;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.power_below);
                    player.PlaySync();
                    string filename;
                    if (Properties.Settings.Default.thresholdpercent <= 19) 
                    { 
                        filename = IdentifyNumber(Properties.Settings.Default.thresholdpercent, false);
                        player.Stream = Properties.Resources.ResourceManager.GetStream(filename);
                        player.PlaySync();
                        player.Stream = Properties.Resources.percent;
                        player.PlaySync();
                    }  
                    else 
                    {
                        filename= IdentifyNumber(Properties.Settings.Default.thresholdpercent, true);
                        player.Stream = Properties.Resources.ResourceManager.GetStream(filename);
                        player.PlaySync();
                        if (Properties.Settings.Default.thresholdpercent % 10 != 0) 
                        {
                            filename = IdentifyNumber(Properties.Settings.Default.thresholdpercent, false);
                            player.Stream = Properties.Resources.ResourceManager.GetStream(filename);
                            player.PlaySync();
                        }
                        player.Stream = Properties.Resources.percent;
                        player.PlaySync();
                    }

                }
                else if (chg > Properties.Settings.Default.thresholdpercent&&powerlow) 
                {
                    powercrit = false;
                    powerlow = false;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.power_restored);
                    player.PlaySync();
                }
                if (!powercrit && chg < 7) 
                {
                    powercrit = true;
                    SoundPlayer player = new SoundPlayer(Properties.Resources.alert);
                    player.PlaySync();
                    player.Stream = Properties.Resources.power_level_is;
                    player.PlaySync();
                    string filename = IdentifyNumber(chg);
                    player.Stream = Properties.Resources.ResourceManager.GetStream(filename);
                    player.PlaySync();
                    player.Stream = Properties.Resources.percent;
                }

            }
        }
        private void vpow_CheckStateChanged(object sender, EventArgs e)
        {
            if (vpow.Checked) 
            {
                vpow_threshold.ForeColor = vpow_threshold_percent.ForeColor = Color.Black;
                vpow_threshold.Enabled = vpow_threshold_percent.Enabled = true;
            }
            else 
            {
                vpow_threshold.ForeColor = vpow_threshold_percent.ForeColor = Color.Black;
                vpow_threshold.Enabled = vpow_threshold_percent.Enabled = false;
                vpow_threshold_percent.Text = Properties.Settings.Default.thresholdpercent.ToString();
            }
        }
        private void win_main_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                notify.Visible = true;
                this.Hide();
                notify.ShowBalloonTip(700);
                this.ShowInTaskbar = false;
                Properties.Settings.Default.trayed = true;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                notify.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            Properties.Settings.Default.trayed = false;
        }
        private void времяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnnounceTime();
        }
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.safe_day);
            player.PlaySync();
            Application.Exit();
        }
    }
}
