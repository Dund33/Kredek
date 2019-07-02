using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    public partial class FormUpdate : Form
    {
        /// <summary>
        /// Enable and disable buttons as needed
        /// </summary>
        private void UpdateButtons()
        {
            buttonUpgradeBaseRate.Enabled = formMain.Rooms.Amount >= formMain.Students.BaseGenerationUpgradeCost;
            buttonUpgradeStudentRate.Enabled = formMain.Rooms.Amount >= formMain.Students.UpdateCost;
            buttonUpgradeRoomRate.Enabled = formMain.Floors.Amount >= formMain.Rooms.UpdateCost;
            buttonUpgradeFloorRate.Enabled = formMain.Dorms.Amount >= formMain.Floors.UpdateCost;
            buttonUpgradeDormRate.Enabled = formMain.Estates.Amount >= formMain.Dorms.UpdateCost;
        }

        /// <summary>
        /// Update displayed values
        /// </summary>
        private void UpdateLabels()
        {
            labelBaseUpgradeCost.Text = formMain.Students.BaseGenerationUpgradeCost.ToString();
            labelStudentUpgradeCost.Text = formMain.Students.UpdateCost.ToString();
            labelRoomUpgradeCost.Text = formMain.Rooms.UpdateCost.ToString();
            labelFloorUpgradeCost.Text = formMain.Floors.UpdateCost.ToString();
            labelDormUpgradeCost.Text = formMain.Dorms.UpdateCost.ToString();
        }

        /// <summary>
        /// Reference to the main form
        /// </summary>
        FormMain formMain;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="formMain"></param>
        public FormUpdate(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
            timerRefresh.Start();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// buttonUpgradeBaseRate event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeBaseRate_Click(object sender, EventArgs e)
        {
            formMain.Students.UpdateBaseRate();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// buttonUpgradeStudentRate event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeStudentRate_Click(object sender, EventArgs e)
        {
            formMain.Students.Upgrade();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// buttonUpgradeRoomRate event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeRoomRate_Click(object sender, EventArgs e)
        {
            formMain.Rooms.Upgrade();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// buttonUpgradeFloorRate event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeFloorRate_Click(object sender, EventArgs e)
        {
            formMain.Floors.Upgrade();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// buttonUpgradeDormRate event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpgradeDormRate_Click(object sender, EventArgs e)
        {
            formMain.Dorms.Upgrade();
            UpdateButtons();
            UpdateLabels();
        }

        /// <summary>
        /// timerRefresh event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            UpdateButtons();
            UpdateLabels();
        }
    }
}
