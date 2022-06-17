﻿
namespace ProjeTaslak
{
    partial class FrmMainScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSelectedDailyCalorieInTake = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblTodaysCalorieIntake = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRecommendedCalorie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.lvMeals = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.dtpMeals = new System.Windows.Forms.DateTimePicker();
            this.btnMeals = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.updateToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(912, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.accountToolStripMenuItem.Text = "Account";
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.aboutUsToolStripMenuItem.Text = "About Us";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.logOutToolStripMenuItem.Text = "Log Out";
            // 
            // lblSelectedDailyCalorieInTake
            // 
            this.lblSelectedDailyCalorieInTake.AutoSize = true;
            this.lblSelectedDailyCalorieInTake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.lblSelectedDailyCalorieInTake.Location = new System.Drawing.Point(651, 595);
            this.lblSelectedDailyCalorieInTake.Name = "lblSelectedDailyCalorieInTake";
            this.lblSelectedDailyCalorieInTake.Size = new System.Drawing.Size(39, 20);
            this.lblSelectedDailyCalorieInTake.TabIndex = 73;
            this.lblSelectedDailyCalorieInTake.Text = "300";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label8.Location = new System.Drawing.Point(507, 595);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 20);
            this.label8.TabIndex = 72;
            this.label8.Text = "Total Callories:";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(511, 307);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.LabelBackColor = System.Drawing.Color.Black;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(335, 260);
            this.chart1.TabIndex = 71;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjeTaslak.Properties.Resources.DietBoostLogo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(618, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 70;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 154);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(575, 23);
            this.progressBar1.TabIndex = 69;
            // 
            // lblTodaysCalorieIntake
            // 
            this.lblTodaysCalorieIntake.AutoSize = true;
            this.lblTodaysCalorieIntake.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.lblTodaysCalorieIntake.Location = new System.Drawing.Point(562, 120);
            this.lblTodaysCalorieIntake.Name = "lblTodaysCalorieIntake";
            this.lblTodaysCalorieIntake.Size = new System.Drawing.Size(39, 20);
            this.lblTodaysCalorieIntake.TabIndex = 68;
            this.lblTodaysCalorieIntake.Text = "300";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label4.Location = new System.Drawing.Point(382, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "Daily Calorie Intake -";
            // 
            // lblRecommendedCalorie
            // 
            this.lblRecommendedCalorie.AutoSize = true;
            this.lblRecommendedCalorie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.lblRecommendedCalorie.Location = new System.Drawing.Point(284, 120);
            this.lblRecommendedCalorie.Name = "lblRecommendedCalorie";
            this.lblRecommendedCalorie.Size = new System.Drawing.Size(39, 20);
            this.lblRecommendedCalorie.TabIndex = 66;
            this.lblRecommendedCalorie.Text = "700";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label2.Location = new System.Drawing.Point(29, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 20);
            this.label2.TabIndex = 65;
            this.label2.Text = "Recommended Calorie Limit -";
            // 
            // btnReports
            // 
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.btnReports.Image = global::ProjeTaslak.Properties.Resources.Reports4;
            this.btnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReports.Location = new System.Drawing.Point(692, 233);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(139, 56);
            this.btnReports.TabIndex = 64;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // lvMeals
            // 
            this.lvMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.lvMeals.GridLines = true;
            this.lvMeals.HideSelection = false;
            this.lvMeals.Location = new System.Drawing.Point(40, 226);
            this.lvMeals.Name = "lvMeals";
            this.lvMeals.Size = new System.Drawing.Size(440, 393);
            this.lvMeals.TabIndex = 63;
            this.lvMeals.UseCompatibleStateImageBehavior = false;
            this.lvMeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Meal";
            this.columnHeader1.Width = 109;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quantity";
            this.columnHeader2.Width = 85;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Food Name";
            this.columnHeader3.Width = 203;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label7.Location = new System.Drawing.Point(37, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 62;
            this.label7.Text = "Daily Meals";
            // 
            // dtpMeals
            // 
            this.dtpMeals.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.dtpMeals.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.dtpMeals.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.dtpMeals.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.dtpMeals.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.dtpMeals.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpMeals.Location = new System.Drawing.Point(337, 193);
            this.dtpMeals.Name = "dtpMeals";
            this.dtpMeals.Size = new System.Drawing.Size(143, 26);
            this.dtpMeals.TabIndex = 61;
            // 
            // btnMeals
            // 
            this.btnMeals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeals.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMeals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.btnMeals.Image = global::ProjeTaslak.Properties.Resources.melaIcon;
            this.btnMeals.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMeals.Location = new System.Drawing.Point(531, 233);
            this.btnMeals.Name = "btnMeals";
            this.btnMeals.Size = new System.Drawing.Size(139, 56);
            this.btnMeals.TabIndex = 60;
            this.btnMeals.Text = "My Meals";
            this.btnMeals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMeals.UseVisualStyleBackColor = true;
            this.btnMeals.Click += new System.EventHandler(this.btnMeals_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.lblUserName.Location = new System.Drawing.Point(122, 75);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(131, 25);
            this.lblUserName.TabIndex = 75;
            this.lblUserName.Text = "@userName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label1.Location = new System.Drawing.Point(28, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 25);
            this.label1.TabIndex = 74;
            this.label1.Text = "Welcome";
            // 
            // FrmMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(912, 657);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectedDailyCalorieInTake);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblTodaysCalorieIntake);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRecommendedCalorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReports);
            this.Controls.Add(this.lvMeals);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpMeals);
            this.Controls.Add(this.btnMeals);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMainScreen";
            this.Text = "Main Screen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.Label lblSelectedDailyCalorieInTake;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblTodaysCalorieIntake;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRecommendedCalorie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.ListView lvMeals;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpMeals;
        private System.Windows.Forms.Button btnMeals;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label label1;
    }
}