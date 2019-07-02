namespace LukaszDrozdzLab2Homework
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelEstatesDesc = new System.Windows.Forms.Label();
            this.labelDormsDesc = new System.Windows.Forms.Label();
            this.labelFloorsDesc = new System.Windows.Forms.Label();
            this.labelRoomDesc = new System.Windows.Forms.Label();
            this.labelStudentDesc = new System.Windows.Forms.Label();
            this.labelGenerationRateDesc = new System.Windows.Forms.Label();
            this.labelCurrentNumberDesc = new System.Windows.Forms.Label();
            this.buttonBuyRooms = new System.Windows.Forms.Button();
            this.buttonBuyFloors = new System.Windows.Forms.Button();
            this.buttonBuyDorms = new System.Windows.Forms.Button();
            this.buttonBuyEstates = new System.Windows.Forms.Button();
            this.labelStudentGenerationRate = new System.Windows.Forms.Label();
            this.labelRoomsGenerationRate = new System.Windows.Forms.Label();
            this.labelFloorsGenerationRate = new System.Windows.Forms.Label();
            this.labelDormsGenerationRate = new System.Windows.Forms.Label();
            this.labelNumberOfStudents = new System.Windows.Forms.Label();
            this.labelNumberOfRooms = new System.Windows.Forms.Label();
            this.labelNumberOfFloors = new System.Windows.Forms.Label();
            this.labelNumberOfDorms = new System.Windows.Forms.Label();
            this.labelNumberOfEstates = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripUpgrade = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabelAbout = new System.Windows.Forms.ToolStripLabel();
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.pictureBoxRooms = new System.Windows.Forms.PictureBox();
            this.pictureBoxFloors = new System.Windows.Forms.PictureBox();
            this.pictureBoxDorms = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstates = new System.Windows.Forms.PictureBox();
            this.chartPropertyStructure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDorms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPropertyStructure)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelEstatesDesc, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDormsDesc, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelFloorsDesc, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelRoomDesc, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentDesc, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStudents, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRooms, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxFloors, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDorms, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxEstates, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelGenerationRateDesc, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelCurrentNumberDesc, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyRooms, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyFloors, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyDorms, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyEstates, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentGenerationRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRoomsGenerationRate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelFloorsGenerationRate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDormsGenerationRate, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfStudents, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfRooms, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfFloors, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfDorms, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelNumberOfEstates, 5, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 27);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(646, 266);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelEstatesDesc
            // 
            this.labelEstatesDesc.AutoSize = true;
            this.labelEstatesDesc.Location = new System.Drawing.Point(534, 106);
            this.labelEstatesDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstatesDesc.Name = "labelEstatesDesc";
            this.labelEstatesDesc.Size = new System.Drawing.Size(42, 13);
            this.labelEstatesDesc.TabIndex = 0;
            this.labelEstatesDesc.Text = "Estates";
            // 
            // labelDormsDesc
            // 
            this.labelDormsDesc.AutoSize = true;
            this.labelDormsDesc.Location = new System.Drawing.Point(422, 106);
            this.labelDormsDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDormsDesc.Name = "labelDormsDesc";
            this.labelDormsDesc.Size = new System.Drawing.Size(37, 13);
            this.labelDormsDesc.TabIndex = 1;
            this.labelDormsDesc.Text = "Dorms";
            // 
            // labelFloorsDesc
            // 
            this.labelFloorsDesc.AutoSize = true;
            this.labelFloorsDesc.Location = new System.Drawing.Point(310, 106);
            this.labelFloorsDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFloorsDesc.Name = "labelFloorsDesc";
            this.labelFloorsDesc.Size = new System.Drawing.Size(35, 13);
            this.labelFloorsDesc.TabIndex = 2;
            this.labelFloorsDesc.Text = "Floors";
            // 
            // labelRoomDesc
            // 
            this.labelRoomDesc.AutoSize = true;
            this.labelRoomDesc.Location = new System.Drawing.Point(198, 106);
            this.labelRoomDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomDesc.Name = "labelRoomDesc";
            this.labelRoomDesc.Size = new System.Drawing.Size(40, 13);
            this.labelRoomDesc.TabIndex = 3;
            this.labelRoomDesc.Text = "Rooms";
            // 
            // labelStudentDesc
            // 
            this.labelStudentDesc.AutoSize = true;
            this.labelStudentDesc.Location = new System.Drawing.Point(86, 106);
            this.labelStudentDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudentDesc.Name = "labelStudentDesc";
            this.labelStudentDesc.Size = new System.Drawing.Size(49, 13);
            this.labelStudentDesc.TabIndex = 4;
            this.labelStudentDesc.Text = "Students";
            // 
            // labelGenerationRateDesc
            // 
            this.labelGenerationRateDesc.AutoSize = true;
            this.labelGenerationRateDesc.Location = new System.Drawing.Point(2, 145);
            this.labelGenerationRateDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelGenerationRateDesc.Name = "labelGenerationRateDesc";
            this.labelGenerationRateDesc.Size = new System.Drawing.Size(80, 13);
            this.labelGenerationRateDesc.TabIndex = 10;
            this.labelGenerationRateDesc.Text = "Generation rate";
            // 
            // labelCurrentNumberDesc
            // 
            this.labelCurrentNumberDesc.AutoSize = true;
            this.labelCurrentNumberDesc.Location = new System.Drawing.Point(2, 223);
            this.labelCurrentNumberDesc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCurrentNumberDesc.Name = "labelCurrentNumberDesc";
            this.labelCurrentNumberDesc.Size = new System.Drawing.Size(79, 13);
            this.labelCurrentNumberDesc.TabIndex = 11;
            this.labelCurrentNumberDesc.Text = "Current number";
            // 
            // buttonBuyRooms
            // 
            this.buttonBuyRooms.Location = new System.Drawing.Point(198, 186);
            this.buttonBuyRooms.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyRooms.Name = "buttonBuyRooms";
            this.buttonBuyRooms.Size = new System.Drawing.Size(108, 26);
            this.buttonBuyRooms.TabIndex = 12;
            this.buttonBuyRooms.Text = "Buy rooms";
            this.buttonBuyRooms.UseVisualStyleBackColor = true;
            this.buttonBuyRooms.Click += new System.EventHandler(this.buttonBuyRooms_Click);
            // 
            // buttonBuyFloors
            // 
            this.buttonBuyFloors.Location = new System.Drawing.Point(310, 186);
            this.buttonBuyFloors.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyFloors.Name = "buttonBuyFloors";
            this.buttonBuyFloors.Size = new System.Drawing.Size(108, 26);
            this.buttonBuyFloors.TabIndex = 13;
            this.buttonBuyFloors.Text = "Buy floors";
            this.buttonBuyFloors.UseVisualStyleBackColor = true;
            this.buttonBuyFloors.Click += new System.EventHandler(this.buttonBuyFloors_Click);
            // 
            // buttonBuyDorms
            // 
            this.buttonBuyDorms.Location = new System.Drawing.Point(422, 186);
            this.buttonBuyDorms.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyDorms.Name = "buttonBuyDorms";
            this.buttonBuyDorms.Size = new System.Drawing.Size(108, 26);
            this.buttonBuyDorms.TabIndex = 14;
            this.buttonBuyDorms.Text = "Buy dorms";
            this.buttonBuyDorms.UseVisualStyleBackColor = true;
            this.buttonBuyDorms.Click += new System.EventHandler(this.buttonBuyDorms_Click);
            // 
            // buttonBuyEstates
            // 
            this.buttonBuyEstates.Location = new System.Drawing.Point(534, 186);
            this.buttonBuyEstates.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuyEstates.Name = "buttonBuyEstates";
            this.buttonBuyEstates.Size = new System.Drawing.Size(109, 26);
            this.buttonBuyEstates.TabIndex = 15;
            this.buttonBuyEstates.Text = "Buy estates";
            this.buttonBuyEstates.UseVisualStyleBackColor = true;
            this.buttonBuyEstates.Click += new System.EventHandler(this.buttonBuyEstates_Click);
            // 
            // labelStudentGenerationRate
            // 
            this.labelStudentGenerationRate.AutoSize = true;
            this.labelStudentGenerationRate.Location = new System.Drawing.Point(86, 145);
            this.labelStudentGenerationRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStudentGenerationRate.Name = "labelStudentGenerationRate";
            this.labelStudentGenerationRate.Size = new System.Drawing.Size(13, 13);
            this.labelStudentGenerationRate.TabIndex = 16;
            this.labelStudentGenerationRate.Text = "0";
            // 
            // labelRoomsGenerationRate
            // 
            this.labelRoomsGenerationRate.AutoSize = true;
            this.labelRoomsGenerationRate.Location = new System.Drawing.Point(198, 145);
            this.labelRoomsGenerationRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRoomsGenerationRate.Name = "labelRoomsGenerationRate";
            this.labelRoomsGenerationRate.Size = new System.Drawing.Size(13, 13);
            this.labelRoomsGenerationRate.TabIndex = 17;
            this.labelRoomsGenerationRate.Text = "0";
            // 
            // labelFloorsGenerationRate
            // 
            this.labelFloorsGenerationRate.AutoSize = true;
            this.labelFloorsGenerationRate.Location = new System.Drawing.Point(310, 145);
            this.labelFloorsGenerationRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFloorsGenerationRate.Name = "labelFloorsGenerationRate";
            this.labelFloorsGenerationRate.Size = new System.Drawing.Size(13, 13);
            this.labelFloorsGenerationRate.TabIndex = 18;
            this.labelFloorsGenerationRate.Text = "0";
            // 
            // labelDormsGenerationRate
            // 
            this.labelDormsGenerationRate.AutoSize = true;
            this.labelDormsGenerationRate.Location = new System.Drawing.Point(422, 145);
            this.labelDormsGenerationRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDormsGenerationRate.Name = "labelDormsGenerationRate";
            this.labelDormsGenerationRate.Size = new System.Drawing.Size(13, 13);
            this.labelDormsGenerationRate.TabIndex = 19;
            this.labelDormsGenerationRate.Text = "0";
            // 
            // labelNumberOfStudents
            // 
            this.labelNumberOfStudents.AutoSize = true;
            this.labelNumberOfStudents.Location = new System.Drawing.Point(86, 223);
            this.labelNumberOfStudents.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfStudents.Name = "labelNumberOfStudents";
            this.labelNumberOfStudents.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfStudents.TabIndex = 21;
            this.labelNumberOfStudents.Text = "0";
            // 
            // labelNumberOfRooms
            // 
            this.labelNumberOfRooms.AutoSize = true;
            this.labelNumberOfRooms.Location = new System.Drawing.Point(198, 223);
            this.labelNumberOfRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfRooms.Name = "labelNumberOfRooms";
            this.labelNumberOfRooms.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfRooms.TabIndex = 22;
            this.labelNumberOfRooms.Text = "0";
            // 
            // labelNumberOfFloors
            // 
            this.labelNumberOfFloors.AutoSize = true;
            this.labelNumberOfFloors.Location = new System.Drawing.Point(310, 223);
            this.labelNumberOfFloors.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfFloors.Name = "labelNumberOfFloors";
            this.labelNumberOfFloors.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfFloors.TabIndex = 23;
            this.labelNumberOfFloors.Text = "0";
            // 
            // labelNumberOfDorms
            // 
            this.labelNumberOfDorms.AutoSize = true;
            this.labelNumberOfDorms.Location = new System.Drawing.Point(422, 223);
            this.labelNumberOfDorms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfDorms.Name = "labelNumberOfDorms";
            this.labelNumberOfDorms.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfDorms.TabIndex = 24;
            this.labelNumberOfDorms.Text = "0";
            // 
            // labelNumberOfEstates
            // 
            this.labelNumberOfEstates.AutoSize = true;
            this.labelNumberOfEstates.Location = new System.Drawing.Point(534, 223);
            this.labelNumberOfEstates.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumberOfEstates.Name = "labelNumberOfEstates";
            this.labelNumberOfEstates.Size = new System.Drawing.Size(13, 13);
            this.labelNumberOfEstates.TabIndex = 25;
            this.labelNumberOfEstates.Text = "0";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUpgrade,
            this.toolStripLabelAbout});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(997, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUpgrade
            // 
            this.toolStripUpgrade.Name = "toolStripUpgrade";
            this.toolStripUpgrade.Size = new System.Drawing.Size(57, 22);
            this.toolStripUpgrade.Text = "Upgrades";
            this.toolStripUpgrade.Click += new System.EventHandler(this.toolStripUpgrade_Click);
            // 
            // toolStripLabelAbout
            // 
            this.toolStripLabelAbout.Name = "toolStripLabelAbout";
            this.toolStripLabelAbout.Size = new System.Drawing.Size(40, 22);
            this.toolStripLabelAbout.Text = "About";
            this.toolStripLabelAbout.Click += new System.EventHandler(this.toolStripLabelAbout_Click);
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Student;
            this.pictureBoxStudents.Location = new System.Drawing.Point(86, 2);
            this.pictureBoxStudents.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(108, 76);
            this.pictureBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudents.TabIndex = 5;
            this.pictureBoxStudents.TabStop = false;
            // 
            // pictureBoxRooms
            // 
            this.pictureBoxRooms.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Room;
            this.pictureBoxRooms.Location = new System.Drawing.Point(198, 2);
            this.pictureBoxRooms.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxRooms.Name = "pictureBoxRooms";
            this.pictureBoxRooms.Size = new System.Drawing.Size(108, 76);
            this.pictureBoxRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRooms.TabIndex = 6;
            this.pictureBoxRooms.TabStop = false;
            // 
            // pictureBoxFloors
            // 
            this.pictureBoxFloors.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Floor;
            this.pictureBoxFloors.Location = new System.Drawing.Point(310, 2);
            this.pictureBoxFloors.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxFloors.Name = "pictureBoxFloors";
            this.pictureBoxFloors.Size = new System.Drawing.Size(108, 76);
            this.pictureBoxFloors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloors.TabIndex = 7;
            this.pictureBoxFloors.TabStop = false;
            // 
            // pictureBoxDorms
            // 
            this.pictureBoxDorms.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Dorm;
            this.pictureBoxDorms.Location = new System.Drawing.Point(422, 2);
            this.pictureBoxDorms.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxDorms.Name = "pictureBoxDorms";
            this.pictureBoxDorms.Size = new System.Drawing.Size(108, 76);
            this.pictureBoxDorms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDorms.TabIndex = 8;
            this.pictureBoxDorms.TabStop = false;
            // 
            // pictureBoxEstates
            // 
            this.pictureBoxEstates.Image = global::LukaszDrozdzLab2Homework.Properties.Resources.Estate;
            this.pictureBoxEstates.Location = new System.Drawing.Point(534, 2);
            this.pictureBoxEstates.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxEstates.Name = "pictureBoxEstates";
            this.pictureBoxEstates.Size = new System.Drawing.Size(110, 76);
            this.pictureBoxEstates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstates.TabIndex = 9;
            this.pictureBoxEstates.TabStop = false;
            // 
            // chartPropertyStructure
            // 
            this.chartPropertyStructure.BackColor = System.Drawing.Color.Transparent;
            this.chartPropertyStructure.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartPropertyStructure.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPropertyStructure.Legends.Add(legend1);
            this.chartPropertyStructure.Location = new System.Drawing.Point(662, 27);
            this.chartPropertyStructure.Name = "chartPropertyStructure";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Property";
            series1.Points.Add(dataPoint1);
            this.chartPropertyStructure.Series.Add(series1);
            this.chartPropertyStructure.Size = new System.Drawing.Size(323, 266);
            this.chartPropertyStructure.TabIndex = 2;
            this.chartPropertyStructure.Text = "Property structure";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 304);
            this.Controls.Add(this.chartPropertyStructure);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormMain";
            this.Text = "Dorm Tycoon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDorms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPropertyStructure)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelEstatesDesc;
        private System.Windows.Forms.Label labelDormsDesc;
        private System.Windows.Forms.Label labelFloorsDesc;
        private System.Windows.Forms.Label labelRoomDesc;
        private System.Windows.Forms.Label labelStudentDesc;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.PictureBox pictureBoxRooms;
        private System.Windows.Forms.PictureBox pictureBoxFloors;
        private System.Windows.Forms.PictureBox pictureBoxDorms;
        private System.Windows.Forms.PictureBox pictureBoxEstates;
        private System.Windows.Forms.Label labelGenerationRateDesc;
        private System.Windows.Forms.Label labelCurrentNumberDesc;
        private System.Windows.Forms.Button buttonBuyRooms;
        private System.Windows.Forms.Button buttonBuyFloors;
        private System.Windows.Forms.Button buttonBuyDorms;
        private System.Windows.Forms.Button buttonBuyEstates;
        private System.Windows.Forms.Label labelStudentGenerationRate;
        private System.Windows.Forms.Label labelRoomsGenerationRate;
        private System.Windows.Forms.Label labelFloorsGenerationRate;
        private System.Windows.Forms.Label labelDormsGenerationRate;
        private System.Windows.Forms.Label labelNumberOfStudents;
        private System.Windows.Forms.Label labelNumberOfRooms;
        private System.Windows.Forms.Label labelNumberOfFloors;
        private System.Windows.Forms.Label labelNumberOfDorms;
        private System.Windows.Forms.Label labelNumberOfEstates;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripUpgrade;
        private System.Windows.Forms.ToolStripLabel toolStripLabelAbout;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPropertyStructure;
    }
}

