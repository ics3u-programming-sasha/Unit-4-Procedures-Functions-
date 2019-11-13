namespace PassByRefSasha
{
    partial class frmPassByRef
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
            this.lblClick = new System.Windows.Forms.Label();
            this.picCard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClick
            // 
            this.lblClick.AutoSize = true;
            this.lblClick.Font = new System.Drawing.Font("Adobe Devanagari", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClick.Location = new System.Drawing.Point(240, 43);
            this.lblClick.Name = "lblClick";
            this.lblClick.Size = new System.Drawing.Size(261, 28);
            this.lblClick.TabIndex = 0;
            this.lblClick.Text = "Click on the image to change it.";
            // 
            // picCard
            // 
            this.picCard.Image = global::PassByRefSasha.Properties.Resources.Front;
            this.picCard.Location = new System.Drawing.Point(258, 87);
            this.picCard.Name = "picCard";
            this.picCard.Size = new System.Drawing.Size(231, 326);
            this.picCard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCard.TabIndex = 1;
            this.picCard.TabStop = false;
            this.picCard.Click += new System.EventHandler(this.picCard_Click);
            // 
            // frmPassByRef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCard);
            this.Controls.Add(this.lblClick);
            this.Name = "frmPassByRef";
            this.Text = "Pass by Reference by Sasha";
            ((System.ComponentModel.ISupportInitialize)(this.picCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClick;
        private System.Windows.Forms.PictureBox picCard;
    }
}

