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
                WaterAmtCB.Items.Add($"{amount}");

            }

            for (int i = 0; i <= 31; i++)
            {
                string days = i.ToString();
                WaterDaysCB.Items.Add($"{days}");
            }
        }

        private void BackBT_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AddPlantButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameTB.Text == "") 
            {
                MessageBox.Show("Add name!");       
            }
            else
            {
                int waterAmt = Convert.ToInt32(WaterAmtCB.Text);
                int waterTime = Convert.ToInt32(WaterDaysCB.Text);
                DateTime addTime = DateTime.Now;
                var plant = new PlantInfo(nameTB.Text, descTB.Text, waterAmt, waterTime, addTime);
                var mainWindow = (MainWindow)Owner;
                mainWindow.AddItemToPlantList(plant);
                Close();
            }
        }
    }
}
