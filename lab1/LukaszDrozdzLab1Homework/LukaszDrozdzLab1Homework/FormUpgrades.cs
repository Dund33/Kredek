using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab1Homework
{
    public partial class FormUpgrades : Form
    {
        private FormMain mainForm;

        /// <summary>
        /// Disables and enables the buttons as needed.
        /// </summary>
        private void UpdateButtons()
        {
            buttonUpgradeStudentBaseRate.Enabled = mainForm.Rooms >= mainForm.BaseStudentGenerationUpgradeCost;
            buttonUpgradeStudentRate.Enabled = mainForm.Rooms >= mainForm.StudentGenerationUpgradeCost;
            buttonUpgradeRoomRate.Enabled = mainForm.Floors >= mainForm.RoomGenerationUpgradeCost;
            buttonUpgradeFloorRate.Enabled = mainForm.Dorms >= mainForm.FloorGenerationUpgradeCost;
            buttonUpgradeDormRate.Enabled = mainForm.Estates >= mainForm.DormGenerationUpgradeCost;
        }

        /// <summary>
        /// Updates the displayed values.
        /// </summary>
        private void UpdateDisplay()
        {
            labelStudenBaseRateUpgradeCost.Text = mainForm.BaseStudentGenerationUpgradeCost.ToString();
            labelStudentRateUpgradeCost.Text = mainForm.StudentGenerationUpgradeCost.ToString();
            labelRoomRateUpgradeCost.Text = mainForm.RoomGenerationUpgradeCost.ToString();
            labelFloorRateUpgradeCost.Text = mainForm.FloorGenerationUpgradeCost.ToString();
            labelDormRateUpgradeCost.Text = mainForm.DormGenerationUpgradeCost.ToString();
        }

        /// <summary>
        /// Creates new object of the type FormUpgrades
        /// </summary>
        /// <param name="main">Parent form</param>
        public FormUpgrades(FormMain main)
        {
            InitializeComponent();
            mainForm = main;
            UpdateButtons();
            UpdateDisplay();
            timerRefresh.Start();
        }

        /// <summary>
        /// Upgrades student base generation rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeStudentBaseRate_Click(object sender, EventArgs e)
        {
            mainForm.StudentBaseGenerationRate = Math.Round(mainForm.StudentBaseGenerationRate * 1.25, 2);
            mainForm.Rooms -= mainForm.BaseStudentGenerationUpgradeCost;
            mainForm.BaseStudentGenerationUpgradeCost *= 2;
            UpdateDisplay();
            UpdateButtons();
        }

        /// <summary>
        /// Upgrades student generation rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeStudentRate_Click(object sender, EventArgs e)
        {
            mainForm.StudentBaseGenerationRate = Math.Round(mainForm.StudentGenerationRate * 1.25, 2);
            mainForm.Rooms -= mainForm.StudentGenerationUpgradeCost;
            mainForm.StudentGenerationUpgradeCost *= 2;
            UpdateDisplay();
            UpdateButtons();
        }

        /// <summary>
        /// Upgrades room generation rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeRoomRate_Click(object sender, EventArgs e)
        {
            mainForm.StudentBaseGenerationRate = Math.Round(mainForm.RoomGenerationRate * 1.25, 2);
            mainForm.Floors -= mainForm.RoomGenerationUpgradeCost;
            mainForm.FloorGenerationUpgradeCost *= 2;
            UpdateDisplay();
            UpdateButtons();
        }

        /// <summary>
        /// Upgrades floor generation rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeFloorRate_Click(object sender, EventArgs e)
        {
            mainForm.StudentBaseGenerationRate = Math.Round(mainForm.FloorGenerationRate * 1.25, 2);
            mainForm.Dorms -= mainForm.FloorGenerationUpgradeCost;
            mainForm.FloorGenerationUpgradeCost *= 2;
            UpdateDisplay();
            UpdateButtons();
        }

        /// <summary>
        /// Upgrades dorm generation rate.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUpgradeDormRate_Click(object sender, EventArgs e)
        {
            mainForm.StudentBaseGenerationRate = Math.Round(mainForm.DormGenerationRate * 1.25, 2);
            mainForm.Estates -= mainForm.DormGenerationUpgradeCost;
            mainForm.DormGenerationUpgradeCost *= 2;
            UpdateDisplay();
            UpdateButtons();
        }

        /// <summary>
        /// Updates the buttons and the display.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TimerRefresh_Tick(object sender, EventArgs e)
        {
            UpdateDisplay();
            UpdateButtons();
        }
    }
}
