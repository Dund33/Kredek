namespace LukaszDrozdzLab1Homework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonBuyRooms = new System.Windows.Forms.Button();
            this.buttonBuyFloors = new System.Windows.Forms.Button();
            this.buttonBuyDorms = new System.Windows.Forms.Button();
            this.buttonBuyEstates = new System.Windows.Forms.Button();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelFloors = new System.Windows.Forms.Label();
            this.labelDorms = new System.Windows.Forms.Label();
            this.labelEstates = new System.Windows.Forms.Label();
            this.timerRefresh = new System.Windows.Forms.Timer(this.components);
            this.buttonChangeMode = new System.Windows.Forms.Button();
            this.labelStudents = new System.Windows.Forms.Label();
            this.labelRoomGenerationRate = new System.Windows.Forms.Label();
            this.labelFloorGenerationRate = new System.Windows.Forms.Label();
            this.labelDormGenerationRate = new System.Windows.Forms.Label();
            this.labelStudentGenerationRate = new System.Windows.Forms.Label();
            this.labelDescriptionStudent = new System.Windows.Forms.Label();
            this.labelDescriptionRoom = new System.Windows.Forms.Label();
            this.labelDescriptionFloor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescriptionDorms = new System.Windows.Forms.Label();
            this.labelDescriptionEstates = new System.Windows.Forms.Label();
            this.labelGenerationRate = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.pictureBoxStudents = new System.Windows.Forms.PictureBox();
            this.pictureBoxRooms = new System.Windows.Forms.PictureBox();
            this.pictureBoxFloors = new System.Windows.Forms.PictureBox();
            this.pictureBoxDorms = new System.Windows.Forms.PictureBox();
            this.pictureBoxEstates = new System.Windows.Forms.PictureBox();
            this.toolStripUpgrade = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonUpgrade = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDorms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstates)).BeginInit();
            this.toolStripUpgrade.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonBuyRooms
            // 
            this.buttonBuyRooms.Location = new System.Drawing.Point(298, 225);
            this.buttonBuyRooms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuyRooms.Name = "buttonBuyRooms";
            this.buttonBuyRooms.Size = new System.Drawing.Size(110, 32);
            this.buttonBuyRooms.TabIndex = 0;
            this.buttonBuyRooms.Text = "Buy Rooms";
            this.buttonBuyRooms.UseVisualStyleBackColor = true;
            this.buttonBuyRooms.Click += new System.EventHandler(this.ButtonBuyRooms_Click);
            // 
            // buttonBuyFloors
            // 
            this.buttonBuyFloors.Location = new System.Drawing.Point(463, 225);
            this.buttonBuyFloors.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuyFloors.Name = "buttonBuyFloors";
            this.buttonBuyFloors.Size = new System.Drawing.Size(110, 32);
            this.buttonBuyFloors.TabIndex = 1;
            this.buttonBuyFloors.Text = "Buy Floors";
            this.buttonBuyFloors.UseVisualStyleBackColor = true;
            this.buttonBuyFloors.Click += new System.EventHandler(this.ButtonBuyFloors_Click);
            // 
            // buttonBuyDorms
            // 
            this.buttonBuyDorms.Location = new System.Drawing.Point(628, 225);
            this.buttonBuyDorms.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuyDorms.Name = "buttonBuyDorms";
            this.buttonBuyDorms.Size = new System.Drawing.Size(110, 32);
            this.buttonBuyDorms.TabIndex = 2;
            this.buttonBuyDorms.Text = "Buy Dorms";
            this.buttonBuyDorms.UseVisualStyleBackColor = true;
            this.buttonBuyDorms.Click += new System.EventHandler(this.ButtonBuyDorms_Click);
            // 
            // buttonBuyEstates
            // 
            this.buttonBuyEstates.Location = new System.Drawing.Point(793, 225);
            this.buttonBuyEstates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonBuyEstates.Name = "buttonBuyEstates";
            this.buttonBuyEstates.Size = new System.Drawing.Size(110, 32);
            this.buttonBuyEstates.TabIndex = 3;
            this.buttonBuyEstates.Text = "Buy Estates";
            this.buttonBuyEstates.UseVisualStyleBackColor = true;
            this.buttonBuyEstates.Click += new System.EventHandler(this.ButtonBuyEstates_Click);
            // 
            // labelRooms
            // 
            this.labelRooms.Location = new System.Drawing.Point(298, 267);
            this.labelRooms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(110, 42);
            this.labelRooms.TabIndex = 4;
            this.labelRooms.Text = "0";
            // 
            // labelFloors
            // 
            this.labelFloors.Location = new System.Drawing.Point(463, 267);
            this.labelFloors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFloors.Name = "labelFloors";
            this.labelFloors.Size = new System.Drawing.Size(110, 42);
            this.labelFloors.TabIndex = 5;
            this.labelFloors.Text = "0";
            // 
            // labelDorms
            // 
            this.labelDorms.Location = new System.Drawing.Point(628, 267);
            this.labelDorms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDorms.Name = "labelDorms";
            this.labelDorms.Size = new System.Drawing.Size(110, 42);
            this.labelDorms.TabIndex = 6;
            this.labelDorms.Text = "0";
            // 
            // labelEstates
            // 
            this.labelEstates.Location = new System.Drawing.Point(793, 267);
            this.labelEstates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEstates.Name = "labelEstates";
            this.labelEstates.Size = new System.Drawing.Size(110, 42);
            this.labelEstates.TabIndex = 7;
            this.labelEstates.Text = "0";
            // 
            // timerRefresh
            // 
            this.timerRefresh.Interval = 1000;
            this.timerRefresh.Tick += new System.EventHandler(this.TimerRefresh_Tick);
            // 
            // buttonChangeMode
            // 
            this.buttonChangeMode.Location = new System.Drawing.Point(18, 389);
            this.buttonChangeMode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonChangeMode.Name = "buttonChangeMode";
            this.buttonChangeMode.Size = new System.Drawing.Size(238, 35);
            this.buttonChangeMode.TabIndex = 8;
            this.buttonChangeMode.Text = "Buying mode: Single";
            this.buttonChangeMode.UseVisualStyleBackColor = true;
            this.buttonChangeMode.Click += new System.EventHandler(this.ButtonChangeMode_Click);
            // 
            // labelStudents
            // 
            this.labelStudents.AutoSize = true;
            this.labelStudents.Location = new System.Drawing.Point(133, 267);
            this.labelStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudents.Name = "labelStudents";
            this.labelStudents.Size = new System.Drawing.Size(18, 20);
            this.labelStudents.TabIndex = 9;
            this.labelStudents.Text = "0";
            // 
            // labelRoomGenerationRate
            // 
            this.labelRoomGenerationRate.AutoSize = true;
            this.labelRoomGenerationRate.Location = new System.Drawing.Point(298, 173);
            this.labelRoomGenerationRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoomGenerationRate.Name = "labelRoomGenerationRate";
            this.labelRoomGenerationRate.Size = new System.Drawing.Size(18, 20);
            this.labelRoomGenerationRate.TabIndex = 16;
            this.labelRoomGenerationRate.Text = "0";
            // 
            // labelFloorGenerationRate
            // 
            this.labelFloorGenerationRate.AutoSize = true;
            this.labelFloorGenerationRate.Location = new System.Drawing.Point(463, 173);
            this.labelFloorGenerationRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFloorGenerationRate.Name = "labelFloorGenerationRate";
            this.labelFloorGenerationRate.Size = new System.Drawing.Size(18, 20);
            this.labelFloorGenerationRate.TabIndex = 17;
            this.labelFloorGenerationRate.Text = "0";
            // 
            // labelDormGenerationRate
            // 
            this.labelDormGenerationRate.AutoSize = true;
            this.labelDormGenerationRate.Location = new System.Drawing.Point(628, 173);
            this.labelDormGenerationRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDormGenerationRate.Name = "labelDormGenerationRate";
            this.labelDormGenerationRate.Size = new System.Drawing.Size(18, 20);
            this.labelDormGenerationRate.TabIndex = 18;
            this.labelDormGenerationRate.Text = "0";
            // 
            // labelStudentGenerationRate
            // 
            this.labelStudentGenerationRate.AutoSize = true;
            this.labelStudentGenerationRate.Location = new System.Drawing.Point(133, 173);
            this.labelStudentGenerationRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStudentGenerationRate.Name = "labelStudentGenerationRate";
            this.labelStudentGenerationRate.Size = new System.Drawing.Size(18, 20);
            this.labelStudentGenerationRate.TabIndex = 19;
            this.labelStudentGenerationRate.Text = "0";
            // 
            // labelDescriptionStudent
            // 
            this.labelDescriptionStudent.AutoSize = true;
            this.labelDescriptionStudent.Location = new System.Drawing.Point(133, 126);
            this.labelDescriptionStudent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionStudent.Name = "labelDescriptionStudent";
            this.labelDescriptionStudent.Size = new System.Drawing.Size(74, 20);
            this.labelDescriptionStudent.TabIndex = 21;
            this.labelDescriptionStudent.Text = "Students";
            // 
            // labelDescriptionRoom
            // 
            this.labelDescriptionRoom.AutoSize = true;
            this.labelDescriptionRoom.Location = new System.Drawing.Point(298, 126);
            this.labelDescriptionRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionRoom.Name = "labelDescriptionRoom";
            this.labelDescriptionRoom.Size = new System.Drawing.Size(60, 20);
            this.labelDescriptionRoom.TabIndex = 22;
            this.labelDescriptionRoom.Text = "Rooms";
            // 
            // labelDescriptionFloor
            // 
            this.labelDescriptionFloor.AutoSize = true;
            this.labelDescriptionFloor.Location = new System.Drawing.Point(463, 126);
            this.labelDescriptionFloor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionFloor.Name = "labelDescriptionFloor";
            this.labelDescriptionFloor.Size = new System.Drawing.Size(53, 20);
            this.labelDescriptionFloor.TabIndex = 23;
            this.labelDescriptionFloor.Text = "Floors";
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
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionFloor, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelStudentGenerationRate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelStudents, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionRoom, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDormGenerationRate, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelEstates, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelRoomGenerationRate, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelDorms, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelFloorGenerationRate, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelRooms, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelFloors, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyEstates, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyDorms, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyFloors, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonBuyRooms, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionDorms, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionEstates, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelGenerationRate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelAmount, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelDescriptionStudent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxStudents, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxRooms, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxFloors, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxDorms, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBoxEstates, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(957, 317);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // labelDescriptionDorms
            // 
            this.labelDescriptionDorms.AutoSize = true;
            this.labelDescriptionDorms.Location = new System.Drawing.Point(628, 126);
            this.labelDescriptionDorms.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionDorms.Name = "labelDescriptionDorms";
            this.labelDescriptionDorms.Size = new System.Drawing.Size(56, 20);
            this.labelDescriptionDorms.TabIndex = 24;
            this.labelDescriptionDorms.Text = "Dorms";
            // 
            // labelDescriptionEstates
            // 
            this.labelDescriptionEstates.AutoSize = true;
            this.labelDescriptionEstates.Location = new System.Drawing.Point(793, 126);
            this.labelDescriptionEstates.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescriptionEstates.Name = "labelDescriptionEstates";
            this.labelDescriptionEstates.Size = new System.Drawing.Size(64, 20);
            this.labelDescriptionEstates.TabIndex = 25;
            this.labelDescriptionEstates.Text = "Estates";
            // 
            // labelGenerationRate
            // 
            this.labelGenerationRate.AutoSize = true;
            this.labelGenerationRate.Location = new System.Drawing.Point(4, 173);
            this.labelGenerationRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGenerationRate.Name = "labelGenerationRate";
            this.labelGenerationRate.Size = new System.Drawing.Size(121, 20);
            this.labelGenerationRate.TabIndex = 26;
            this.labelGenerationRate.Text = "Generation rate";
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.Location = new System.Drawing.Point(4, 267);
            this.labelAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(120, 20);
            this.labelAmount.TabIndex = 27;
            this.labelAmount.Text = "Current amount";
            // 
            // pictureBoxStudents
            // 
            this.pictureBoxStudents.Image = global::LukaszDrozdzLab1Homework.Properties.Resources.Student;
            this.pictureBoxStudents.Location = new System.Drawing.Point(132, 3);
            this.pictureBoxStudents.Name = "pictureBoxStudents";
            this.pictureBoxStudents.Size = new System.Drawing.Size(159, 120);
            this.pictureBoxStudents.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxStudents.TabIndex = 28;
            this.pictureBoxStudents.TabStop = false;
            // 
            // pictureBoxRooms
            // 
            this.pictureBoxRooms.Image = global::LukaszDrozdzLab1Homework.Properties.Resources.Room;
            this.pictureBoxRooms.Location = new System.Drawing.Point(297, 3);
            this.pictureBoxRooms.Name = "pictureBoxRooms";
            this.pictureBoxRooms.Size = new System.Drawing.Size(159, 120);
            this.pictureBoxRooms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRooms.TabIndex = 29;
            this.pictureBoxRooms.TabStop = false;
            // 
            // pictureBoxFloors
            // 
            this.pictureBoxFloors.Image = global::LukaszDrozdzLab1Homework.Properties.Resources.Floor;
            this.pictureBoxFloors.Location = new System.Drawing.Point(462, 3);
            this.pictureBoxFloors.Name = "pictureBoxFloors";
            this.pictureBoxFloors.Size = new System.Drawing.Size(159, 120);
            this.pictureBoxFloors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFloors.TabIndex = 30;
            this.pictureBoxFloors.TabStop = false;
            // 
            // pictureBoxDorms
            // 
            this.pictureBoxDorms.Image = global::LukaszDrozdzLab1Homework.Properties.Resources.Dorm;
            this.pictureBoxDorms.Location = new System.Drawing.Point(627, 3);
            this.pictureBoxDorms.Name = "pictureBoxDorms";
            this.pictureBoxDorms.Size = new System.Drawing.Size(159, 120);
            this.pictureBoxDorms.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDorms.TabIndex = 31;
            this.pictureBoxDorms.TabStop = false;
            // 
            // pictureBoxEstates
            // 
            this.pictureBoxEstates.Image = global::LukaszDrozdzLab1Homework.Properties.Resources.Estate;
            this.pictureBoxEstates.Location = new System.Drawing.Point(792, 3);
            this.pictureBoxEstates.Name = "pictureBoxEstates";
            this.pictureBoxEstates.Size = new System.Drawing.Size(162, 120);
            this.pictureBoxEstates.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEstates.TabIndex = 32;
            this.pictureBoxEstates.TabStop = false;
            // 
            // toolStripUpgrade
            // 
            this.toolStripUpgrade.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStripUpgrade.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonUpgrade,
            this.toolStripButtonAbout});
            this.toolStripUpgrade.Location = new System.Drawing.Point(0, 0);
            this.toolStripUpgrade.Name = "toolStripUpgrade";
            this.toolStripUpgrade.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripUpgrade.Size = new System.Drawing.Size(1050, 32);
            this.toolStripUpgrade.TabIndex = 15;
            this.toolStripUpgrade.Text = "toolStripMain";
            // 
            // toolStripButtonUpgrade
            // 
            this.toolStripButtonUpgrade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonUpgrade.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpgrade.Image")));
            this.toolStripButtonUpgrade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpgrade.Name = "toolStripButtonUpgrade";
            this.toolStripButtonUpgrade.Size = new System.Drawing.Size(85, 29);
            this.toolStripButtonUpgrade.Text = "Upgrade";
            this.toolStripButtonUpgrade.ToolTipText = "Click to buy upgrades";
            this.toolStripButtonUpgrade.Click += new System.EventHandler(this.ToolStripButtonUpgrade_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(66, 29);
            this.toolStripButtonAbout.Text = "About";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.ToolStripButtonAbout_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 565);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripUpgrade);
            this.Controls.Add(this.buttonChangeMode);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "Dorm Tycoon";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFloors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDorms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEstates)).EndInit();
            this.toolStripUpgrade.ResumeLayout(false);
            this.toolStripUpgrade.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBuyRooms;
        private System.Windows.Forms.Button buttonBuyFloors;
        private System.Windows.Forms.Button buttonBuyDorms;
        private System.Windows.Forms.Button buttonBuyEstates;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelFloors;
        private System.Windows.Forms.Label labelDorms;
        private System.Windows.Forms.Label labelEstates;
        private System.Windows.Forms.Timer timerRefresh;
        private System.Windows.Forms.Button buttonChangeMode;
        private System.Windows.Forms.Label labelStudents;
        private System.Windows.Forms.Label labelRoomGenerationRate;
        private System.Windows.Forms.Label labelFloorGenerationRate;
        private System.Windows.Forms.Label labelDormGenerationRate;
        private System.Windows.Forms.Label labelStudentGenerationRate;
        private System.Windows.Forms.Label labelDescriptionStudent;
        private System.Windows.Forms.Label labelDescriptionRoom;
        private System.Windows.Forms.Label labelDescriptionFloor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip toolStripUpgrade;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpgrade;
        private System.Windows.Forms.Label labelDescriptionDorms;
        private System.Windows.Forms.Label labelDescriptionEstates;
        private System.Windows.Forms.Label labelGenerationRate;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.PictureBox pictureBoxStudents;
        private System.Windows.Forms.PictureBox pictureBoxRooms;
        private System.Windows.Forms.PictureBox pictureBoxFloors;
        private System.Windows.Forms.PictureBox pictureBoxDorms;
        private System.Windows.Forms.PictureBox pictureBoxEstates;
    }
}

