namespace LukaszDrozdzLab1
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
            this.labelTurtlez = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTurtlez
            // 
            this.labelTurtlez.AutoSize = true;
            this.labelTurtlez.Location = new System.Drawing.Point(12, 9);
            this.labelTurtlez.Name = "labelTurtlez";
            this.labelTurtlez.Size = new System.Drawing.Size(72, 13);
            this.labelTurtlez.TabIndex = 0;
            this.labelTurtlez.Text = "I like turtlez :3";
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 43);
            this.Controls.Add(this.labelTurtlez);
            this.Name = "FormAbout";
            this.Text = "FormAuxilary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTurtlez;
    }
}