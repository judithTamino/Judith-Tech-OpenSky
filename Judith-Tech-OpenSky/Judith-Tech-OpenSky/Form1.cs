using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Judith_Tech_OpenSky.Entities;

namespace Judith_Tech_OpenSky
{
    public partial class Form1 : Form
    {
        FlightManager manager = new FlightManager();
        public Form1()
        {
            InitializeComponent();

            highestFlight_btn.Enabled = false;
            lowestFlight_btn.Enabled = false;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            Task task_running = manager.GetFlightData();

            highestFlight_btn.Enabled = true;
            lowestFlight_btn.Enabled = true;
        }

        private void ChangeFlightsCounter(Task task_running)
        {
            while (task_running.Status == TaskStatus.Running)
            {
                flights_counter.Text = manager.flightsCounter().ToString();
            }
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void highestFlight_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
