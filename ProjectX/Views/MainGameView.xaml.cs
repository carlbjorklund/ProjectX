using ProjectX.Models;
using ProjectX.ViewModels;
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

namespace ProjectX.Views
{
    /// <summary>
    /// Interaction logic for MainGameView.xaml
    /// </summary>
    public partial class MainGameView : UserControl

    {
        GameSetEngine gameSet = new GameSetEngine();
       
        Random r = new Random();
        public MainGameView()
        {
            InitializeComponent();
       

        }

        private void Rolldice_Click(object sender, RoutedEventArgs e)
        {
            Dice dice1 = new Dice();
            int value;
            value = r.Next(1, 7);
            dice1.DiceValue = value;
            gameSet.DicePanel.Dice1.DiceValue = value;
            gameSet._gameName = "Fuck";
            DateTime today = DateTime.Today;
            gameSet.Started_At = today;

          
        }
    }
}
