namespace LukaszDrozdzLab2Homework
{
    partial class FormAbout
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
            this.pictureBoxAbout = new System.Windows.Forms.PictureBox();
            this.labelAbout = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout
            // 
            this.pictureBoxAbout.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Dorm;
            this.pictureBoxAbout.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAbout.Name = "pictureBoxAbout";
            this.pictureBoxAbout.Size = new System.Drawing.Size(141, 107);
            this.pictureBoxAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAbout.TabIndex = 0;
            this.pictureBoxAbout.TabStop = false;
            // 
            // labelAbout
            // 
            this.labelAbout.AutoSize = true;
            this.labelAbout.Location = new System.Drawing.Point(159, 12);
            this.labelAbout.Name = "labelAbout";
            this.labelAbout.Size = new System.Drawing.Size(100, 13);
            this.labelAbout.TabIndex = 1;
            this.labelAbout.Text = "Dorm tycoon v 0.02";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 137);
            this.Controls.Add(this.labelAbout);
            this.Controls.Add(this.pictureBoxAbout);
            this.Name = "FormAbout";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout;
        private System.Windows.Forms.Label labelAbout;
    }
}