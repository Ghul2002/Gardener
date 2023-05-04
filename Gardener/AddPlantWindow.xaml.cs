using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Logika interakcji dla klasy AddPlantWindow.xaml
    /// </summary>
    public partial class AddPlantWindow : Window
    {
        public AddPlantWindow()
        {
            InitializeComponent();

            for (int i = 0; i <= 50; i++)
            {
                string amount = (i * 5).ToString();
                WaterAmtCB.Items.Add($"{amount} ml");

            }

            for (int i = 0; i <= 50; i++)
            {
                string days = i.ToString();
                if( i == 1 )
                {
                    WaterDaysCB.Items.Add($"{days} day");
                }
                else
                {
                    WaterDaysCB.Items.Add($"{days} days");
                }
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddPlantButton_Click(object sender, RoutedEventArgs e)
        {
            var plant = new PlantInfo(nameTB.Text, descTB.Text, WaterAmtCB.Text, WaterDaysCB.Text);
            var mainWindow = (MainWindow)Owner;
            mainWindow.AddItemToPlantList(plant);
        }
    }
}
