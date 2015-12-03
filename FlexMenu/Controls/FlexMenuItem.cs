using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FlexMenu.Controls
{
    public class FlexMenuItem : INotifyPropertyChanged
    {
        private string _text;

        [Bindable(true), Category("Common")]
        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged("Text"); }
        }

        private ImageSource _icon;

        [Bindable(true), Category("Appearance")]
        public ImageSource Icon
        {
            get { return _icon; }
            set { _icon = value; OnPropertyChanged("Icon"); }
        }

        private bool _active = false;

        [Bindable(true), Category("Data")]
        public bool Active
        {
            get { return _active; }
            set { _active = value; OnPropertyChanged("Active"); }
        }

        private ICommand _command;

        [Bindable(true), Category("Data")]
        public ICommand Command
        {
            get { return _command; }
            set { _command = value; OnPropertyChanged("Command"); }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
