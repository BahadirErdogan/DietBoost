﻿namespace ProjeTaslak
{
    partial class FrmMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMeal));
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lvMealDetails = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMeals = new System.Windows.Forms.ComboBox();
            this.btnRemoveFood = new System.Windows.Forms.Button();
            this.btnUpdateMeal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label6.Location = new System.Drawing.Point(20, 70);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 61;
            this.label6.Text = "Meal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label4.Location = new System.Drawing.Point(144, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 60;
            this.label4.Text = "@totalCalorie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProjeTaslak.Properties.Resources.DietBoostLogo__1_;
            this.pictureBox1.Location = new System.Drawing.Point(261, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 59;
            this.pictureBox1.TabStop = false;
            // 
            // lvMealDetails
            // 
            this.lvMealDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvMealDetails.FullRowSelect = true;
            this.lvMealDetails.HideSelection = false;
            this.lvMealDetails.Location = new System.Drawing.Point(24, 128);
            this.lvMealDetails.Margin = new System.Windows.Forms.Padding(4);
            this.lvMealDetails.Name = "lvMealDetails";
            this.lvMealDetails.Size = new System.Drawing.Size(369, 184);
            this.lvMealDetails.TabIndex = 58;
            this.lvMealDetails.UseCompatibleStateImageBehavior = false;
            this.lvMealDetails.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quantity";
            this.columnHeader1.Width = 71;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Food";
            this.columnHeader2.Width = 167;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Calorie";
            this.columnHeader3.Width = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 57;
            this.label3.Text = "Meal Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label2.Location = new System.Drawing.Point(24, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 56;
            this.label2.Text = "Total Callories:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 55;
            this.label1.Text = " ";
            // 
            // btnAddFood
            // 
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFood.Image = global::ProjeTaslak.Properties.Resources.add2;
            this.btnAddFood.Location = new System.Drawing.Point(401, 128);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(48, 50);
            this.btnAddFood.TabIndex = 54;
            this.btnAddFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddFood.UseVisualStyleBackColor = true;
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(89, 37);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(155, 26);
            this.dtpDate.TabIndex = 53;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label5.Location = new System.Drawing.Point(20, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Date :";
            // 
            // cbMeals
            // 
            this.cbMeals.FormattingEnabled = true;
            this.cbMeals.Location = new System.Drawing.Point(89, 67);
            this.cbMeals.Margin = new System.Windows.Forms.Padding(4);
            this.cbMeals.Name = "cbMeals";
            this.cbMeals.Size = new System.Drawing.Size(155, 28);
            this.cbMeals.TabIndex = 51;
            // 
            // btnRemoveFood
            // 
            this.btnRemoveFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemoveFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnRemoveFood.Image = global::ProjeTaslak.Properties.Resources.remove2;
            this.btnRemoveFood.Location = new System.Drawing.Point(401, 262);
            this.btnRemoveFood.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveFood.Name = "btnRemoveFood";
            this.btnRemoveFood.Size = new System.Drawing.Size(48, 50);
            this.btnRemoveFood.TabIndex = 50;
            this.btnRemoveFood.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveFood.UseVisualStyleBackColor = true;
            // 
            // btnUpdateMeal
            // 
            this.btnUpdateMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateMeal.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateMeal.Image = global::ProjeTaslak.Properties.Resources.save2;
            this.btnUpdateMeal.Location = new System.Drawing.Point(401, 195);
            this.btnUpdateMeal.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMeal.Name = "btnUpdateMeal";
            this.btnUpdateMeal.Size = new System.Drawing.Size(48, 50);
            this.btnUpdateMeal.TabIndex = 49;
            this.btnUpdateMeal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateMeal.UseVisualStyleBackColor = true;
            // 
            // FrmMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(464, 356);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lvMealDetails);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMeals);
            this.Controls.Add(this.btnRemoveFood);
            this.Controls.Add(this.btnUpdateMeal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmMeal";
            this.Text = "Meal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lvMealDetails;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMeals;
        private System.Windows.Forms.Button btnRemoveFood;
        private System.Windows.Forms.Button btnUpdateMeal;
    }
}