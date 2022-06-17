namespace ProjeTaslak
{
    partial class FrmAdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPanel));
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.grpKullaniciAktivasyon = new System.Windows.Forms.GroupBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.nudGramPortion = new System.Windows.Forms.NumericUpDown();
            this.nudGramPiece = new System.Windows.Forms.NumericUpDown();
            this.nudProtein = new System.Windows.Forms.NumericUpDown();
            this.nudCarbs = new System.Windows.Forms.NumericUpDown();
            this.nudFat = new System.Windows.Forms.NumericUpDown();
            this.nudCalorie = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.lvFoods = new System.Windows.Forms.ListView();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnChooseFile = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.grpKullaniciAktivasyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGramPortion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGramPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.label10.Location = new System.Drawing.Point(21, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(184, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "ADMIN PANEL";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvUsers);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.groupBox1.Location = new System.Drawing.Point(572, 67);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(518, 540);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Activation";
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvUsers.GridLines = true;
            this.lvUsers.HideSelection = false;
            this.lvUsers.Location = new System.Drawing.Point(18, 26);
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(493, 486);
            this.lvUsers.TabIndex = 19;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvUsers_MouseDoubleClick);
            // 
            // grpKullaniciAktivasyon
            // 
            this.grpKullaniciAktivasyon.Controls.Add(this.cbCategory);
            this.grpKullaniciAktivasyon.Controls.Add(this.label11);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudGramPortion);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudGramPiece);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudProtein);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudCarbs);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudFat);
            this.grpKullaniciAktivasyon.Controls.Add(this.nudCalorie);
            this.grpKullaniciAktivasyon.Controls.Add(this.btnUpdateFood);
            this.grpKullaniciAktivasyon.Controls.Add(this.btnAddFood);
            this.grpKullaniciAktivasyon.Controls.Add(this.label9);
            this.grpKullaniciAktivasyon.Controls.Add(this.lvFoods);
            this.grpKullaniciAktivasyon.Controls.Add(this.txtFoodName);
            this.grpKullaniciAktivasyon.Controls.Add(this.label8);
            this.grpKullaniciAktivasyon.Controls.Add(this.label7);
            this.grpKullaniciAktivasyon.Controls.Add(this.btnChooseFile);
            this.grpKullaniciAktivasyon.Controls.Add(this.label6);
            this.grpKullaniciAktivasyon.Controls.Add(this.label5);
            this.grpKullaniciAktivasyon.Controls.Add(this.label4);
            this.grpKullaniciAktivasyon.Controls.Add(this.label3);
            this.grpKullaniciAktivasyon.Controls.Add(this.label2);
            this.grpKullaniciAktivasyon.Controls.Add(this.label1);
            this.grpKullaniciAktivasyon.Controls.Add(this.txtImagePath);
            this.grpKullaniciAktivasyon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.grpKullaniciAktivasyon.Location = new System.Drawing.Point(4, 67);
            this.grpKullaniciAktivasyon.Margin = new System.Windows.Forms.Padding(4);
            this.grpKullaniciAktivasyon.Name = "grpKullaniciAktivasyon";
            this.grpKullaniciAktivasyon.Padding = new System.Windows.Forms.Padding(4);
            this.grpKullaniciAktivasyon.Size = new System.Drawing.Size(560, 438);
            this.grpKullaniciAktivasyon.TabIndex = 21;
            this.grpKullaniciAktivasyon.TabStop = false;
            this.grpKullaniciAktivasyon.Text = "Add Food";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(241, 253);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(121, 28);
            this.cbCategory.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 250);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 20);
            this.label11.TabIndex = 29;
            this.label11.Text = "Category:";
            // 
            // nudGramPortion
            // 
            this.nudGramPortion.Location = new System.Drawing.Point(274, 221);
            this.nudGramPortion.Name = "nudGramPortion";
            this.nudGramPortion.Size = new System.Drawing.Size(88, 26);
            this.nudGramPortion.TabIndex = 28;
            // 
            // nudGramPiece
            // 
            this.nudGramPiece.Location = new System.Drawing.Point(274, 191);
            this.nudGramPiece.Name = "nudGramPiece";
            this.nudGramPiece.Size = new System.Drawing.Size(88, 26);
            this.nudGramPiece.TabIndex = 27;
            // 
            // nudProtein
            // 
            this.nudProtein.Location = new System.Drawing.Point(274, 161);
            this.nudProtein.Name = "nudProtein";
            this.nudProtein.Size = new System.Drawing.Size(88, 26);
            this.nudProtein.TabIndex = 26;
            // 
            // nudCarbs
            // 
            this.nudCarbs.Location = new System.Drawing.Point(274, 131);
            this.nudCarbs.Name = "nudCarbs";
            this.nudCarbs.Size = new System.Drawing.Size(88, 26);
            this.nudCarbs.TabIndex = 25;
            // 
            // nudFat
            // 
            this.nudFat.Location = new System.Drawing.Point(274, 101);
            this.nudFat.Name = "nudFat";
            this.nudFat.Size = new System.Drawing.Size(88, 26);
            this.nudFat.TabIndex = 24;
            // 
            // nudCalorie
            // 
            this.nudCalorie.Location = new System.Drawing.Point(274, 71);
            this.nudCalorie.Name = "nudCalorie";
            this.nudCalorie.Size = new System.Drawing.Size(88, 26);
            this.nudCalorie.TabIndex = 23;
            // 
            // btnUpdateFood
            // 
            this.btnUpdateFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdateFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateFood.Image = global::ProjeTaslak.Properties.Resources.save2;
            this.btnUpdateFood.Location = new System.Drawing.Point(160, 368);
            this.btnUpdateFood.Name = "btnUpdateFood";
            this.btnUpdateFood.Size = new System.Drawing.Size(75, 50);
            this.btnUpdateFood.TabIndex = 22;
            this.btnUpdateFood.UseVisualStyleBackColor = true;
            this.btnUpdateFood.Click += new System.EventHandler(this.btnUpdateFood_Click);
            // 
            // btnAddFood
            // 
            this.btnAddFood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddFood.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddFood.Image = global::ProjeTaslak.Properties.Resources.add2;
            this.btnAddFood.Location = new System.Drawing.Point(66, 368);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(75, 50);
            this.btnAddFood.TabIndex = 21;
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(364, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Foods:";
            // 
            // lvFoods
            // 
            this.lvFoods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.lvFoods.GridLines = true;
            this.lvFoods.HideSelection = false;
            this.lvFoods.Location = new System.Drawing.Point(368, 41);
            this.lvFoods.Name = "lvFoods";
            this.lvFoods.Size = new System.Drawing.Size(180, 305);
            this.lvFoods.TabIndex = 19;
            this.lvFoods.UseCompatibleStateImageBehavior = false;
            this.lvFoods.View = System.Windows.Forms.View.Details;
            this.lvFoods.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvFoods_MouseDoubleClick);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(274, 41);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(88, 26);
            this.txtFoodName.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(260, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "How many grams is one portion ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Image:";
            // 
            // btnChooseFile
            // 
            this.btnChooseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChooseFile.ForeColor = System.Drawing.Color.Transparent;
            this.btnChooseFile.Image = global::ProjeTaslak.Properties.Resources.search_40px;
            this.btnChooseFile.Location = new System.Drawing.Point(285, 306);
            this.btnChooseFile.Name = "btnChooseFile";
            this.btnChooseFile.Size = new System.Drawing.Size(40, 40);
            this.btnChooseFile.TabIndex = 7;
            this.btnChooseFile.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "How many grams is one piece?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Protein% (100g):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Carbs% (100g):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Calorie (100g):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fat% (100g):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "FoodName:";
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(22, 315);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(257, 26);
            this.txtImagePath.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Image = global::ProjeTaslak.Properties.Resources.shutdown_40px;
            this.btnExit.Location = new System.Drawing.Point(925, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 48);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCategoryName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.btnAddCategory);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(33)))), ((int)(((byte)(19)))));
            this.groupBox2.Location = new System.Drawing.Point(4, 513);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(564, 94);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Category";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(153, 42);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(172, 26);
            this.txtCategoryName.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Category Name:";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAddCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Image = global::ProjeTaslak.Properties.Resources.add2;
            this.btnAddCategory.Location = new System.Drawing.Point(473, 26);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(75, 50);
            this.btnAddCategory.TabIndex = 31;
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "First Name";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Last Name";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Username";
            this.columnHeader3.Width = 229;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Status";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Food Name";
            this.columnHeader5.Width = 116;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Status";
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(200)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1103, 625);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.grpKullaniciAktivasyon);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAdminPanel";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpKullaniciAktivasyon.ResumeLayout(false);
            this.grpKullaniciAktivasyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudGramPortion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGramPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProtein)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCalorie)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpKullaniciAktivasyon;
        private System.Windows.Forms.NumericUpDown nudGramPortion;
        private System.Windows.Forms.NumericUpDown nudGramPiece;
        private System.Windows.Forms.NumericUpDown nudProtein;
        private System.Windows.Forms.NumericUpDown nudCarbs;
        private System.Windows.Forms.NumericUpDown nudFat;
        private System.Windows.Forms.NumericUpDown nudCalorie;
        private System.Windows.Forms.Button btnUpdateFood;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lvFoods;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnChooseFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}