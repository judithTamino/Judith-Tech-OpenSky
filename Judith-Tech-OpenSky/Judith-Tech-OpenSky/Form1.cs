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

        private void start_btn_Click(object sender, EventArgs e)
        {
            manager.RunAll();

            manager.DataHandler.HandlerLoadData += DataHandler_HandlerLoadData;
            manager.DataHandler.HandlerLoadData += ShowCountries;
            manager.DataHandler.HandlerLoadData += ShowTopFiveCountries;
            manager.DataHandler.HandlerLoadData += ActivateBtn;

            UpdateControls();
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

                    countries_list.Items.Clear();

                    string[] names = manager.DataHandler.GetCountriesName();
                    foreach (string name in names)
                        countries_list.Items.Add(name);
                }));
            else
                countries_list.Items.Clear();
       }

        private void ShowTopFiveCountries()
        {
            if (top_five.InvokeRequired)
                top_five.Invoke(new Action(() =>
                {
                    top_five.Items.Clear();

                    string[] topFive = manager.DataHandler.TopFiveCountries();
                    foreach (string name in topFive)
                        top_five.Items.Add(name);
                }));
        }

        private void UpdateControls()
        {
            flights_counter.Text = manager.DataHandler.GetNumOfFlights().ToString();
            last_update.Text = "xx/xx/xxxx xx:xx:xx";

            countries_list.Items.Clear();
            top_five.Items.Clear();
        }

        private void ShowCountriesFlights(string country)
        {
            flights.Items.Clear();

            var countryFlights = manager.DataHandler.GetAllFlightsOfSelectedCountry(country);
            foreach (var flight in countryFlights)
                flights.Items.Add(new ListItem { Name = flight._origin_country, Value = flight._id });
        }

        private void ShowFlightsDetails(string flightId)
        {
            var flightDetails = manager.DataHandler.GetFlightDetails(flightId);

            flights_details.Items.Clear();
            flights_details.Items.Add(flightDetails._id);
            flights_details.Items.Add(flightDetails._origin_country);
            flights_details.Items.Add(flightDetails._longitude);
            flights_details.Items.Add(flightDetails._latitude);
            flights_details.Items.Add(flightDetails._baro_altitude);
        }

        private void countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryName = countries_list.SelectedItem.ToString();
            ShowCountriesFlights(countryName);
        }

        private void top_five_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = top_five.SelectedItem.ToString();
            ShowCountriesFlights(name);
        }

        private void flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            string flightSelected = ((ListItem)flights.SelectedItem).Value;
            ShowFlightsDetails(flightSelected);
        }

        private void highestFlight_btn_Click(object sender, EventArgs e)
        {
            string flightId = manager.DataHandler.GetHighestFlightId();
            ShowFlightsDetails(flightId);
        }

        private void lowestFlight_btn_Click(object sender, EventArgs e)
        {
            string flightId = manager.DataHandler.GetLowestFlightId();
            ShowFlightsDetails(flightId);
        }


        private void ActivateBtn()
        {
            if (highestFlight_btn.InvokeRequired)
                highestFlight_btn.Invoke(new Action(() =>
                {
                    highestFlight_btn.Enabled = true;
                    lowestFlight_btn.Enabled = true;
                }));
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            manager.DataHandler.isGetFlightDataRunning = false;
        }
    }
}
