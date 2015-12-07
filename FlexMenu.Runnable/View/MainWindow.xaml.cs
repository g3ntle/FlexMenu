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
using GalaSoft.MvvmLight.Command;

namespace FlexMenu.Runnable.View
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            OpenCommand = new RelayCommand(OnOpen);
            CloseCommand = new RelayCommand(OnClose);
            InitializeComponent();
        }

        public ICommand OpenCommand { get; set; }
        public ICommand CloseCommand { get; set; }

        protected void OnOpen()
        {
            lightbox.Open();
        }

        protected void OnClose()
        {
            lightbox.Close();
        }
    }
}
