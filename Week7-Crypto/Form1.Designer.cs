namespace Week7_Crypto
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
            this.asciiTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.genBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.rawTB = new System.Windows.Forms.TextBox();
            this.encryptedTB = new System.Windows.Forms.TextBox();
            this.decryptedTB = new System.Windows.Forms.TextBox();
            this.hashedTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hashedAndSaltedTB = new System.Windows.Forms.TextBox();
            this.hashBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // asciiTB
            // 
            this.asciiTB.Location = new System.Drawing.Point(52, 51);
            this.asciiTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.asciiTB.Multiline = true;
            this.asciiTB.Name = "asciiTB";
            this.asciiTB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.asciiTB.Size = new System.Drawing.Size(780, 443);
            this.asciiTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "The ASCII Table";
            // 
            // genBtn
            // 
            this.genBtn.Location = new System.Drawing.Point(56, 519);
            this.genBtn.Name = "genBtn";
            this.genBtn.Size = new System.Drawing.Size(105, 37);
            this.genBtn.TabIndex = 2;
            this.genBtn.Text = "Generate";
            this.genBtn.UseVisualStyleBackColor = true;
            this.genBtn.Click += new System.EventHandler(this.genBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(56, 705);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(105, 37);
            this.encryptBtn.TabIndex = 3;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(325, 705);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(105, 37);
            this.decryptBtn.TabIndex = 4;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // rawTB
            // 
            this.rawTB.Location = new System.Drawing.Point(56, 578);
            this.rawTB.Name = "rawTB";
            this.rawTB.Size = new System.Drawing.Size(374, 26);
            this.rawTB.TabIndex = 5;
            // 
            // encryptedTB
            // 
            this.encryptedTB.Location = new System.Drawing.Point(56, 611);
            this.encryptedTB.Name = "encryptedTB";
            this.encryptedTB.Size = new System.Drawing.Size(374, 26);
            this.encryptedTB.TabIndex = 6;
            // 
            // decryptedTB
            // 
            this.decryptedTB.Location = new System.Drawing.Point(56, 650);
            this.decryptedTB.Name = "decryptedTB";
            this.decryptedTB.ReadOnly = true;
            this.decryptedTB.Size = new System.Drawing.Size(374, 26);
            this.decryptedTB.TabIndex = 7;
            // 
            // hashedTB
            // 
            this.hashedTB.Location = new System.Drawing.Point(674, 611);
            this.hashedTB.Name = "hashedTB";
            this.hashedTB.Size = new System.Drawing.Size(460, 26);
            this.hashedTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(500, 614);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Hashed Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(489, 653);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Hashed && Salted Value:";
            // 
            // hashedAndSaltedTB
            // 
            this.hashedAndSaltedTB.Location = new System.Drawing.Point(674, 650);
            this.hashedAndSaltedTB.Name = "hashedAndSaltedTB";
            this.hashedAndSaltedTB.Size = new System.Drawing.Size(460, 26);
            this.hashedAndSaltedTB.TabIndex = 10;
            // 
            // hashBtn
            // 
            this.hashBtn.Location = new System.Drawing.Point(660, 705);
            this.hashBtn.Name = "hashBtn";
            this.hashBtn.Size = new System.Drawing.Size(105, 37);
            this.hashBtn.TabIndex = 12;
            this.hashBtn.Text = "Hash";
            this.hashBtn.UseVisualStyleBackColor = true;
            this.hashBtn.Click += new System.EventHandler(this.hashBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 785);
            this.Controls.Add(this.hashBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.hashedAndSaltedTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hashedTB);
            this.Controls.Add(this.decryptedTB);
            this.Controls.Add(this.encryptedTB);
            this.Controls.Add(this.rawTB);
            this.Controls.Add(this.decryptBtn);
            this.Controls.Add(this.encryptBtn);
            this.Controls.Add(this.genBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.asciiTB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "It\'s All 1\'s and 0\'s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox asciiTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genBtn;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.TextBox rawTB;
        private System.Windows.Forms.TextBox encryptedTB;
        private System.Windows.Forms.TextBox decryptedTB;
        private System.Windows.Forms.TextBox hashedTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hashedAndSaltedTB;
        private System.Windows.Forms.Button hashBtn;
    }
}

