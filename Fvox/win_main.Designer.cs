namespace Fvox
{
    partial class win_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(win_main));
            this.vh = new System.Windows.Forms.CheckBox();
            this.label_FROM = new System.Windows.Forms.Label();
            this.internaltimer = new System.Windows.Forms.Timer(this.components);
            this.vh_period_from = new System.Windows.Forms.TextBox();
            this.label_zeros1 = new System.Windows.Forms.Label();
            this.vh_period = new System.Windows.Forms.CheckBox();
            this.label_TO = new System.Windows.Forms.Label();
            this.vh_period_to = new System.Windows.Forms.TextBox();
            this.label_zeros2 = new System.Windows.Forms.Label();
            this.vpow = new System.Windows.Forms.CheckBox();
            this.vpow_threshold = new System.Windows.Forms.CheckBox();
            this.label_LOWERTHAN = new System.Windows.Forms.Label();
            this.vpow_threshold_percent = new System.Windows.Forms.TextBox();
            this.label_PERCENT1 = new System.Windows.Forms.Label();
            this.button_SAVE = new System.Windows.Forms.Button();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.времяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vh
            // 
            this.vh.AutoSize = true;
            this.vh.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.vh.ForeColor = System.Drawing.Color.Black;
            this.vh.Location = new System.Drawing.Point(37, 12);
            this.vh.Name = "vh";
            this.vh.Size = new System.Drawing.Size(138, 23);
            this.vh.TabIndex = 0;
            this.vh.Text = "VOX every hour";
            this.vh.UseVisualStyleBackColor = false;
            this.vh.CheckStateChanged += new System.EventHandler(this.vh_CheckStateChanged);
            // 
            // label_FROM
            // 
            this.label_FROM.AutoSize = true;
            this.label_FROM.ForeColor = System.Drawing.Color.DimGray;
            this.label_FROM.Location = new System.Drawing.Point(38, 71);
            this.label_FROM.Name = "label_FROM";
            this.label_FROM.Size = new System.Drawing.Size(54, 19);
            this.label_FROM.TabIndex = 1;
            this.label_FROM.Text = "FROM:";
            // 
            // internaltimer
            // 
            this.internaltimer.Interval = 1000;
            this.internaltimer.Tick += new System.EventHandler(this.internaltimer_Tick);
            // 
            // vh_period_from
            // 
            this.vh_period_from.Enabled = false;
            this.vh_period_from.ForeColor = System.Drawing.Color.DimGray;
            this.vh_period_from.Location = new System.Drawing.Point(98, 68);
            this.vh_period_from.MaxLength = 2;
            this.vh_period_from.Name = "vh_period_from";
            this.vh_period_from.Size = new System.Drawing.Size(25, 24);
            this.vh_period_from.TabIndex = 2;
            this.vh_period_from.Text = "08";
            this.vh_period_from.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vh_period_from.TextChanged += new System.EventHandler(this.vh_period_from_TextChanged);
            // 
            // label_zeros1
            // 
            this.label_zeros1.AutoSize = true;
            this.label_zeros1.ForeColor = System.Drawing.Color.DimGray;
            this.label_zeros1.Location = new System.Drawing.Point(129, 71);
            this.label_zeros1.Name = "label_zeros1";
            this.label_zeros1.Size = new System.Drawing.Size(33, 19);
            this.label_zeros1.TabIndex = 3;
            this.label_zeros1.Text = ": 00";
            // 
            // vh_period
            // 
            this.vh_period.AutoSize = true;
            this.vh_period.Enabled = false;
            this.vh_period.ForeColor = System.Drawing.Color.DimGray;
            this.vh_period.Location = new System.Drawing.Point(37, 39);
            this.vh_period.Name = "vh_period";
            this.vh_period.Size = new System.Drawing.Size(81, 23);
            this.vh_period.TabIndex = 0;
            this.vh_period.Text = "PERIOD";
            this.vh_period.UseVisualStyleBackColor = false;
            this.vh_period.CheckStateChanged += new System.EventHandler(this.vh_period_CheckStateChanged);
            // 
            // label_TO
            // 
            this.label_TO.AutoSize = true;
            this.label_TO.ForeColor = System.Drawing.Color.DimGray;
            this.label_TO.Location = new System.Drawing.Point(38, 102);
            this.label_TO.Name = "label_TO";
            this.label_TO.Size = new System.Drawing.Size(30, 19);
            this.label_TO.TabIndex = 1;
            this.label_TO.Text = "TO:";
            // 
            // vh_period_to
            // 
            this.vh_period_to.Enabled = false;
            this.vh_period_to.ForeColor = System.Drawing.Color.DimGray;
            this.vh_period_to.Location = new System.Drawing.Point(98, 100);
            this.vh_period_to.MaxLength = 2;
            this.vh_period_to.Name = "vh_period_to";
            this.vh_period_to.Size = new System.Drawing.Size(25, 24);
            this.vh_period_to.TabIndex = 2;
            this.vh_period_to.Text = "22";
            this.vh_period_to.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vh_period_to.TextChanged += new System.EventHandler(this.vh_period_to_TextChanged);
            // 
            // label_zeros2
            // 
            this.label_zeros2.AutoSize = true;
            this.label_zeros2.ForeColor = System.Drawing.Color.DimGray;
            this.label_zeros2.Location = new System.Drawing.Point(129, 102);
            this.label_zeros2.Name = "label_zeros2";
            this.label_zeros2.Size = new System.Drawing.Size(33, 19);
            this.label_zeros2.TabIndex = 3;
            this.label_zeros2.Text = ": 00";
            // 
            // vpow
            // 
            this.vpow.AutoSize = true;
            this.vpow.ForeColor = System.Drawing.Color.Black;
            this.vpow.Location = new System.Drawing.Point(37, 145);
            this.vpow.Name = "vpow";
            this.vpow.Size = new System.Drawing.Size(145, 23);
            this.vpow.TabIndex = 0;
            this.vpow.Text = "VOX power level";
            this.vpow.UseVisualStyleBackColor = true;
            this.vpow.CheckStateChanged += new System.EventHandler(this.vpow_CheckStateChanged);
            // 
            // vpow_threshold
            // 
            this.vpow_threshold.AutoSize = true;
            this.vpow_threshold.Enabled = false;
            this.vpow_threshold.ForeColor = System.Drawing.Color.DimGray;
            this.vpow_threshold.Location = new System.Drawing.Point(37, 174);
            this.vpow_threshold.Name = "vpow_threshold";
            this.vpow_threshold.Size = new System.Drawing.Size(166, 23);
            this.vpow_threshold.TabIndex = 0;
            this.vpow_threshold.Text = "WARNING threshold";
            this.vpow_threshold.UseVisualStyleBackColor = true;
            this.vpow_threshold.CheckStateChanged += new System.EventHandler(this.vpow_threshold_CheckStateChanged);
            // 
            // label_LOWERTHAN
            // 
            this.label_LOWERTHAN.AutoSize = true;
            this.label_LOWERTHAN.ForeColor = System.Drawing.Color.DimGray;
            this.label_LOWERTHAN.Location = new System.Drawing.Point(37, 200);
            this.label_LOWERTHAN.Name = "label_LOWERTHAN";
            this.label_LOWERTHAN.Size = new System.Drawing.Size(101, 19);
            this.label_LOWERTHAN.TabIndex = 1;
            this.label_LOWERTHAN.Text = "LOWER THAN:";
            // 
            // vpow_threshold_percent
            // 
            this.vpow_threshold_percent.Enabled = false;
            this.vpow_threshold_percent.ForeColor = System.Drawing.Color.DimGray;
            this.vpow_threshold_percent.Location = new System.Drawing.Point(137, 197);
            this.vpow_threshold_percent.Name = "vpow_threshold_percent";
            this.vpow_threshold_percent.Size = new System.Drawing.Size(25, 24);
            this.vpow_threshold_percent.TabIndex = 2;
            this.vpow_threshold_percent.Text = "30";
            this.vpow_threshold_percent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.vpow_threshold_percent.TextChanged += new System.EventHandler(this.vpow_threshold_percent_TextChanged);
            // 
            // label_PERCENT1
            // 
            this.label_PERCENT1.AutoSize = true;
            this.label_PERCENT1.ForeColor = System.Drawing.Color.DimGray;
            this.label_PERCENT1.Location = new System.Drawing.Point(168, 200);
            this.label_PERCENT1.Name = "label_PERCENT1";
            this.label_PERCENT1.Size = new System.Drawing.Size(20, 19);
            this.label_PERCENT1.TabIndex = 1;
            this.label_PERCENT1.Text = "%";
            // 
            // button_SAVE
            // 
            this.button_SAVE.Location = new System.Drawing.Point(75, 227);
            this.button_SAVE.Name = "button_SAVE";
            this.button_SAVE.Size = new System.Drawing.Size(75, 23);
            this.button_SAVE.TabIndex = 4;
            this.button_SAVE.Text = "SAVE";
            this.button_SAVE.UseVisualStyleBackColor = true;
            this.button_SAVE.Click += new System.EventHandler(this.button_SAVE_Click);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.contextMenuStrip1;
            this.notify.Text = "VOXit";
            this.notify.Visible = true;
            this.notify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.времяToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.выходToolStripMenuItem.Text = "Exit";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // времяToolStripMenuItem
            // 
            this.времяToolStripMenuItem.Name = "времяToolStripMenuItem";
            this.времяToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.времяToolStripMenuItem.Text = "Time";
            this.времяToolStripMenuItem.Click += new System.EventHandler(this.времяToolStripMenuItem_Click);
            // 
            // win_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(223, 265);
            this.Controls.Add(this.button_SAVE);
            this.Controls.Add(this.label_zeros2);
            this.Controls.Add(this.label_zeros1);
            this.Controls.Add(this.vh_period_to);
            this.Controls.Add(this.vpow_threshold_percent);
            this.Controls.Add(this.vh_period_from);
            this.Controls.Add(this.label_TO);
            this.Controls.Add(this.label_PERCENT1);
            this.Controls.Add(this.label_LOWERTHAN);
            this.Controls.Add(this.label_FROM);
            this.Controls.Add(this.vh_period);
            this.Controls.Add(this.vpow_threshold);
            this.Controls.Add(this.vpow);
            this.Controls.Add(this.vh);
            this.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(241, 312);
            this.MinimumSize = new System.Drawing.Size(241, 312);
            this.Name = "win_main";
            this.Text = "VOXit v.002";
            this.Load += new System.EventHandler(this.win_main_Load);
            this.SizeChanged += new System.EventHandler(this.win_main_SizeChanged);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox vh;
        private System.Windows.Forms.Label label_FROM;
        private System.Windows.Forms.Timer internaltimer;
        private System.Windows.Forms.TextBox vh_period_from;
        private System.Windows.Forms.Label label_zeros1;
        private System.Windows.Forms.CheckBox vh_period;
        private System.Windows.Forms.Label label_TO;
        private System.Windows.Forms.TextBox vh_period_to;
        private System.Windows.Forms.Label label_zeros2;
        private System.Windows.Forms.CheckBox vpow;
        private System.Windows.Forms.CheckBox vpow_threshold;
        private System.Windows.Forms.Label label_LOWERTHAN;
        private System.Windows.Forms.TextBox vpow_threshold_percent;
        private System.Windows.Forms.Label label_PERCENT1;
        private System.Windows.Forms.Button button_SAVE;
        private System.Windows.Forms.NotifyIcon notify;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem времяToolStripMenuItem;
    }
}

