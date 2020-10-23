namespace Week4B_BankAccountMgr
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
            this.label1 = new System.Windows.Forms.Label();
            this.firstTB = new System.Windows.Forms.TextBox();
            this.lastTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.savingsRB = new System.Windows.Forms.RadioButton();
            this.chequingRB = new System.Windows.Forms.RadioButton();
            this.createBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.resultLbl = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.amountNUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.depositRB = new System.Windows.Forms.RadioButton();
            this.withdrawRB = new System.Windows.Forms.RadioButton();
            this.transactionsLB = new System.Windows.Forms.ListBox();
            this.accountsLB = new System.Windows.Forms.ListBox();
            this.balanceTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.caTB = new System.Windows.Forms.TextBox();
            this.saTB = new System.Windows.Forms.TextBox();
            this.overTB = new System.Windows.Forms.TextBox();
            this.interestTB = new System.Windows.Forms.TextBox();
            this.branchBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // firstTB
            // 
            this.firstTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstTB.Location = new System.Drawing.Point(101, 17);
            this.firstTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.firstTB.Name = "firstTB";
            this.firstTB.Size = new System.Drawing.Size(148, 26);
            this.firstTB.TabIndex = 1;
            // 
            // lastTB
            // 
            this.lastTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastTB.Location = new System.Drawing.Point(368, 17);
            this.lastTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lastTB.Name = "lastTB";
            this.lastTB.Size = new System.Drawing.Size(148, 26);
            this.lastTB.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingsRB);
            this.groupBox1.Controls.Add(this.chequingRB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(300, 106);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Type";
            // 
            // savingsRB
            // 
            this.savingsRB.AutoSize = true;
            this.savingsRB.Location = new System.Drawing.Point(10, 68);
            this.savingsRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.savingsRB.Name = "savingsRB";
            this.savingsRB.Size = new System.Drawing.Size(146, 24);
            this.savingsRB.TabIndex = 1;
            this.savingsRB.Text = "Savings Account";
            this.savingsRB.UseVisualStyleBackColor = true;
            // 
            // chequingRB
            // 
            this.chequingRB.AutoSize = true;
            this.chequingRB.Checked = true;
            this.chequingRB.Location = new System.Drawing.Point(10, 31);
            this.chequingRB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chequingRB.Name = "chequingRB";
            this.chequingRB.Size = new System.Drawing.Size(158, 24);
            this.chequingRB.TabIndex = 0;
            this.chequingRB.TabStop = true;
            this.chequingRB.Text = "Chequing Account";
            this.chequingRB.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(27, 187);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(93, 31);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Enabled = false;
            this.clearBtn.Location = new System.Drawing.Point(171, 187);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(93, 31);
            this.clearBtn.TabIndex = 6;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultLbl);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.transactionsLB);
            this.groupBox2.Controls.Add(this.accountsLB);
            this.groupBox2.Controls.Add(this.balanceTB);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.numberTB);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(17, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(822, 371);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Account Information";
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.ForeColor = System.Drawing.Color.Green;
            this.resultLbl.Location = new System.Drawing.Point(17, 345);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(204, 20);
            this.resultLbl.TabIndex = 9;
            this.resultLbl.Text = "Last Transaction Status OK";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.addBtn);
            this.groupBox3.Controls.Add(this.amountNUD);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.depositRB);
            this.groupBox3.Controls.Add(this.withdrawRB);
            this.groupBox3.Location = new System.Drawing.Point(500, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(316, 132);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Transaction";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(90, 92);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(133, 31);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "Add Transaction";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // amountNUD
            // 
            this.amountNUD.DecimalPlaces = 2;
            this.amountNUD.Location = new System.Drawing.Point(139, 57);
            this.amountNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.amountNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.amountNUD.Name = "amountNUD";
            this.amountNUD.Size = new System.Drawing.Size(120, 26);
            this.amountNUD.TabIndex = 3;
            this.amountNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Amount:";
            // 
            // depositRB
            // 
            this.depositRB.AutoSize = true;
            this.depositRB.Location = new System.Drawing.Point(7, 57);
            this.depositRB.Name = "depositRB";
            this.depositRB.Size = new System.Drawing.Size(82, 24);
            this.depositRB.TabIndex = 1;
            this.depositRB.Text = "Deposit";
            this.depositRB.UseVisualStyleBackColor = true;
            // 
            // withdrawRB
            // 
            this.withdrawRB.AutoSize = true;
            this.withdrawRB.Checked = true;
            this.withdrawRB.Location = new System.Drawing.Point(7, 26);
            this.withdrawRB.Name = "withdrawRB";
            this.withdrawRB.Size = new System.Drawing.Size(93, 24);
            this.withdrawRB.TabIndex = 0;
            this.withdrawRB.TabStop = true;
            this.withdrawRB.Text = "Withdraw";
            this.withdrawRB.UseVisualStyleBackColor = true;
            // 
            // transactionsLB
            // 
            this.transactionsLB.FormattingEnabled = true;
            this.transactionsLB.ItemHeight = 20;
            this.transactionsLB.Location = new System.Drawing.Point(17, 209);
            this.transactionsLB.Name = "transactionsLB";
            this.transactionsLB.Size = new System.Drawing.Size(477, 124);
            this.transactionsLB.TabIndex = 7;
            // 
            // accountsLB
            // 
            this.accountsLB.FormattingEnabled = true;
            this.accountsLB.ItemHeight = 20;
            this.accountsLB.Location = new System.Drawing.Point(17, 79);
            this.accountsLB.Name = "accountsLB";
            this.accountsLB.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.accountsLB.Size = new System.Drawing.Size(477, 124);
            this.accountsLB.TabIndex = 6;
            this.accountsLB.SelectedIndexChanged += new System.EventHandler(this.accountsLB_SelectedIndexChanged);
            // 
            // balanceTB
            // 
            this.balanceTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balanceTB.Location = new System.Drawing.Point(405, 35);
            this.balanceTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balanceTB.Name = "balanceTB";
            this.balanceTB.ReadOnly = true;
            this.balanceTB.Size = new System.Drawing.Size(148, 26);
            this.balanceTB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Balance:";
            // 
            // numberTB
            // 
            this.numberTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTB.Location = new System.Drawing.Point(143, 35);
            this.numberTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numberTB.Name = "numberTB";
            this.numberTB.ReadOnly = true;
            this.numberTB.Size = new System.Drawing.Size(148, 26);
            this.numberTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Number:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.branchBtn);
            this.groupBox4.Controls.Add(this.interestTB);
            this.groupBox4.Controls.Add(this.overTB);
            this.groupBox4.Controls.Add(this.saTB);
            this.groupBox4.Controls.Add(this.caTB);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(524, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(315, 217);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Branch Information";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Chequing Accts:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Savings Accts:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Overdraft Fees:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Interest Due:";
            // 
            // caTB
            // 
            this.caTB.Location = new System.Drawing.Point(148, 32);
            this.caTB.Name = "caTB";
            this.caTB.ReadOnly = true;
            this.caTB.Size = new System.Drawing.Size(100, 26);
            this.caTB.TabIndex = 4;
            // 
            // saTB
            // 
            this.saTB.Location = new System.Drawing.Point(148, 71);
            this.saTB.Name = "saTB";
            this.saTB.ReadOnly = true;
            this.saTB.Size = new System.Drawing.Size(100, 26);
            this.saTB.TabIndex = 5;
            // 
            // overTB
            // 
            this.overTB.Location = new System.Drawing.Point(148, 110);
            this.overTB.Name = "overTB";
            this.overTB.ReadOnly = true;
            this.overTB.Size = new System.Drawing.Size(100, 26);
            this.overTB.TabIndex = 6;
            // 
            // interestTB
            // 
            this.interestTB.Location = new System.Drawing.Point(148, 149);
            this.interestTB.Name = "interestTB";
            this.interestTB.ReadOnly = true;
            this.interestTB.Size = new System.Drawing.Size(100, 26);
            this.interestTB.TabIndex = 7;
            // 
            // branchBtn
            // 
            this.branchBtn.Location = new System.Drawing.Point(116, 181);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(91, 30);
            this.branchBtn.TabIndex = 8;
            this.branchBtn.Text = "Update";
            this.branchBtn.UseVisualStyleBackColor = true;
            this.branchBtn.Click += new System.EventHandler(this.branchBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 619);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lastTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Bank Account Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountNUD)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstTB;
        private System.Windows.Forms.TextBox lastTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton savingsRB;
        private System.Windows.Forms.RadioButton chequingRB;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.NumericUpDown amountNUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton depositRB;
        private System.Windows.Forms.RadioButton withdrawRB;
        private System.Windows.Forms.ListBox transactionsLB;
        private System.Windows.Forms.ListBox accountsLB;
        private System.Windows.Forms.TextBox balanceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button branchBtn;
        private System.Windows.Forms.TextBox interestTB;
        private System.Windows.Forms.TextBox overTB;
        private System.Windows.Forms.TextBox saTB;
        private System.Windows.Forms.TextBox caTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

