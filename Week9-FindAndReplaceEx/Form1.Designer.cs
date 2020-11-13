namespace Week9_FindAndReplaceEx
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
            this.storyTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findTB = new System.Windows.Forms.TextBox();
            this.replaceTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.findBtn = new System.Windows.Forms.Button();
            this.findNextBtn = new System.Windows.Forms.Button();
            this.replaceBtn = new System.Windows.Forms.Button();
            this.replaceAllBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // storyTB
            // 
            this.storyTB.HideSelection = false;
            this.storyTB.Location = new System.Drawing.Point(13, 13);
            this.storyTB.Multiline = true;
            this.storyTB.Name = "storyTB";
            this.storyTB.Size = new System.Drawing.Size(1131, 475);
            this.storyTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find:";
            // 
            // findTB
            // 
            this.findTB.Location = new System.Drawing.Point(76, 515);
            this.findTB.Name = "findTB";
            this.findTB.Size = new System.Drawing.Size(158, 26);
            this.findTB.TabIndex = 2;
            // 
            // replaceTB
            // 
            this.replaceTB.Location = new System.Drawing.Point(378, 514);
            this.replaceTB.Name = "replaceTB";
            this.replaceTB.Size = new System.Drawing.Size(139, 26);
            this.replaceTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(295, 515);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace:";
            // 
            // findBtn
            // 
            this.findBtn.Location = new System.Drawing.Point(13, 575);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(101, 48);
            this.findBtn.TabIndex = 5;
            this.findBtn.Text = "Find";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.findBtn_Click);
            // 
            // findNextBtn
            // 
            this.findNextBtn.Location = new System.Drawing.Point(133, 575);
            this.findNextBtn.Name = "findNextBtn";
            this.findNextBtn.Size = new System.Drawing.Size(101, 48);
            this.findNextBtn.TabIndex = 6;
            this.findNextBtn.Text = "Find Next";
            this.findNextBtn.UseVisualStyleBackColor = true;
            this.findNextBtn.Click += new System.EventHandler(this.findNextBtn_Click);
            // 
            // replaceBtn
            // 
            this.replaceBtn.Location = new System.Drawing.Point(299, 575);
            this.replaceBtn.Name = "replaceBtn";
            this.replaceBtn.Size = new System.Drawing.Size(101, 48);
            this.replaceBtn.TabIndex = 7;
            this.replaceBtn.Text = "Replace";
            this.replaceBtn.UseVisualStyleBackColor = true;
            this.replaceBtn.Click += new System.EventHandler(this.replaceBtn_Click);
            // 
            // replaceAllBtn
            // 
            this.replaceAllBtn.Location = new System.Drawing.Point(416, 575);
            this.replaceAllBtn.Name = "replaceAllBtn";
            this.replaceAllBtn.Size = new System.Drawing.Size(101, 48);
            this.replaceAllBtn.TabIndex = 8;
            this.replaceAllBtn.Text = "Replace All";
            this.replaceAllBtn.UseVisualStyleBackColor = true;
            this.replaceAllBtn.Click += new System.EventHandler(this.replaceAllBtn_Click);
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(980, 503);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(101, 48);
            this.resetBtn.TabIndex = 9;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.resetBtn);
            this.Controls.Add(this.replaceAllBtn);
            this.Controls.Add(this.replaceBtn);
            this.Controls.Add(this.findNextBtn);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.replaceTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.findTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storyTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox storyTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox findTB;
        private System.Windows.Forms.TextBox replaceTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Button findNextBtn;
        private System.Windows.Forms.Button replaceBtn;
        private System.Windows.Forms.Button replaceAllBtn;
        private System.Windows.Forms.Button resetBtn;
    }
}

