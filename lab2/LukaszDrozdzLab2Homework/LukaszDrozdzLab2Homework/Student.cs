using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukaszDrozdzLab2Homework
{
    public class Student : Resource, IGenerated
    {
        /// <summary>
        /// Basic generation rate
        /// </summary>
        private double baseGenerationRate;
        /// <summary>
        /// Base generation rate upgrade cost
        /// </summary>
        public uint BaseGenerationUpgradeCost { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Student(uint initialAmount, uint generationRate, uint baseGenerationRate, uint updateCost, uint baseUpdateCost)
            :base(initialAmount, generationRate, 0, updateCost)
        {
            this.baseGenerationRate = baseGenerationRate;
            this.BaseGenerationUpgradeCost = baseUpdateCost;
        }

        //We have to consider base generation rate too
        public override void RefreshAmount()
        {
            Amount += (uint)Math.Round(generationRate * HigherTierResource.Amount + baseGenerationRate);
        }


        /// <summary>
        /// Upgrades base generation rate
        /// </summary>
        public void UpdateBaseRate()
        {
            HigherTierResource.Amount -= BaseGenerationUpgradeCost;
            baseGenerationRate = (uint)Math.Ceiling(baseGenerationRate * 1.25f);
            BaseGenerationUpgradeCost = (uint)Math.Ceiling(BaseGenerationUpgradeCost * 1.25f);
        }

        //We have to consider base generation rate too
        public override void RefreshLabels()
        {
            NumberLabel.Text = Amount.ToString();
            GenerationLabel.Text = Math.Round(generationRate * HigherTierResource.Amount + baseGenerationRate).ToString();
        }

        //Theres no button for buying students
        public override void RefreshButtons()
        {
           //Do nothing
        }

        //We cant buy students
        public override void Buy()
        {
            //Do nothing
        }
    }
}
