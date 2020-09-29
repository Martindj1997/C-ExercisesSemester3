namespace Week1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hourlyPayTB = new System.Windows.Forms.TextBox();
            this.grossPayTB = new System.Windows.Forms.TextBox();
            this.hoursWorkedTB = new System.Windows.Forms.TextBox();
            this.calculateBtn = new System.Windows.Forms.Button();
            this.errorLbl = new System.Windows.Forms.Label();
            this.calculateBtn2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grossPayTB2 = new System.Windows.Forms.TextBox();
            this.hoursWorkedNUD = new System.Windows.Forms.NumericUpDown();
            this.hourlyPayNUD = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPayNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-6, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 445);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorLbl);
            this.tabPage1.Controls.Add(this.calculateBtn);
            this.tabPage1.Controls.Add(this.grossPayTB);
            this.tabPage1.Controls.Add(this.hourlyPayTB);
            this.tabPage1.Controls.Add(this.hoursWorkedTB);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "TextBoxes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.hourlyPayNUD);
            this.tabPage2.Controls.Add(this.hoursWorkedNUD);
            this.tabPage2.Controls.Add(this.grossPayTB2);
            this.tabPage2.Controls.Add(this.calculateBtn2);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(796, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NumericUpDown";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hours Worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Pay:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Gross Pay:";
            // 
            // hourlyPayTB
            // 
            this.hourlyPayTB.Location = new System.Drawing.Point(144, 72);
            this.hourlyPayTB.Name = "hourlyPayTB";
            this.hourlyPayTB.Size = new System.Drawing.Size(100, 20);
            this.hourlyPayTB.TabIndex = 4;
            // 
            // grossPayTB
            // 
            this.grossPayTB.Location = new System.Drawing.Point(144, 104);
            this.grossPayTB.Name = "grossPayTB";
            this.grossPayTB.ReadOnly = true;
            this.grossPayTB.Size = new System.Drawing.Size(100, 20);
            this.grossPayTB.TabIndex = 5;
            // 
            // hoursWorkedTB
            // 
            this.hoursWorkedTB.Location = new System.Drawing.Point(144, 40);
            this.hoursWorkedTB.Name = "hoursWorkedTB";
            this.hoursWorkedTB.Size = new System.Drawing.Size(100, 20);
            this.hoursWorkedTB.TabIndex = 3;
            // 
            // calculateBtn
            // 
            this.calculateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn.Location = new System.Drawing.Point(144, 145);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(100, 42);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Calculate";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.BackColor = System.Drawing.Color.Red;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.Location = new System.Drawing.Point(144, 217);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 20);
            this.errorLbl.TabIndex = 7;
            // 
            // calculateBtn2
            // 
            this.calculateBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateBtn2.Location = new System.Drawing.Point(126, 152);
            this.calculateBtn2.Name = "calculateBtn2";
            this.calculateBtn2.Size = new System.Drawing.Size(100, 42);
            this.calculateBtn2.TabIndex = 10;
            this.calculateBtn2.Text = "Calculate";
            this.calculateBtn2.UseVisualStyleBackColor = true;
            this.calculateBtn2.Click += new System.EventHandler(this.calculateBtn2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gross Pay:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Hourly Pay:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hours Worked:";
            // 
            // grossPayTB2
            // 
            this.grossPayTB2.Location = new System.Drawing.Point(135, 111);
            this.grossPayTB2.Name = "grossPayTB2";
            this.grossPayTB2.ReadOnly = true;
            this.grossPayTB2.Size = new System.Drawing.Size(100, 20);
            this.grossPayTB2.TabIndex = 11;
            // 
            // hoursWorkedNUD
            // 
            this.hoursWorkedNUD.DecimalPlaces = 2;
            this.hoursWorkedNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursWorkedNUD.Location = new System.Drawing.Point(135, 44);
            this.hoursWorkedNUD.Name = "hoursWorkedNUD";
            this.hoursWorkedNUD.Size = new System.Drawing.Size(120, 26);
            this.hoursWorkedNUD.TabIndex = 12;
            // 
            // hourlyPayNUD
            // 
            this.hourlyPayNUD.DecimalPlaces = 2;
            this.hourlyPayNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hourlyPayNUD.Location = new System.Drawing.Point(135, 75);
            this.hourlyPayNUD.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.hourlyPayNUD.Minimum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.hourlyPayNUD.Name = "hourlyPayNUD";
            this.hourlyPayNUD.Size = new System.Drawing.Size(120, 26);
            this.hourlyPayNUD.TabIndex = 13;
            this.hourlyPayNUD.Value = new decimal(new int[] {
            14,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "COMP 10204 - Week1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursWorkedNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourlyPayNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button calculateBtn;
        private System.Windows.Forms.TextBox grossPayTB;
        private System.Windows.Forms.TextBox hourlyPayTB;
        private System.Windows.Forms.TextBox hoursWorkedTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.NumericUpDown hourlyPayNUD;
        private System.Windows.Forms.NumericUpDown hoursWorkedNUD;
        private System.Windows.Forms.TextBox grossPayTB2;
        private System.Windows.Forms.Button calculateBtn2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

