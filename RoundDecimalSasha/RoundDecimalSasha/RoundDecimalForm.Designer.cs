namespace RoundDecimalSasha
{
    partial class frmRoundDecimal
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblDecimal = new System.Windows.Forms.Label();
            this.nudDecimal = new System.Windows.Forms.NumericUpDown();
            this.Round = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter a decimal number:";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(432, 85);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(186, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblDecimal
            // 
            this.lblDecimal.AutoSize = true;
            this.lblDecimal.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecimal.Location = new System.Drawing.Point(28, 209);
            this.lblDecimal.Name = "lblDecimal";
            this.lblDecimal.Size = new System.Drawing.Size(470, 26);
            this.lblDecimal.TabIndex = 3;
            this.lblDecimal.Text = "How many decimal places do you want to round to?";
            // 
            // nudDecimal
            // 
            this.nudDecimal.Location = new System.Drawing.Point(551, 215);
            this.nudDecimal.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDecimal.Name = "nudDecimal";
            this.nudDecimal.Size = new System.Drawing.Size(120, 20);
            this.nudDecimal.TabIndex = 4;
            // 
            // Round
            // 
            this.Round.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Round.Location = new System.Drawing.Point(334, 331);
            this.Round.Name = "Round";
            this.Round.Size = new System.Drawing.Size(101, 40);
            this.Round.TabIndex = 5;
            this.Round.Text = "Round";
            this.Round.UseVisualStyleBackColor = true;
            // 
            // frmRoundDecimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Round);
            this.Controls.Add(this.nudDecimal);
            this.Controls.Add(this.lblDecimal);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Name = "frmRoundDecimal";
            this.Text = "Round Decimal by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.nudDecimal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblDecimal;
        private System.Windows.Forms.NumericUpDown nudDecimal;
        private System.Windows.Forms.Button Round;
    }
}

