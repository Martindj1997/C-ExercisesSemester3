
namespace Week10_LambdaSorting
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
            this.studentLB = new System.Windows.Forms.ListBox();
            this.lastBtn = new System.Windows.Forms.Button();
            this.grade1Btn = new System.Windows.Forms.Button();
            this.grade2Btn = new System.Windows.Forms.Button();
            this.averageBtn = new System.Windows.Forms.Button();
            this.grade12Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentLB
            // 
            this.studentLB.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentLB.FormattingEnabled = true;
            this.studentLB.ItemHeight = 21;
            this.studentLB.Location = new System.Drawing.Point(13, 13);
            this.studentLB.Name = "studentLB";
            this.studentLB.Size = new System.Drawing.Size(1119, 508);
            this.studentLB.TabIndex = 0;
            // 
            // lastBtn
            // 
            this.lastBtn.Location = new System.Drawing.Point(41, 541);
            this.lastBtn.Name = "lastBtn";
            this.lastBtn.Size = new System.Drawing.Size(147, 62);
            this.lastBtn.TabIndex = 1;
            this.lastBtn.Text = "Sort by Last Name";
            this.lastBtn.UseVisualStyleBackColor = true;
            this.lastBtn.Click += new System.EventHandler(this.lastBtn_Click);
            // 
            // grade1Btn
            // 
            this.grade1Btn.Location = new System.Drawing.Point(227, 541);
            this.grade1Btn.Name = "grade1Btn";
            this.grade1Btn.Size = new System.Drawing.Size(147, 62);
            this.grade1Btn.TabIndex = 2;
            this.grade1Btn.Text = "Sort by Grade1";
            this.grade1Btn.UseVisualStyleBackColor = true;
            this.grade1Btn.Click += new System.EventHandler(this.grade1Btn_Click);
            // 
            // grade2Btn
            // 
            this.grade2Btn.Location = new System.Drawing.Point(413, 541);
            this.grade2Btn.Name = "grade2Btn";
            this.grade2Btn.Size = new System.Drawing.Size(147, 62);
            this.grade2Btn.TabIndex = 3;
            this.grade2Btn.Text = "Sort by Grade2";
            this.grade2Btn.UseVisualStyleBackColor = true;
            this.grade2Btn.Click += new System.EventHandler(this.grade2Btn_Click);
            // 
            // averageBtn
            // 
            this.averageBtn.Location = new System.Drawing.Point(599, 541);
            this.averageBtn.Name = "averageBtn";
            this.averageBtn.Size = new System.Drawing.Size(147, 62);
            this.averageBtn.TabIndex = 4;
            this.averageBtn.Text = "Sort by Average";
            this.averageBtn.UseVisualStyleBackColor = true;
            this.averageBtn.Click += new System.EventHandler(this.averageBtn_Click);
            // 
            // grade12Btn
            // 
            this.grade12Btn.Location = new System.Drawing.Point(785, 541);
            this.grade12Btn.Name = "grade12Btn";
            this.grade12Btn.Size = new System.Drawing.Size(147, 62);
            this.grade12Btn.TabIndex = 5;
            this.grade12Btn.Text = "Sort by Gr1 then Gr2";
            this.grade12Btn.UseVisualStyleBackColor = true;
            this.grade12Btn.Click += new System.EventHandler(this.grade12Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 624);
            this.Controls.Add(this.grade12Btn);
            this.Controls.Add(this.averageBtn);
            this.Controls.Add(this.grade2Btn);
            this.Controls.Add(this.grade1Btn);
            this.Controls.Add(this.lastBtn);
            this.Controls.Add(this.studentLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentLB;
        private System.Windows.Forms.Button lastBtn;
        private System.Windows.Forms.Button grade1Btn;
        private System.Windows.Forms.Button grade2Btn;
        private System.Windows.Forms.Button averageBtn;
        private System.Windows.Forms.Button grade12Btn;
    }
}

