using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;

namespace FlexMenu.Controls
{
    public class FlexMenuItem : INotifyPropertyChanged
    {
        private string _text;
        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged("Text"); }
        }

        private ImageSource _icon;

        public ImageSource Icon
        {
            get { return _icon; }
            set { _icon = value; OnPropertyChanged("Icon"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
