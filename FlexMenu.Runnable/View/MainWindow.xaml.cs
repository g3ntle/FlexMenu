using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using FlexMenu.Controls;

namespace FlexMenu.Runnable.View
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<FlexMenuItem> MenuItems { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Fill();
        }

        protected void Fill()
        {
            var menuItems = new FlexMenuItem[]
            {
                new FlexMenuItem() { Text = "#1 Hello, World!" },
                new FlexMenuItem() { Text = "#2 Hello, Home!" },
                new FlexMenuItem() { Text = "#3 Hello, Shop!" }
            };

            MenuItems = new ObservableCollection<FlexMenuItem>(menuItems);
            DataContext = this;
        }
    }
}
