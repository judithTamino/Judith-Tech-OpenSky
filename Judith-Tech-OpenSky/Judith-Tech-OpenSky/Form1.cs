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
            manager.GetFlightData();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            label3.Text = manager.flightsCounter().ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
