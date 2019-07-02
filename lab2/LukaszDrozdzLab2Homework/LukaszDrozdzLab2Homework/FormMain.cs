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
    public partial class FormMain : Form
    {
        /// <summary>
        /// Students resource object
        /// </summary>
        public Student Students;

        /// <summary>
        /// Rooms resource object
        /// </summary>
        public Room Rooms;

        /// <summary>
        /// Floors resource object
        /// </summary>
        public Floor Floors;

        /// <summary>
        /// Dorms resource object
        /// </summary>
        public Dorm Dorms;

        /// <summary>
        /// Estates resource object
        /// </summary>
        public Estate Estates;

        /// <summary>
        /// The list of events
        /// </summary>
        private List<Event> events;

        /// <summary>
        /// List of resources
        /// </summary>
        private List<Resource> resources;

        /// <summary>
        /// Updates the resources, buttons and displayed values
        /// </summary>
        private void UpdateResources(){

            foreach(Resource resource in resources)
            {
                resource.RefreshLabels();
                resource.RefreshButtons();
                if (resource is IGenerated)
                {
                    resource.RefreshAmount();
                }

            }

        }

        /// <summary>
        /// Initializes the resources
        /// </summary>
        private void InitResources()
        {
            //Link higher and lower tier resources
            Students.HigherTierResource = Rooms;
            Rooms.LowerTierResource = Students;
            Rooms.HigherTierResource = Floors;
            Floors.LowerTierResource = Rooms;
            Floors.HigherTierResource = Dorms;
            Dorms.LowerTierResource = Floors;
            Dorms.HigherTierResource = Estates;
            Estates.LowerTierResource = Dorms;

            //Link labels and buttons
            Students.GenerationLabel = labelStudentGenerationRate;
            Students.NumberLabel = labelNumberOfStudents;
            Students.ResourceButton = null;

            Rooms.GenerationLabel = labelRoomsGenerationRate;
            Rooms.NumberLabel = labelNumberOfRooms;
            Rooms.ResourceButton = buttonBuyRooms;

            Floors.GenerationLabel = labelFloorsGenerationRate;
            Floors.NumberLabel = labelNumberOfFloors;
            Floors.ResourceButton = buttonBuyFloors;

            Dorms.GenerationLabel = labelDormsGenerationRate;
            Dorms.NumberLabel = labelNumberOfDorms;
            Dorms.ResourceButton = buttonBuyDorms;

            Estates.GenerationLabel = null;
            Estates.NumberLabel = labelNumberOfEstates;
            Estates.ResourceButton = buttonBuyEstates;
           
        }

        /// <summary>
        /// Checks if any event should take place
        /// </summary>
        private void CheckEvents()
        {
            foreach(Event e in events)
            {
                e.CheckConditions();
            }
        }

        /// <summary>
        /// Redraws the chart using current data
        /// </summary>
        private void UpdateChart()
        {
            chartPropertyStructure.Series.Clear();

            var newSeries = new System.Windows.Forms.DataVisualization.Charting.Series
            {
                Name = "Property",
                IsXValueIndexed = true,
                ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
            };

            //Chart mumbo-jumbo
            chartPropertyStructure.Series.Add(newSeries);
            chartPropertyStructure.Series["Property"]["PieLabelStyle"] = "Outside";
            chartPropertyStructure.Series["Property"].Points.AddXY("Estates", Estates.Amount);
            chartPropertyStructure.Series["Property"].Points.AddXY("Dorms", Dorms.Amount);
            chartPropertyStructure.Series["Property"].Points.AddXY("Floors", Floors.Amount);
            chartPropertyStructure.Series["Property"].Points.AddXY("Rooms", Rooms.Amount);
            chartPropertyStructure.Series["Property"].Points.AddXY("Student", Students.Amount);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            resources = new List<Resource>();

            //Creating resource containers
            Students = new Student(100, 1, 1, 4, 5);
            Rooms = new Room(0, 1, 3, 5);
            Floors = new Floor(0, 1, 10, 5);
            Dorms = new Dorm(0, 1, 10, 5);
            Estates = new Estate(0, 10);

            resources.Add(Students);
            resources.Add(Rooms);
            resources.Add(Floors);
            resources.Add(Dorms);
            resources.Add(Estates);

            //Adding new events
            events = new List<Event>();
            events.Add(new ConditionalEvent(Rooms,"Too many rooms are vacant","You lose 70% of you rooms", 0.7f, 100000));
            events.Add(new ConditionalEvent(Students, "Overpopulation!","You lose 90% of your students", 0.9f, 1000000));
            events.Add(new RandomEvent(Rooms, "Exams!", "Students fail and move out!", 0.6f, 0.01f));
            events.Add(new RandomEvent(Students, "Mathematical analysis", "No description needed...", 0.6f, 0.01f));

            //Starting the timer and updating the chart
            timerMain.Start();
            InitResources();
            UpdateChart();

        }

        /// <summary>
        /// Main time tick event listener
        /// </summary>
        private void timerMain_Tick(object sender, EventArgs e)
        {
            UpdateResources();
            CheckEvents();
            UpdateChart();
        }

        /// <summary>
        /// buttonBuyRooms event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyRooms_Click(object sender, EventArgs e)
        {
            Rooms.Buy();
            Rooms.RefreshButtons();
            Rooms.RefreshLabels();
            Students.RefreshLabels();
        }

        /// <summary>
        /// buttonBuyFloors event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFloors_Click(object sender, EventArgs e)
        {
            Floors.Buy();
            Floors.RefreshButtons();
            Floors.RefreshLabels();
            Rooms.RefreshLabels();
        }

        /// <summary>
        /// buttonBuyDorms event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyDorms_Click(object sender, EventArgs e)
        {
            Dorms.Buy();
            Dorms.RefreshButtons();
            Dorms.RefreshLabels();
            Floors.RefreshLabels();
        }

        /// <summary>
        /// buttonBuyEstates event listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyEstates_Click(object sender, EventArgs e)
        {
            Estates.Buy();
            Estates.RefreshButtons();
            Estates.RefreshLabels();
            Dorms.RefreshLabels();
        }

        /// <summary>
        /// toolStripUpgrade action listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripUpgrade_Click(object sender, EventArgs e)
        {
            //Show the form
            FormUpdate formUpdate = new FormUpdate(this);
            formUpdate.Show();
        }

        /// <summary>
        /// toolStripLabelAbout action listener
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripLabelAbout_Click(object sender, EventArgs e)
        {
            //Show the form
            FormAbout formAbout = new FormAbout();
            formAbout.Show();
        }
    }
}
