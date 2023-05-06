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

            DisplayInfo(selectedPlant);

            AddWaterDates(selectedPlant);
        }

        private void AddWaterDates(PlantInfo selectedPlant)
        {
            for(int i = 1; i < 100; i++)
            {
                WaterCalendar.SelectedDates.Add(selectedPlant.AddDate.AddDays(selectedPlant.WaterTime * i));
            }
        }

        private void DisplayInfo(PlantInfo selectedPlant)
        {
            PlantNameTB.Text = $"Your plant: {selectedPlant.Name}";
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
            TimeToWaterTB.Text = $"Days to water: WIP";
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
