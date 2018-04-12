using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DYMO.Label.Framework;

namespace NaklejkaRozdzielnia
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dateTest.SelectedDate = DateTime.Now;
        }

        private void dateTest_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime dateTime = (DateTime)dateTest.SelectedDate;
            dateTest2.SelectedDate = dateTime.AddMonths(6);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var label = DYMO.Label.Framework.Label.Open("Naklejka.label");
            label.SetObjectText("DATETEST", dateTest.Text);
            label.SetObjectText("DATETEST2", dateTest2.Text);
            label.Print("DYMO LabelWriter 450");
        }
    }
}
