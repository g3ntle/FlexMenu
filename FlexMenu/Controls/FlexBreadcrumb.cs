using System;
using System.ComponentModel;
using System.Windows.Input;

namespace FlexMenu.Controls
{
    public class FlexBreadcrumb : INotifyPropertyChanged
    {
        private string _text;

        [Bindable(true), Category("Common")]
        public string Text
        {
            get { return _text; }
            set { _text = value; OnPropertyChanged("Text"); }
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
