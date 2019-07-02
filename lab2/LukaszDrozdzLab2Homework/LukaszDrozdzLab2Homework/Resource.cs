using System;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    /// <summary>
    /// Generic resource class
    /// </summary>
    public abstract class Resource
    {
        /// <summary>
        /// The amount of the resource
        /// </summary>
        public uint Amount { get; set; }

        /// <summary>
        /// Reference to lower tier resource
        /// </summary>
        public Resource LowerTierResource { get; set; }

        /// <summary>
        /// Reference to higher tier resource
        /// </summary>
        public Resource HigherTierResource { get; set; }

        /// <summary>
        /// Label used to display the current amount of resources
        /// </summary>
        public Label NumberLabel { get; set; }

        /// <summary>
        /// Label used to display the current generation rate
        /// </summary>
        public Label GenerationLabel { get; set; }

        /// <summary>
        /// Button used to buy the resource
        /// </summary>
        public Button ResourceButton { get; set; }

        /// <summary>
        /// Cost of the resource
        /// </summary>
        protected uint cost;

        /// <summary>
        /// Generation rate of the resource
        /// </summary>
        protected uint generationRate;

        /// <summary>
        /// Cost of updating the generation rate
        /// </summary>
        public uint UpdateCost { get; set; }

       
        /// <summary>
        /// Function used for buying the resource
        /// </summary>
        public virtual void Buy()
        {
            LowerTierResource.Amount -= cost;
            Amount++;
        }


        /// <summary>
        /// Upgrade the generation rate
        /// </summary>
        public virtual void Upgrade()
        {
            HigherTierResource.Amount -= UpdateCost;
            generationRate = (uint)Math.Ceiling(generationRate * 1.25f);
            UpdateCost = (uint)Math.Ceiling(UpdateCost * 1.25f);
        }

        /// <summary>
        /// Recalculate the amount of resources
        /// </summary>
        public virtual void RefreshAmount()
        {
            Amount += generationRate * HigherTierResource.Amount;
        }

        /// <summary>
        /// Enable and disable the buttons as needed
        /// </summary>
        public virtual void RefreshButtons()
        {
            ResourceButton.Enabled = LowerTierResource.Amount >= cost;
        }

        /// <summary>
        /// Refresh the labels
        /// </summary>
        public virtual void RefreshLabels()
        {
            NumberLabel.Text = Amount.ToString();
            GenerationLabel.Text = (generationRate * HigherTierResource.Amount).ToString();
        }

        /// <summary>
        /// Csontructor
        /// </summary>
        public Resource(uint initialAmount, uint generationRate, uint cost, uint updateCost)
        {
            Amount = initialAmount;
            this.generationRate = generationRate;
            this.cost = cost;
            this.UpdateCost = updateCost;
        }

    }
}
