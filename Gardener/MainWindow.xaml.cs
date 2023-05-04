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
        }

        public void AddItemToPlantList(PlantInfo plant)
        {
            PlantList.Items.Add(plant);
        }

        private void AddPlantBT_Click(object sender, RoutedEventArgs e)
        {
            AddPlantWindow addWin = new AddPlantWindow();
            addWin.Owner = this;
            addWin.ShowDialog();
        }
    }
}
