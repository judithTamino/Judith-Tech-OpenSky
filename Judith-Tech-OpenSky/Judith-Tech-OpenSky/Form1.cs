using Judith_Tech_OpenSky.Entities;
using Judith_Tech_OpenSky_Model;
using System;
using System.Windows.Forms;

namespace Judith_Tech_OpenSky
{
    public partial class Form1 : Form
    {
        Manager manager = new Manager();
        private object MyLocker = new object();
        public Form1()
        {
            InitializeComponent();
            refresh_btn.Enabled = false;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            manager.RunAll();

            manager.DataHandler.HandlerLoadData += ShowFlightsCoundAndDate;
            manager.DataHandler.HandlerLoadData += ShowCountries;
            manager.DataHandler.HandlerLoadData += ShowTopFiveCountries;
            manager.DataHandler.HandlerLoadData += ShowHighestAndLowestFlights;
            manager.DataHandler.HandlerLoadData += ActivateBtn;

            UpdateControls();

            start_btn.Enabled = false;
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            manager.DataHandler.isGetFlightDataRunning = false;
            start_btn.Enabled = true;
        }

        private void ShowFlightsCoundAndDate()
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
                countries_list.Invoke(new Action(() =>
                {
                    lock (MyLocker)
                    {
                        countries_list.Items.Clear();

                        string[] names = manager.DataHandler.GetCountriesName();
                        foreach (string name in names)
                            countries_list.Items.Add(name);
                    }
                }));
            else UpdateControls();
        }

        private void ShowTopFiveCountries()
        {
            if (top_five.InvokeRequired)
                top_five.Invoke(new Action(() =>
                {
                    lock (MyLocker)
                    {
                        top_five.Items.Clear();

                        string[] topFive = manager.DataHandler.TopFiveCountries();
                        foreach (string name in topFive)
                            top_five.Items.Add(name);
                    }
                }));
            else UpdateControls();
        }

        private void ShowHighestAndLowestFlights()
        {
            if (highest_flight.InvokeRequired)
                highest_flight.Invoke(new Action(() =>
                {
                    lock (MyLocker)
                    {
                        highest_flight.Items.Clear();
                        lowest_flight.Items.Clear();

                        string highestFlightId = manager.DataHandler.GetHighestFlightId();
                        ShowFlightsDetails(highestFlightId, highest_flight);

                        string lowestFlightId = manager.DataHandler.GetLowestFlightId();
                        ShowFlightsDetails(lowestFlightId, lowest_flight);
                    }
                }));

            else UpdateControls();
        }



        private void UpdateControls()
        {
            flights_counter.Text = "Loading...";
            last_update.Text = "Loading...";

            countries_list.Items.Clear();
            top_five.Items.Clear();

            highest_flight.Items.Clear();
            lowest_flight.Items.Clear();
        }

        private void ShowFlights(FlightDetails[] flightDetails)
        {
            flights.Items.Clear();

            // check if array ia empty
            if (flightDetails.Length == 0)
                MessageBox.Show("No Data");

            foreach (var flight in flightDetails)
                flights.Items.Add(new ListItem { Name = flight._origin_country, Value = flight._id });
        }

        private void ShowFlightsDetails(string flightId, ListBox details)
        {
            var flightDetails = manager.DataHandler.GetFlightDetails(flightId);

            details.Items.Clear();
            details.Items.Add($"ID\t\t{flightDetails._id}");
            details.Items.Add($"Country\t\t{flightDetails._origin_country}");
            details.Items.Add($"Longitude\t\t{flightDetails._longitude}");
            details.Items.Add($"Latitude\t\t{flightDetails._latitude}");
            details.Items.Add($"Altitude\t\t{flightDetails._baro_altitude}");
        }

        private void ActivateBtn()
        {
            if (refresh_btn.InvokeRequired)
                refresh_btn.Invoke(new Action(() => refresh_btn.Enabled = true));
        }

        private void countries_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            lock (MyLocker)
            {
                string countryName = countries_list.SelectedItem.ToString();
                var countryFlights = manager.DataHandler.GetAllFlightsOfSelectedCountry(countryName);

                ShowFlights(countryFlights);
            }
        }

        private void top_five_SelectedIndexChanged(object sender, EventArgs e)
        {
            string countryName = top_five.SelectedItem.ToString();
            var countryFlights = manager.DataHandler.GetAllFlightsOfSelectedCountry(countryName);

            ShowFlights(countryFlights);
        }

        private void flights_SelectedIndexChanged(object sender, EventArgs e)
        {
            lock (MyLocker)
            {
                string flightSelected = ((ListItem)flights.SelectedItem).Value;
                ShowFlightsDetails(flightSelected, flights_details);
            }

        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            float Top = float.Parse(top.Text),
                Bottom = float.Parse(bottom.Text),
                Left = float.Parse(left.Text),
                Right = float.Parse(right.Text);

            var flightsList = manager.DataHandler.Refresh(Top, Bottom, Left, Right);
            ShowFlights(flightsList);
        }
    }
}
