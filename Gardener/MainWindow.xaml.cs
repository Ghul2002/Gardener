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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gardener
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            PlantList.DisplayMemberPath = "Name";
            DateTime date = new DateTime(2023, 05, 02);
            PlantInfo TestPlant = new PlantInfo("TestPlant", "Lubie piwo", 25, 4, date);
            PlantList.Items.Add(TestPlant);
        }

        public void AddItemToPlantList(PlantInfo plant)
        {
            PlantList.Items.Add(plant);
        }

        private void AddPlantBT_Click(object sender, RoutedEventArgs e)
        {
            var addWin = new AddPlantWindow();
            addWin.Owner = this;
            addWin.ShowDialog();
        }

        private void CheckPlantBT_Click(object sender, RoutedEventArgs e)
        {
            if (PlantList.SelectedIndex != -1)
            {
                CheckPlantWindow checkWin = new CheckPlantWindow((PlantInfo)PlantList.SelectedItem);
                checkWin.Owner = this;
                checkWin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a plant first!");
            }
        }

        private void EditPlantBT_Click(object sender, RoutedEventArgs e)
        {
            if (PlantList.SelectedIndex != -1)
            {
                EditPlantWindow editWin = new EditPlantWindow((PlantInfo)PlantList.SelectedItem);
                editWin.Owner = this;
                editWin.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a plant first!");
            }
        }

        private void DeleteBT_Click(object sender, RoutedEventArgs e)
        {
            if (PlantList.SelectedIndex != -1)
            {
                MessageBoxResult result = MessageBox.Show("Do you confirm?", "Confiramtion", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    PlantList.Items.Remove(PlantList.SelectedItem);
                }
            }
        }
    }
}
