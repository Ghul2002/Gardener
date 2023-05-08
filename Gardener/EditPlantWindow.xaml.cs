using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    /// Logika interakcji dla klasy EditPlantWindow.xaml
    /// </summary>
    public partial class EditPlantWindow : Window
    {
        private PlantInfo selectedPlant;

        public EditPlantWindow(PlantInfo selectedPlant)
        {
            InitializeComponent();
            this.selectedPlant = selectedPlant;
            FillComboboxes();
            DisplayInfo(selectedPlant);
        }

        private void FillComboboxes()
        {
            for (int i = 0; i <= 50; i++)
            {
                string amount = (i * 5).ToString();
                WaterAmtCB.Items.Add($"{amount}");

            }

            for (int i = 0; i <= 31; i++)
            {
                string days = i.ToString();
                WaterDaysCB.Items.Add($"{days}");
            }
        }

        public void DisplayInfo(PlantInfo plantInfo)
        {
            nameTB.Text = plantInfo.Name;
            descTB.Text = plantInfo.Description;

            for (int i = 0; i <= 50; i++)
            {
                if (WaterAmtCB.SelectedIndex + i == plantInfo.WaterAmt/5)
                {
                    WaterAmtCB.SelectedIndex = i-1;
                }

            }
            for (int i = 0; i <= 31; i++)
            {
                if (WaterDaysCB.SelectedIndex + i == plantInfo.WaterTime)
                {
                    WaterDaysCB.SelectedIndex = i-1;
                }
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void EditPlantButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Do you confirm?", "Confiramtion", MessageBoxButton.YesNo);
            if(result == MessageBoxResult.Yes)
            {
                int waterAmt = Convert.ToInt32(WaterAmtCB.Text);
                int waterTime = Convert.ToInt32(WaterDaysCB.Text);

                selectedPlant.Name = nameTB.Text;
                selectedPlant.Description = descTB.Text;
                selectedPlant.WaterTime = waterTime;
                selectedPlant.WaterAmt = waterAmt;

                var mainWindow = (MainWindow)Owner;
                mainWindow.PlantList.Items.Refresh();
                Close();
            }
        }
    }
}
