namespace Assignment2
{
    partial class frmAssignment2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAssignment2));
            this.lblGreet = new System.Windows.Forms.Label();
            this.txtMood = new System.Windows.Forms.TextBox();
            this.btnResponse = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.lbl1stMark = new System.Windows.Forms.Label();
            this.lbl2ndMark = new System.Windows.Forms.Label();
            this.lbl3rdMark = new System.Windows.Forms.Label();
            this.lbl4thMark = new System.Windows.Forms.Label();
            this.lbl5thMark = new System.Windows.Forms.Label();
            this.txtMark1 = new System.Windows.Forms.TextBox();
            this.txtMark2 = new System.Windows.Forms.TextBox();
            this.txtMark3 = new System.Windows.Forms.TextBox();
            this.txtMark4 = new System.Windows.Forms.TextBox();
            this.txtMark5 = new System.Windows.Forms.TextBox();
            this.btnAverage = new System.Windows.Forms.Button();
            this.lblDisplayAverage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGreet
            // 
            this.lblGreet.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreet.Location = new System.Drawing.Point(13, 31);
            this.lblGreet.Name = "lblGreet";
            this.lblGreet.Size = new System.Drawing.Size(298, 28);
            this.lblGreet.TabIndex = 0;
            this.lblGreet.Text = "Hello, how are you? Doing Well?\r\n(Answer \"Yes\" or \"No\")\r\n";
            this.lblGreet.Click += new System.EventHandler(this.lblGreet_Click);
            // 
            // txtMood
            // 
            this.txtMood.Location = new System.Drawing.Point(12, 62);
            this.txtMood.Name = "txtMood";
            this.txtMood.Size = new System.Drawing.Size(299, 20);
            this.txtMood.TabIndex = 1;
            this.txtMood.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnResponse
            // 
            this.btnResponse.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResponse.Location = new System.Drawing.Point(12, 88);
            this.btnResponse.Name = "btnResponse";
            this.btnResponse.Size = new System.Drawing.Size(299, 23);
            this.btnResponse.TabIndex = 2;
            this.btnResponse.Text = "Response";
            this.btnResponse.UseVisualStyleBackColor = true;
            this.btnResponse.Click += new System.EventHandler(this.btnResponse_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.Location = new System.Drawing.Point(12, 115);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(299, 68);
            this.lblResponse.TabIndex = 3;
            // 
            // lbl1stMark
            // 
            this.lbl1stMark.AutoSize = true;
            this.lbl1stMark.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1stMark.Location = new System.Drawing.Point(456, 16);
            this.lbl1stMark.Name = "lbl1stMark";
            this.lbl1stMark.Size = new System.Drawing.Size(43, 12);
            this.lbl1stMark.TabIndex = 4;
            this.lbl1stMark.Text = "Mark 1:";
            // 
            // lbl2ndMark
            // 
            this.lbl2ndMark.AutoSize = true;
            this.lbl2ndMark.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2ndMark.Location = new System.Drawing.Point(456, 38);
            this.lbl2ndMark.Name = "lbl2ndMark";
            this.lbl2ndMark.Size = new System.Drawing.Size(44, 12);
            this.lbl2ndMark.TabIndex = 5;
            this.lbl2ndMark.Text = "Mark 2:";
            // 
            // lbl3rdMark
            // 
            this.lbl3rdMark.AutoSize = true;
            this.lbl3rdMark.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3rdMark.Location = new System.Drawing.Point(456, 62);
            this.lbl3rdMark.Name = "lbl3rdMark";
            this.lbl3rdMark.Size = new System.Drawing.Size(45, 12);
            this.lbl3rdMark.TabIndex = 6;
            this.lbl3rdMark.Text = "Mark 3:";
            // 
            // lbl4thMark
            // 
            this.lbl4thMark.AutoSize = true;
            this.lbl4thMark.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4thMark.Location = new System.Drawing.Point(456, 88);
            this.lbl4thMark.Name = "lbl4thMark";
            this.lbl4thMark.Size = new System.Drawing.Size(44, 12);
            this.lbl4thMark.TabIndex = 7;
            this.lbl4thMark.Text = "Mark 4:";
            // 
            // lbl5thMark
            // 
            this.lbl5thMark.AutoSize = true;
            this.lbl5thMark.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5thMark.Location = new System.Drawing.Point(456, 115);
            this.lbl5thMark.Name = "lbl5thMark";
            this.lbl5thMark.Size = new System.Drawing.Size(44, 12);
            this.lbl5thMark.TabIndex = 8;
            this.lbl5thMark.Text = "Mark 5:";
            // 
            // txtMark1
            // 
            this.txtMark1.Location = new System.Drawing.Point(532, 9);
            this.txtMark1.Name = "txtMark1";
            this.txtMark1.Size = new System.Drawing.Size(437, 20);
            this.txtMark1.TabIndex = 9;
            this.txtMark1.TextChanged += new System.EventHandler(this.txtMark1_TextChanged);
            // 
            // txtMark2
            // 
            this.txtMark2.Location = new System.Drawing.Point(532, 35);
            this.txtMark2.Name = "txtMark2";
            this.txtMark2.Size = new System.Drawing.Size(437, 20);
            this.txtMark2.TabIndex = 10;
            // 
            // txtMark3
            // 
            this.txtMark3.Location = new System.Drawing.Point(532, 62);
            this.txtMark3.Name = "txtMark3";
            this.txtMark3.Size = new System.Drawing.Size(437, 20);
            this.txtMark3.TabIndex = 11;
            // 
            // txtMark4
            // 
            this.txtMark4.Location = new System.Drawing.Point(532, 85);
            this.txtMark4.Name = "txtMark4";
            this.txtMark4.Size = new System.Drawing.Size(437, 20);
            this.txtMark4.TabIndex = 12;
            // 
            // txtMark5
            // 
            this.txtMark5.Location = new System.Drawing.Point(532, 112);
            this.txtMark5.Name = "txtMark5";
            this.txtMark5.Size = new System.Drawing.Size(437, 20);
            this.txtMark5.TabIndex = 13;
            // 
            // btnAverage
            // 
            this.btnAverage.Font = new System.Drawing.Font("Forte", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAverage.Location = new System.Drawing.Point(459, 138);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(510, 23);
            this.btnAverage.TabIndex = 14;
            this.btnAverage.Text = "Calculate Average";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // lblDisplayAverage
            // 
            this.lblDisplayAverage.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayAverage.Location = new System.Drawing.Point(459, 173);
            this.lblDisplayAverage.Name = "lblDisplayAverage";
            this.lblDisplayAverage.Size = new System.Drawing.Size(510, 398);
            this.lblDisplayAverage.TabIndex = 15;
            // 
            // frmAssignment2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1203, 628);
            this.Controls.Add(this.lblDisplayAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.txtMark5);
            this.Controls.Add(this.txtMark4);
            this.Controls.Add(this.txtMark3);
            this.Controls.Add(this.txtMark2);
            this.Controls.Add(this.txtMark1);
            this.Controls.Add(this.lbl5thMark);
            this.Controls.Add(this.lbl4thMark);
            this.Controls.Add(this.lbl3rdMark);
            this.Controls.Add(this.lbl2ndMark);
            this.Controls.Add(this.lbl1stMark);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnResponse);
            this.Controls.Add(this.txtMood);
            this.Controls.Add(this.lblGreet);
            this.Name = "frmAssignment2";
            this.Text = "Assignment 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreet;
        private System.Windows.Forms.TextBox txtMood;
        private System.Windows.Forms.Button btnResponse;
        private System.Windows.Forms.Label lblResponse;
        private System.Windows.Forms.Label lbl1stMark;
        private System.Windows.Forms.Label lbl2ndMark;
        private System.Windows.Forms.Label lbl3rdMark;
        private System.Windows.Forms.Label lbl4thMark;
        private System.Windows.Forms.Label lbl5thMark;
        private System.Windows.Forms.TextBox txtMark1;
        private System.Windows.Forms.TextBox txtMark2;
        private System.Windows.Forms.TextBox txtMark3;
        private System.Windows.Forms.TextBox txtMark4;
        private System.Windows.Forms.TextBox txtMark5;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.Label lblDisplayAverage;
    }
}

