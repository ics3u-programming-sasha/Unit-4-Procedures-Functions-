namespace HypotenuseSasha
{
    partial class frmHypotenuse
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
            this.lblSideA = new System.Windows.Forms.Label();
            this.lblSideB = new System.Windows.Forms.Label();
            this.txtSideA = new System.Windows.Forms.TextBox();
            this.txtSideB = new System.Windows.Forms.TextBox();
            this.lblEnter = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblHypotenuse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSideA
            // 
            this.lblSideA.AutoSize = true;
            this.lblSideA.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideA.Location = new System.Drawing.Point(230, 112);
            this.lblSideA.Name = "lblSideA";
            this.lblSideA.Size = new System.Drawing.Size(68, 28);
            this.lblSideA.TabIndex = 0;
            this.lblSideA.Text = "Side A:";
            // 
            // lblSideB
            // 
            this.lblSideB.AutoSize = true;
            this.lblSideB.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSideB.Location = new System.Drawing.Point(230, 183);
            this.lblSideB.Name = "lblSideB";
            this.lblSideB.Size = new System.Drawing.Size(67, 28);
            this.lblSideB.TabIndex = 2;
            this.lblSideB.Text = "Side B:";
            // 
            // txtSideA
            // 
            this.txtSideA.Location = new System.Drawing.Point(443, 112);
            this.txtSideA.Name = "txtSideA";
            this.txtSideA.Size = new System.Drawing.Size(100, 20);
            this.txtSideA.TabIndex = 3;
            // 
            // txtSideB
            // 
            this.txtSideB.Location = new System.Drawing.Point(443, 187);
            this.txtSideB.Name = "txtSideB";
            this.txtSideB.Size = new System.Drawing.Size(100, 20);
            this.txtSideB.TabIndex = 4;
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(250, 47);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(284, 28);
            this.lblEnter.TabIndex = 5;
            this.lblEnter.Text = "Enter the lengths for Side A and B.";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(325, 254);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(105, 33);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // lblHypotenuse
            // 
            this.lblHypotenuse.AutoSize = true;
            this.lblHypotenuse.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHypotenuse.Location = new System.Drawing.Point(278, 356);
            this.lblHypotenuse.Name = "lblHypotenuse";
            this.lblHypotenuse.Size = new System.Drawing.Size(20, 28);
            this.lblHypotenuse.TabIndex = 7;
            this.lblHypotenuse.Text = "?";
            // 
            // frmHypotenuse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHypotenuse);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.txtSideB);
            this.Controls.Add(this.txtSideA);
            this.Controls.Add(this.lblSideB);
            this.Controls.Add(this.lblSideA);
            this.Name = "frmHypotenuse";
            this.Text = "Calculate the Hypotenuse by Sasha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSideA;
        private System.Windows.Forms.Label lblSideB;
        private System.Windows.Forms.TextBox txtSideA;
        private System.Windows.Forms.TextBox txtSideB;
        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblHypotenuse;
    }
}

