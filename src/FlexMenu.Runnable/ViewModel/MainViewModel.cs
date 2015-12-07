using FlexMenu.Controls;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace FlexMenu.Runnable.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ICommand _grades;
        public ICommand Grades
        {
            get { return _grades; }
            set { _grades = value; RaisePropertyChanged("Grades"); }
        }

        private ICommand _sports;
        public ICommand Sports
        {
            get { return _sports; }
            set { _sports = value; RaisePropertyChanged("Sports"); }
        }

        private ICommand _books;
        public ICommand Books
        {
            get { return _books; }
            set { _books = value; RaisePropertyChanged("Books"); }
        }

        public MainViewModel()
        {
            Populate();
        }

        protected void Populate()
        {
            Grades = new RelayCommand(OnGrades);
            Sports = new RelayCommand(OnSports);
            Books = new RelayCommand(OnBooks);
        }

        protected void OnGrades()
        {
            MessageBox.Show("Grades");
        }

        protected void OnSports()
        {
            MessageBox.Show("Sports");
        }

        protected void OnBooks()
        {
            MessageBox.Show("Books");
        }
    }
}