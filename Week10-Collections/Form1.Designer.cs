
namespace Week10_Collections
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
            this.carsLB = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.stackTB = new System.Windows.Forms.TextBox();
            this.QueueTB = new System.Windows.Forms.TextBox();
            this.indexNUD = new System.Windows.Forms.NumericUpDown();
            this.dictionaryTB = new System.Windows.Forms.TextBox();
            this.listTB = new System.Windows.Forms.TextBox();
            this.nextBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.indexNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // carsLB
            // 
            this.carsLB.FormattingEnabled = true;
            this.carsLB.ItemHeight = 24;
            this.carsLB.Location = new System.Drawing.Point(13, 13);
            this.carsLB.Name = "carsLB";
            this.carsLB.Size = new System.Drawing.Size(430, 436);
            this.carsLB.TabIndex = 0;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(13, 469);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(96, 36);
            this.loadBtn.TabIndex = 1;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(524, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stack<Car>:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Queue<Car>:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Index:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Dictionary<int, Car>:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "List<Car>:";
            // 
            // stackTB
            // 
            this.stackTB.Location = new System.Drawing.Point(653, 61);
            this.stackTB.Name = "stackTB";
            this.stackTB.ReadOnly = true;
            this.stackTB.Size = new System.Drawing.Size(280, 29);
            this.stackTB.TabIndex = 7;
            // 
            // QueueTB
            // 
            this.QueueTB.Location = new System.Drawing.Point(653, 121);
            this.QueueTB.Name = "QueueTB";
            this.QueueTB.ReadOnly = true;
            this.QueueTB.Size = new System.Drawing.Size(280, 29);
            this.QueueTB.TabIndex = 8;
            // 
            // indexNUD
            // 
            this.indexNUD.Location = new System.Drawing.Point(653, 182);
            this.indexNUD.Name = "indexNUD";
            this.indexNUD.Size = new System.Drawing.Size(100, 29);
            this.indexNUD.TabIndex = 9;
            // 
            // dictionaryTB
            // 
            this.dictionaryTB.Location = new System.Drawing.Point(653, 241);
            this.dictionaryTB.Name = "dictionaryTB";
            this.dictionaryTB.ReadOnly = true;
            this.dictionaryTB.Size = new System.Drawing.Size(280, 29);
            this.dictionaryTB.TabIndex = 10;
            // 
            // listTB
            // 
            this.listTB.Location = new System.Drawing.Point(653, 299);
            this.listTB.Name = "listTB";
            this.listTB.ReadOnly = true;
            this.listTB.Size = new System.Drawing.Size(280, 29);
            this.listTB.TabIndex = 11;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(939, 84);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(96, 36);
            this.nextBtn.TabIndex = 12;
            this.nextBtn.Text = "Next";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(939, 175);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(96, 36);
            this.findBtn.TabIndex = 13;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 525);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.listTB);
            this.Controls.Add(this.dictionaryTB);
            this.Controls.Add(this.indexNUD);
            this.Controls.Add(this.QueueTB);
            this.Controls.Add(this.stackTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.carsLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.indexNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox carsLB;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stackTB;
        private System.Windows.Forms.TextBox QueueTB;
        private System.Windows.Forms.NumericUpDown indexNUD;
        private System.Windows.Forms.TextBox dictionaryTB;
        private System.Windows.Forms.TextBox listTB;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

