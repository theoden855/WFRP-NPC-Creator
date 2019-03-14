﻿using System;
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

namespace WFRP_NPC_Creator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CareerJsonReader.read = true;
            TalentReader.read = true;

            Character Test = new Human();

            Test.AddCareer("Servant", AdvanceLevel.Complete);
            Test.AddCareer("Advisor", AdvanceLevel.Complete);
            Test.AddCareer("Wizard's Apprentice", AdvanceLevel.Complete);
            Test.AddCareer("Wizard", AdvanceLevel.Complete);
            Test.AddCareer("Master Wizard", AdvanceLevel.Beyond);


            Test.PrintToConsole(false);
            Test.PrintToConsole(true);


        }
    }
}
