namespace LukaszDrozdzLab1
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
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonChange = new System.Windows.Forms.Button();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.buttonShow = new System.Windows.Forms.Button();
            this.timerCounter = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonNewWindow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(78, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Łukasz Dróżdż";
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(301, 208);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 25);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonChange.Size = new System.Drawing.Size(95, 23);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Change";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(12, 54);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(95, 20);
            this.textBoxNumber.TabIndex = 3;
            this.textBoxNumber.Text = "1";
            // 
            // buttonShow
            // 
            this.buttonShow.Location = new System.Drawing.Point(12, 80);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(95, 23);
            this.buttonShow.TabIndex = 4;
            this.buttonShow.Text = "Show";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // timerCounter
            // 
            this.timerCounter.Interval = 500;
            this.timerCounter.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 109);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(95, 23);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "staart";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonNewWindow
            // 
            this.buttonNewWindow.Location = new System.Drawing.Point(113, 109);
            this.buttonNewWindow.Name = "buttonNewWindow";
            this.buttonNewWindow.Size = new System.Drawing.Size(75, 23);
            this.buttonNewWindow.TabIndex = 6;
            this.buttonNewWindow.Text = "New Window";
            this.buttonNewWindow.UseVisualStyleBackColor = true;
            this.buttonNewWindow.Click += new System.EventHandler(this.buttonNewWindow_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 243);
            this.Controls.Add(this.buttonNewWindow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonShow);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelName);
            this.Name = "FormMain";
            this.Text = "Main Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Button buttonShow;
        private System.Windows.Forms.Timer timerCounter;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonNewWindow;
    }
}

