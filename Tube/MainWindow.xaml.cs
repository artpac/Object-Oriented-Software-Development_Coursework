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

namespace Tube
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Declaring underground class
        Underground underground = new Underground();
        Underground undergroundTest = new Underground();

        public MainWindow()
        {

            InitializeComponent();
        }

        //Test button, Creating 5 station classes and adding them to underground and outputting to textbox after click
        private void testButton_Click(object sender, RoutedEventArgs e)
        {
            

            Station s1 = new Station("a", "A", 2);
            Station s2 = new Station("b", "B", 3);
            Station s3 = new Station("c", "C", 4);
            Station s4 = new Station("d", "D", 5);
            Station s5 = new Station("e", "E", 6);
            undergroundTest.AddStation(s1);
            undergroundTest.AddStation(s2);
            undergroundTest.AddStation(s3); 
            undergroundTest.AddStation(s4); 
            undergroundTest.AddStation(s5);

            txtOutput.Text = undergroundTest.ToString();

        }

        
        //Load Button, Adds each station's name, id, and zone to a station then adds the station to underground
        private void loadStations_Click(object sender, RoutedEventArgs e)
        {

            CSVReader reader = new CSVReader("F:\\Uni\\Year 2\\C#\\Coursework 2\\Tube\\bin\\Stations.csv");
            foreach (String[] line in reader.ReadFile())
            {
             Station station = new Station(line[1], line[0], int.Parse(line[2]));
                
             underground.AddStation(station);

            }
        }

        //Find Button, Input id of station to find and click button to find that station
        private void findStation_Click(object sender, RoutedEventArgs e)
        {
            
            txtOutput.Text = (underground.find(txtToFind.Text));

        }
    }
}
