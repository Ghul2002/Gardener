using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Gardener
{
    /// <summary>
    /// Logika interakcji dla klasy CheckPlantWindow.xaml
    /// </summary>
    public partial class CheckPlantWindow : Window
    {
        public CheckPlantWindow(PlantInfo selectedPlant)
        {
            InitializeComponent();

            AddWaterDates(selectedPlant);

            DisplayInfo(selectedPlant);
        }

        private void AddWaterDates(PlantInfo selectedPlant)
        {
            for(int i = 1; i < 52; i++)
            {
                if(DateTime.Now <= selectedPlant.AddDate.AddDays(selectedPlant.WaterTime * i))
                {
                    WaterCalendar.SelectedDates.Add(selectedPlant.AddDate.AddDays(selectedPlant.WaterTime * i));
                }
            }
        }

        private void DisplayInfo(PlantInfo selectedPlant)
        {
            PlantNameTB.Text = $" Your plant: {selectedPlant.Name} \n Added: {selectedPlant.AddDate.ToString("dd/MM/yyyy")}";
            PlantDescTB.Text = $"Description: \n{selectedPlant.Description}";
            WaterAmtTB.Text = $"Amount of water: \n{selectedPlant.WaterAmt} ml";
            if (selectedPlant.WaterTime == 1)
            {
                WaterTimeTB.Text = $"Days between watering: \neveryday";
            }
            else
            {
                WaterTimeTB.Text = $"Days between watering: \n{selectedPlant.WaterTime} days";
            }

            TodayDateTB.Text = $"Today date is {(DateTime.Now.ToString("dd/MM/yyyy"))}";
            var nearestWaterDate = GetWaterDates().FirstOrDefault();
            if ((nearestWaterDate - DateTime.Now).TotalDays < 1)
            {
                TimeToWaterTB.Text = $"Days to water: tomorrow";
            }
            else
            TimeToWaterTB.Text = $"Days to water: {Math.Ceiling((nearestWaterDate - DateTime.Now).TotalDays)} days";
        }

        private List<DateTime> GetWaterDates()
        {
            List<DateTime> waterDates = new List<DateTime>();
            foreach (var date in WaterCalendar.SelectedDates)
            {
                waterDates.Add(date);
            }
            return waterDates;
        }
        private void NextMonthBT_Click(object sender, RoutedEventArgs e)
        {
            WaterCalendar.DisplayDate = WaterCalendar.DisplayDate.Date.AddMonths(1);
        }

        private void PrevMonthBT_Click(object sender, RoutedEventArgs e)
        {
            WaterCalendar.DisplayDate = WaterCalendar.DisplayDate.Date.AddMonths(-1);
        }
    }
}
