
namespace Week12B_CHDB
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
            this.medsLB = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.defaultRB = new System.Windows.Forms.RadioButton();
            this.descRB = new System.Windows.Forms.RadioButton();
            this.costRB = new System.Windows.Forms.RadioButton();
            this.lastRB = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.descTB = new System.Windows.Forms.TextBox();
            this.costNUD = new System.Windows.Forms.NumericUpDown();
            this.lastDTP = new System.Windows.Forms.DateTimePicker();
            this.lastBtn = new System.Windows.Forms.Button();
            this.applyBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // medsLB
            // 
            this.medsLB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medsLB.FormattingEnabled = true;
            this.medsLB.ItemHeight = 18;
            this.medsLB.Location = new System.Drawing.Point(12, 24);
            this.medsLB.Name = "medsLB";
            this.medsLB.Size = new System.Drawing.Size(1059, 472);
            this.medsLB.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(12, 525);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(111, 45);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(1077, 176);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(111, 45);
            this.updateBtn.TabIndex = 2;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lastRB);
            this.groupBox1.Controls.Add(this.costRB);
            this.groupBox1.Controls.Add(this.descRB);
            this.groupBox1.Controls.Add(this.defaultRB);
            this.groupBox1.Location = new System.Drawing.Point(143, 519);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 161);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Order";
            // 
            // defaultRB
            // 
            this.defaultRB.AutoSize = true;
            this.defaultRB.Location = new System.Drawing.Point(37, 27);
            this.defaultRB.Name = "defaultRB";
            this.defaultRB.Size = new System.Drawing.Size(79, 24);
            this.defaultRB.TabIndex = 0;
            this.defaultRB.TabStop = true;
            this.defaultRB.Text = "Default";
            this.defaultRB.UseVisualStyleBackColor = true;
            // 
            // descRB
            // 
            this.descRB.AutoSize = true;
            this.descRB.Location = new System.Drawing.Point(37, 57);
            this.descRB.Name = "descRB";
            this.descRB.Size = new System.Drawing.Size(107, 24);
            this.descRB.TabIndex = 1;
            this.descRB.TabStop = true;
            this.descRB.Text = "Description";
            this.descRB.UseVisualStyleBackColor = true;
            // 
            // costRB
            // 
            this.costRB.AutoSize = true;
            this.costRB.Location = new System.Drawing.Point(37, 87);
            this.costRB.Name = "costRB";
            this.costRB.Size = new System.Drawing.Size(60, 24);
            this.costRB.TabIndex = 2;
            this.costRB.TabStop = true;
            this.costRB.Text = "Cost";
            this.costRB.UseVisualStyleBackColor = true;
            // 
            // lastRB
            // 
            this.lastRB.AutoSize = true;
            this.lastRB.Location = new System.Drawing.Point(37, 118);
            this.lastRB.Name = "lastRB";
            this.lastRB.Size = new System.Drawing.Size(100, 24);
            this.lastRB.TabIndex = 3;
            this.lastRB.TabStop = true;
            this.lastRB.Text = "Last Used";
            this.lastRB.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lastBtn);
            this.groupBox2.Controls.Add(this.lastDTP);
            this.groupBox2.Controls.Add(this.costNUD);
            this.groupBox2.Controls.Add(this.descTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(503, 519);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(568, 161);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Min Cost:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Used:";
            // 
            // descTB
            // 
            this.descTB.Location = new System.Drawing.Point(115, 34);
            this.descTB.Name = "descTB";
            this.descTB.Size = new System.Drawing.Size(120, 26);
            this.descTB.TabIndex = 3;
            // 
            // costNUD
            // 
            this.costNUD.Location = new System.Drawing.Point(115, 75);
            this.costNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.costNUD.Name = "costNUD";
            this.costNUD.Size = new System.Drawing.Size(120, 26);
            this.costNUD.TabIndex = 4;
            // 
            // lastDTP
            // 
            this.lastDTP.Location = new System.Drawing.Point(115, 117);
            this.lastDTP.Name = "lastDTP";
            this.lastDTP.Size = new System.Drawing.Size(284, 26);
            this.lastDTP.TabIndex = 5;
            this.lastDTP.Value = new System.DateTime(1990, 12, 8, 12, 8, 0, 0);
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(451, 17);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(111, 45);
            this.lastBtn.TabIndex = 5;
            this.lastBtn.Text = "Last 10";
            this.lastBtn.UseVisualStyleBackColor = true;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(376, 534);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(111, 45);
            this.applyBtn.TabIndex = 5;
            this.applyBtn.Text = "Apply";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(376, 596);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(111, 45);
            this.resetBtn.TabIndex = 6;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.medsLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.costNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox medsLB;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton lastRB;
        private System.Windows.Forms.RadioButton costRB;
        private System.Windows.Forms.RadioButton descRB;
        private System.Windows.Forms.RadioButton defaultRB;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.DateTimePicker lastDTP;
        private System.Windows.Forms.NumericUpDown costNUD;
        private System.Windows.Forms.TextBox descTB;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

