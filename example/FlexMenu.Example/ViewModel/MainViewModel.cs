using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows;
using System.Windows.Input;

namespace FlexMenu.Example.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        #region Constructors

        public MainViewModel()
        {
            MenuItemCommand = new RelayCommand(OnMenuItemCommand);
            BreadcrumbCommand = new RelayCommand(OnBreadcrumbCommand);
            LightboxCommand = new RelayCommand(OnLightboxCommand);
        }

        #endregion


        #region Properties

        public ICommand MenuItemCommand { get; set; }
        public ICommand BreadcrumbCommand { get; set; }
        public ICommand LightboxCommand { get; set; }

        #endregion


        #region Methods

        protected virtual void OnMenuItemCommand()
        {
            MessageBox.Show("You\'ve clicked a menu item!");
        }

        protected virtual void OnBreadcrumbCommand()
        {
            MessageBox.Show("You\'ve clicked a breadcrumb!");
        }

        protected virtual void OnLightboxCommand()
        {

        }

        #endregion
    }
}