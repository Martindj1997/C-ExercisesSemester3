namespace Week4A
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.adultRB = new System.Windows.Forms.RadioButton();
            this.childRB = new System.Windows.Forms.RadioButton();
            this.studentRB = new System.Windows.Forms.RadioButton();
            this.seniorRB = new System.Windows.Forms.RadioButton();
            this.yogaCB = new System.Windows.Forms.CheckBox();
            this.karateCB = new System.Windows.Forms.CheckBox();
            this.trainerCB = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthsNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.monthlyFeeTB = new System.Windows.Forms.TextBox();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seniorRB);
            this.groupBox1.Controls.Add(this.studentRB);
            this.groupBox1.Controls.Add(this.childRB);
            this.groupBox1.Controls.Add(this.adultRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Membership";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.trainerCB);
            this.groupBox2.Controls.Add(this.karateCB);
            this.groupBox2.Controls.Add(this.yogaCB);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(314, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Options";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.monthsNUD);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 199);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(296, 138);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Membership Length";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.totalTB);
            this.groupBox4.Controls.Add(this.monthlyFeeTB);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(314, 199);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(232, 138);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membership Fees";
            // 
            // adultRB
            // 
            this.adultRB.AutoSize = true;
            this.adultRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adultRB.Location = new System.Drawing.Point(7, 29);
            this.adultRB.Name = "adultRB";
            this.adultRB.Size = new System.Drawing.Size(134, 24);
            this.adultRB.TabIndex = 0;
            this.adultRB.TabStop = true;
            this.adultRB.Text = "Standard Adult";
            this.adultRB.UseVisualStyleBackColor = true;
            // 
            // childRB
            // 
            this.childRB.AutoSize = true;
            this.childRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.childRB.Location = new System.Drawing.Point(7, 59);
            this.childRB.Name = "childRB";
            this.childRB.Size = new System.Drawing.Size(154, 24);
            this.childRB.TabIndex = 1;
            this.childRB.TabStop = true;
            this.childRB.Text = "Child (12 && under)";
            this.childRB.UseVisualStyleBackColor = true;
            // 
            // studentRB
            // 
            this.studentRB.AutoSize = true;
            this.studentRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRB.Location = new System.Drawing.Point(7, 89);
            this.studentRB.Name = "studentRB";
            this.studentRB.Size = new System.Drawing.Size(84, 24);
            this.studentRB.TabIndex = 2;
            this.studentRB.TabStop = true;
            this.studentRB.Text = "Student";
            this.studentRB.UseVisualStyleBackColor = true;
            // 
            // seniorRB
            // 
            this.seniorRB.AutoSize = true;
            this.seniorRB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seniorRB.Location = new System.Drawing.Point(7, 119);
            this.seniorRB.Name = "seniorRB";
            this.seniorRB.Size = new System.Drawing.Size(125, 24);
            this.seniorRB.TabIndex = 3;
            this.seniorRB.TabStop = true;
            this.seniorRB.Text = "Senior Citizen";
            this.seniorRB.UseVisualStyleBackColor = true;
            // 
            // yogaCB
            // 
            this.yogaCB.AutoSize = true;
            this.yogaCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yogaCB.Location = new System.Drawing.Point(20, 29);
            this.yogaCB.Name = "yogaCB";
            this.yogaCB.Size = new System.Drawing.Size(66, 24);
            this.yogaCB.TabIndex = 0;
            this.yogaCB.Text = "Yoga";
            this.yogaCB.UseVisualStyleBackColor = true;
            // 
            // karateCB
            // 
            this.karateCB.AutoSize = true;
            this.karateCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karateCB.Location = new System.Drawing.Point(20, 60);
            this.karateCB.Name = "karateCB";
            this.karateCB.Size = new System.Drawing.Size(75, 24);
            this.karateCB.TabIndex = 1;
            this.karateCB.Text = "Karate";
            this.karateCB.UseVisualStyleBackColor = true;
            // 
            // trainerCB
            // 
            this.trainerCB.AutoSize = true;
            this.trainerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerCB.Location = new System.Drawing.Point(20, 90);
            this.trainerCB.Name = "trainerCB";
            this.trainerCB.Size = new System.Drawing.Size(143, 24);
            this.trainerCB.TabIndex = 2;
            this.trainerCB.Text = "Personal Trainer";
            this.trainerCB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the Number of Months:";
            // 
            // monthsNUD
            // 
            this.monthsNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthsNUD.Location = new System.Drawing.Point(7, 82);
            this.monthsNUD.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.monthsNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.monthsNUD.Name = "monthsNUD";
            this.monthsNUD.Size = new System.Drawing.Size(120, 26);
            this.monthsNUD.TabIndex = 1;
            this.monthsNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Fee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Total:";
            // 
            // monthlyFeeTB
            // 
            this.monthlyFeeTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyFeeTB.Location = new System.Drawing.Point(122, 40);
            this.monthlyFeeTB.Name = "monthlyFeeTB";
            this.monthlyFeeTB.ReadOnly = true;
            this.monthlyFeeTB.Size = new System.Drawing.Size(100, 26);
            this.monthlyFeeTB.TabIndex = 2;
            // 
            // totalTB
            // 
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.Location = new System.Drawing.Point(122, 82);
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(100, 26);
            this.totalTB.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.AutoSize = true;
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(79, 360);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(119, 34);
            this.calculateBtn.TabIndex = 4;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.AutoSize = true;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(225, 360);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(119, 34);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.AutoSize = true;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(370, 360);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(119, 34);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 409);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Membership Fee Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monthsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton seniorRB;
        private System.Windows.Forms.RadioButton studentRB;
        private System.Windows.Forms.RadioButton childRB;
        private System.Windows.Forms.RadioButton adultRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox trainerCB;
        private System.Windows.Forms.CheckBox karateCB;
        private System.Windows.Forms.CheckBox yogaCB;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown monthsNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.TextBox monthlyFeeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

