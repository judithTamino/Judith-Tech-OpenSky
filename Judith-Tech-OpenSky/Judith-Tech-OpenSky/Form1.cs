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
using Judith_Tech_OpenSky_Model;

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

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void highestFlight_btn_Click(object sender, EventArgs e)
        {
            var highestFlight = manager.HighestFlight();

            flights_details.Items.Add(highestFlight.id);
            flights_details.Items.Add(highestFlight.origin_country);
            flights_details.Items.Add(highestFlight.latitude);
            flights_details.Items.Add(highestFlight.longitude);
            flights_details.Items.Add(highestFlight.baro_altitude);
        }
    }
}
