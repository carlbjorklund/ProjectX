﻿using ProjectX.ViewModels;
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
        private Dice Dice1;
        private Dice Dice2;
        private Dice Dice3;
        private Dice Dice4;
        private Dice Dice5;
        Random Randomator = new Random();

        public MainGameView()
        {
            InitializeComponent();
        }


    }
}
