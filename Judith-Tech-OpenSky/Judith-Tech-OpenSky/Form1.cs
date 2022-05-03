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
        Manager manager = new Manager();
        public Form1()
        {
            InitializeComponent();

            highestFlight_btn.Enabled = false;
            lowestFlight_btn.Enabled = false;
        }

        private void DataHandler_HandlerLoadData()
        {
            if (flights_counter.InvokeRequired)
            {
                flights_counter.Invoke(new Action(() => flights_counter.Text = manager.DataHandler.GetNumOfFlights().ToString()));
                last_update.Invoke(new Action(() => last_update.Text = manager.DataHandler.GetLastUpdate()));
            }

            else
                UpdateControls();
        }

        private void ShowCountries()
        {
            if (countries_list.InvokeRequired)
                countries_list.Invoke(new Action(() => {
                    string[] names = manager.DataHandler.GetCountriesName();
                    foreach (string name in names)
                        countries_list.Items.Add(name);
                }));
            else
                countries_list.Items.Clear();
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            manager.RunAll();
            manager.DataHandler.HandlerLoadData += DataHandler_HandlerLoadData;
            manager.DataHandler.HandlerLoadData += ShowCountries;
            UpdateControls();
            

            //highestFlight_btn.Enabled = true;
            //lowestFlight_btn.Enabled = true;
        }

        private void UpdateControls()
        {
            flights_counter.Text = manager.DataHandler.GetNumOfFlights().ToString();
            last_update.Text = manager.DataHandler.GetLastUpdate();

            countries_list.Items.Clear();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void highestFlight_btn_Click(object sender, EventArgs e)
        {
           
        }
    }
}
