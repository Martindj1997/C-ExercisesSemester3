
namespace Week13B_CHDBWithJoin
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
            this.vendorItemsLB = new System.Windows.Forms.ListBox();
            this.vendorItemsLLB = new System.Windows.Forms.ListBox();
            this.loadBtn = new System.Windows.Forms.Button();
            this.filterBtn = new System.Windows.Forms.Button();
            this.costNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.costNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // vendorItemsLB
            // 
            this.vendorItemsLB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorItemsLB.FormattingEnabled = true;
            this.vendorItemsLB.ItemHeight = 18;
            this.vendorItemsLB.Location = new System.Drawing.Point(13, 30);
            this.vendorItemsLB.Name = "vendorItemsLB";
            this.vendorItemsLB.Size = new System.Drawing.Size(590, 508);
            this.vendorItemsLB.TabIndex = 0;
            // 
            // vendorItemsLLB
            // 
            this.vendorItemsLLB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendorItemsLLB.FormattingEnabled = true;
            this.vendorItemsLLB.ItemHeight = 18;
            this.vendorItemsLLB.Location = new System.Drawing.Point(622, 30);
            this.vendorItemsLLB.Name = "vendorItemsLLB";
            this.vendorItemsLLB.Size = new System.Drawing.Size(590, 508);
            this.vendorItemsLLB.TabIndex = 1;
            // 
            // loadBtn
            // 
            this.loadBtn.Location = new System.Drawing.Point(455, 606);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.Size = new System.Drawing.Size(106, 35);
            this.loadBtn.TabIndex = 2;
            this.loadBtn.Text = "Load";
            this.loadBtn.UseVisualStyleBackColor = true;
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // filterBtn
            // 
            this.filterBtn.Location = new System.Drawing.Point(999, 606);
            this.filterBtn.Name = "filterBtn";
            this.filterBtn.Size = new System.Drawing.Size(106, 35);
            this.filterBtn.TabIndex = 3;
            this.filterBtn.Text = "Filter";
            this.filterBtn.UseVisualStyleBackColor = true;
            this.filterBtn.Click += new System.EventHandler(this.filterBtn_Click);
            // 
            // costNUD
            // 
            this.costNUD.Location = new System.Drawing.Point(861, 615);
            this.costNUD.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.costNUD.Name = "costNUD";
            this.costNUD.Size = new System.Drawing.Size(120, 26);
            this.costNUD.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(772, 617);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Max. Cost:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.costNUD);
            this.Controls.Add(this.filterBtn);
            this.Controls.Add(this.loadBtn);
            this.Controls.Add(this.vendorItemsLLB);
            this.Controls.Add(this.vendorItemsLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.costNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox vendorItemsLB;
        private System.Windows.Forms.ListBox vendorItemsLLB;
        private System.Windows.Forms.Button loadBtn;
        private System.Windows.Forms.Button filterBtn;
        private System.Windows.Forms.NumericUpDown costNUD;
        private System.Windows.Forms.Label label1;
    }
}

