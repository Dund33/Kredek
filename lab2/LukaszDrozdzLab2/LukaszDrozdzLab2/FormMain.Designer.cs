namespace LukaszDrozdzLab2
{
    partial class FormMain
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
            this.buttonPerimeter = new System.Windows.Forms.Button();
            this.buttonChangeSize = new System.Windows.Forms.Button();
            this.buttonArea = new System.Windows.Forms.Button();
            this.textBoxPerimeter = new System.Windows.Forms.TextBox();
            this.textBoxArea = new System.Windows.Forms.TextBox();
            this.comboBoxShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonPerimeter
            // 
            this.buttonPerimeter.Location = new System.Drawing.Point(118, 91);
            this.buttonPerimeter.Name = "buttonPerimeter";
            this.buttonPerimeter.Size = new System.Drawing.Size(75, 23);
            this.buttonPerimeter.TabIndex = 0;
            this.buttonPerimeter.Text = "Perimeter";
            this.buttonPerimeter.UseVisualStyleBackColor = true;
            this.buttonPerimeter.Click += new System.EventHandler(this.buttonPerimeter_Click);
            // 
            // buttonChangeSize
            // 
            this.buttonChangeSize.Location = new System.Drawing.Point(118, 62);
            this.buttonChangeSize.Name = "buttonChangeSize";
            this.buttonChangeSize.Size = new System.Drawing.Size(75, 23);
            this.buttonChangeSize.TabIndex = 1;
            this.buttonChangeSize.Text = "change size";
            this.buttonChangeSize.UseVisualStyleBackColor = true;
            this.buttonChangeSize.Click += new System.EventHandler(this.buttonChangeSize_Click);
            // 
            // buttonArea
            // 
            this.buttonArea.Location = new System.Drawing.Point(118, 36);
            this.buttonArea.Name = "buttonArea";
            this.buttonArea.Size = new System.Drawing.Size(75, 23);
            this.buttonArea.TabIndex = 2;
            this.buttonArea.Text = "ObliczPole";
            this.buttonArea.UseVisualStyleBackColor = true;
            this.buttonArea.Click += new System.EventHandler(this.buttonArea_Click);
            // 
            // textBoxPerimeter
            // 
            this.textBoxPerimeter.Location = new System.Drawing.Point(12, 65);
            this.textBoxPerimeter.Name = "textBoxPerimeter";
            this.textBoxPerimeter.Size = new System.Drawing.Size(100, 20);
            this.textBoxPerimeter.TabIndex = 3;
            // 
            // textBoxArea
            // 
            this.textBoxArea.Location = new System.Drawing.Point(12, 39);
            this.textBoxArea.Name = "textBoxArea";
            this.textBoxArea.Size = new System.Drawing.Size(100, 20);
            this.textBoxArea.TabIndex = 4;
            // 
            // comboBoxShape
            // 
            this.comboBoxShape.FormattingEnabled = true;
            this.comboBoxShape.Location = new System.Drawing.Point(12, 12);
            this.comboBoxShape.Name = "comboBoxShape";
            this.comboBoxShape.Size = new System.Drawing.Size(121, 21);
            this.comboBoxShape.TabIndex = 5;
            this.comboBoxShape.SelectedIndexChanged += new System.EventHandler(this.comboBoxShape_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(458, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Łukasz Dróżdż";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxShape);
            this.Controls.Add(this.textBoxArea);
            this.Controls.Add(this.textBoxPerimeter);
            this.Controls.Add(this.buttonArea);
            this.Controls.Add(this.buttonChangeSize);
            this.Controls.Add(this.buttonPerimeter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPerimeter;
        private System.Windows.Forms.Button buttonChangeSize;
        private System.Windows.Forms.Button buttonArea;
        private System.Windows.Forms.TextBox textBoxPerimeter;
        private System.Windows.Forms.TextBox textBoxArea;
        private System.Windows.Forms.ComboBox comboBoxShape;
        private System.Windows.Forms.Label label1;
    }
}

