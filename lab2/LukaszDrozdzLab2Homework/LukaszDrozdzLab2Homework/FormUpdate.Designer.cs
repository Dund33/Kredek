namespace LukaszDrozdzLab2Homework
{
    partial class FormUpdate
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
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelUpdateCostDesc = new System.Windows.Forms.Label();
            this.labelBaseUpgradeCost = new System.Windows.Forms.Label();
            this.labelStudentUpgradeCost = new System.Windows.Forms.Label();
            this.labelRoomUpgradeCost = new System.Windows.Forms.Label();
            this.labelFloorUpgradeCost = new System.Windows.Forms.Label();
            this.labelDormUpgradeCost = new System.Windows.Forms.Label();
            this.labelStudentBaseDesc = new System.Windows.Forms.Label();
            this.labelStudentDesc = new System.Windows.Forms.Label();
            this.labelRoomDesc = new System.Windows.Forms.Label();
            this.labelFloorDesc = new System.Windows.Forms.Label();
            this.labelDormDesc = new System.Windows.Forms.Label();
            this.buttonUpgradeBaseRate = new System.Windows.Forms.Button();
            this.buttonUpgradeStudentRate = new System.Windows.Forms.Button();
            this.buttonUpgradeRoomRate = new System.Windows.Forms.Button();
            this.buttonUpgradeFloorRate = new System.Windows.Forms.Button();
            this.buttonUpgradeDormRate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefresh
            // 
            this.timerRefresh.Tick += new System.EventHandler(this.timerRefresh_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel1.Controls.Add(this.labelUpdateCostDesc, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelBaseUpgradeCost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentUpgradeCost, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRoomUpgradeCost, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFloorUpgradeCost, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDormUpgradeCost, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentBaseDesc, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentDesc, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelRoomDesc, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelFloorDesc, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDormDesc, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpgradeBaseRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpgradeStudentRate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpgradeRoomRate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpgradeFloorRate, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonUpgradeDormRate, 5, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(770, 136);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelUpdateCostDesc
            // 
            this.labelUpdateCostDesc.AutoSize = true;
            this.labelUpdateCostDesc.Location = new System.Drawing.Point(3, 40);
            this.labelUpdateCostDesc.Name = "labelUpdateCostDesc";
            this.labelUpdateCostDesc.Size = new System.Drawing.Size(39, 20);
            this.labelUpdateCostDesc.TabIndex = 0;
            this.labelUpdateCostDesc.Text = "cost";
            // 
            // labelBaseUpgradeCost
            // 
            this.labelBaseUpgradeCost.AutoSize = true;
            this.labelBaseUpgradeCost.Location = new System.Drawing.Point(80, 40);
            this.labelBaseUpgradeCost.Name = "labelBaseUpgradeCost";
            this.labelBaseUpgradeCost.Size = new System.Drawing.Size(18, 20);
            this.labelBaseUpgradeCost.TabIndex = 1;
            this.labelBaseUpgradeCost.Text = "0";
            // 
            // labelStudentUpgradeCost
            // 
            this.labelStudentUpgradeCost.AutoSize = true;
            this.labelStudentUpgradeCost.Location = new System.Drawing.Point(218, 40);
            this.labelStudentUpgradeCost.Name = "labelStudentUpgradeCost";
            this.labelStudentUpgradeCost.Size = new System.Drawing.Size(18, 20);
            this.labelStudentUpgradeCost.TabIndex = 2;
            this.labelStudentUpgradeCost.Text = "0";
            // 
            // labelRoomUpgradeCost
            // 
            this.labelRoomUpgradeCost.AutoSize = true;
            this.labelRoomUpgradeCost.Location = new System.Drawing.Point(356, 40);
            this.labelRoomUpgradeCost.Name = "labelRoomUpgradeCost";
            this.labelRoomUpgradeCost.Size = new System.Drawing.Size(18, 20);
            this.labelRoomUpgradeCost.TabIndex = 3;
            this.labelRoomUpgradeCost.Text = "0";
            // 
            // labelFloorUpgradeCost
            // 
            this.labelFloorUpgradeCost.AutoSize = true;
            this.labelFloorUpgradeCost.Location = new System.Drawing.Point(494, 40);
            this.labelFloorUpgradeCost.Name = "labelFloorUpgradeCost";
            this.labelFloorUpgradeCost.Size = new System.Drawing.Size(18, 20);
            this.labelFloorUpgradeCost.TabIndex = 4;
            this.labelFloorUpgradeCost.Text = "0";
            // 
            // labelDormUpgradeCost
            // 
            this.labelDormUpgradeCost.AutoSize = true;
            this.labelDormUpgradeCost.Location = new System.Drawing.Point(632, 40);
            this.labelDormUpgradeCost.Name = "labelDormUpgradeCost";
            this.labelDormUpgradeCost.Size = new System.Drawing.Size(18, 20);
            this.labelDormUpgradeCost.TabIndex = 5;
            this.labelDormUpgradeCost.Text = "0";
            // 
            // labelStudentBaseDesc
            // 
            this.labelStudentBaseDesc.AutoSize = true;
            this.labelStudentBaseDesc.Location = new System.Drawing.Point(80, 0);
            this.labelStudentBaseDesc.Name = "labelStudentBaseDesc";
            this.labelStudentBaseDesc.Size = new System.Drawing.Size(109, 40);
            this.labelStudentBaseDesc.TabIndex = 6;
            this.labelStudentBaseDesc.Text = "Student base rate 1.25x";
            // 
            // labelStudentDesc
            // 
            this.labelStudentDesc.AutoSize = true;
            this.labelStudentDesc.Location = new System.Drawing.Point(218, 0);
            this.labelStudentDesc.Name = "labelStudentDesc";
            this.labelStudentDesc.Size = new System.Drawing.Size(102, 40);
            this.labelStudentDesc.TabIndex = 7;
            this.labelStudentDesc.Text = "Student rate 1.25x";
            // 
            // labelRoomDesc
            // 
            this.labelRoomDesc.AutoSize = true;
            this.labelRoomDesc.Location = new System.Drawing.Point(356, 0);
            this.labelRoomDesc.Name = "labelRoomDesc";
            this.labelRoomDesc.Size = new System.Drawing.Size(126, 20);
            this.labelRoomDesc.TabIndex = 8;
            this.labelRoomDesc.Text = "Room rate 1.25x";
            // 
            // labelFloorDesc
            // 
            this.labelFloorDesc.AutoSize = true;
            this.labelFloorDesc.Location = new System.Drawing.Point(494, 0);
            this.labelFloorDesc.Name = "labelFloorDesc";
            this.labelFloorDesc.Size = new System.Drawing.Size(119, 20);
            this.labelFloorDesc.TabIndex = 9;
            this.labelFloorDesc.Text = "Floor rate 1.25x";
            // 
            // labelDormDesc
            // 
            this.labelDormDesc.AutoSize = true;
            this.labelDormDesc.Location = new System.Drawing.Point(632, 0);
            this.labelDormDesc.Name = "labelDormDesc";
            this.labelDormDesc.Size = new System.Drawing.Size(122, 20);
            this.labelDormDesc.TabIndex = 10;
            this.labelDormDesc.Text = "Dorm rate 1.25x";
            // 
            // buttonUpgradeBaseRate
            // 
            this.buttonUpgradeBaseRate.Location = new System.Drawing.Point(80, 63);
            this.buttonUpgradeBaseRate.Name = "buttonUpgradeBaseRate";
            this.buttonUpgradeBaseRate.Size = new System.Drawing.Size(132, 73);
            this.buttonUpgradeBaseRate.TabIndex = 11;
            this.buttonUpgradeBaseRate.Text = "Upgrade";
            this.buttonUpgradeBaseRate.UseVisualStyleBackColor = true;
            this.buttonUpgradeBaseRate.Click += new System.EventHandler(this.buttonUpgradeBaseRate_Click);
            // 
            // buttonUpgradeStudentRate
            // 
            this.buttonUpgradeStudentRate.Location = new System.Drawing.Point(218, 63);
            this.buttonUpgradeStudentRate.Name = "buttonUpgradeStudentRate";
            this.buttonUpgradeStudentRate.Size = new System.Drawing.Size(132, 73);
            this.buttonUpgradeStudentRate.TabIndex = 12;
            this.buttonUpgradeStudentRate.Text = "Upgrade";
            this.buttonUpgradeStudentRate.UseVisualStyleBackColor = true;
            this.buttonUpgradeStudentRate.Click += new System.EventHandler(this.buttonUpgradeStudentRate_Click);
            // 
            // buttonUpgradeRoomRate
            // 
            this.buttonUpgradeRoomRate.Location = new System.Drawing.Point(356, 63);
            this.buttonUpgradeRoomRate.Name = "buttonUpgradeRoomRate";
            this.buttonUpgradeRoomRate.Size = new System.Drawing.Size(132, 73);
            this.buttonUpgradeRoomRate.TabIndex = 13;
            this.buttonUpgradeRoomRate.Text = "Upgrade";
            this.buttonUpgradeRoomRate.UseVisualStyleBackColor = true;
            this.buttonUpgradeRoomRate.Click += new System.EventHandler(this.buttonUpgradeRoomRate_Click);
            // 
            // buttonUpgradeFloorRate
            // 
            this.buttonUpgradeFloorRate.Location = new System.Drawing.Point(494, 63);
            this.buttonUpgradeFloorRate.Name = "buttonUpgradeFloorRate";
            this.buttonUpgradeFloorRate.Size = new System.Drawing.Size(132, 73);
            this.buttonUpgradeFloorRate.TabIndex = 14;
            this.buttonUpgradeFloorRate.Text = "Upgrade";
            this.buttonUpgradeFloorRate.UseVisualStyleBackColor = true;
            this.buttonUpgradeFloorRate.Click += new System.EventHandler(this.buttonUpgradeFloorRate_Click);
            // 
            // buttonUpgradeDormRate
            // 
            this.buttonUpgradeDormRate.Location = new System.Drawing.Point(632, 63);
            this.buttonUpgradeDormRate.Name = "buttonUpgradeDormRate";
            this.buttonUpgradeDormRate.Size = new System.Drawing.Size(135, 73);
            this.buttonUpgradeDormRate.TabIndex = 15;
            this.buttonUpgradeDormRate.Text = "Upgrade";
            this.buttonUpgradeDormRate.UseVisualStyleBackColor = true;
            this.buttonUpgradeDormRate.Click += new System.EventHandler(this.buttonUpgradeDormRate_Click);
            // 
            // FormUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 160);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormUpdate";
            this.Text = "FormUpdate";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelUpdateCostDesc;
        private System.Windows.Forms.Label labelBaseUpgradeCost;
        private System.Windows.Forms.Label labelStudentUpgradeCost;
        private System.Windows.Forms.Label labelRoomUpgradeCost;
        private System.Windows.Forms.Label labelFloorUpgradeCost;
        private System.Windows.Forms.Label labelDormUpgradeCost;
        private System.Windows.Forms.Label labelStudentBaseDesc;
        private System.Windows.Forms.Label labelStudentDesc;
        private System.Windows.Forms.Label labelRoomDesc;
        private System.Windows.Forms.Label labelFloorDesc;
        private System.Windows.Forms.Label labelDormDesc;
        private System.Windows.Forms.Button buttonUpgradeBaseRate;
        private System.Windows.Forms.Button buttonUpgradeStudentRate;
        private System.Windows.Forms.Button buttonUpgradeRoomRate;
        private System.Windows.Forms.Button buttonUpgradeFloorRate;
        private System.Windows.Forms.Button buttonUpgradeDormRate;
    }
}