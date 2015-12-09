using FlexMenu.Utility;
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
            MenuItemCommand = new RelayCommand(OnMenuItem);
            BreadcrumbCommand = new RelayCommand(OnBreadcrumb);
            LightboxOpenCommand = new RelayCommand(OnLightboxOpen);
            LightboxCloseCommand = new RelayCommand(OnLightboxClose);
        }

        #endregion


        #region Properties

        public ICommand MenuItemCommand { get; set; }
        public ICommand BreadcrumbCommand { get; set; }
        public ICommand LightboxOpenCommand { get; set; }
        public ICommand LightboxCloseCommand { get; set; }

        #endregion


        #region Methods

        protected virtual void OnMenuItem()
        {
            MessageBox.Show("You\'ve clicked a menu item!");
        }

        protected virtual void OnBreadcrumb()
        {
            MessageBox.Show("You\'ve clicked a breadcrumb!");
        }

        protected virtual void OnLightboxOpen()
        {
            FlexMenuManager.Instance.OpenLightbox();
        }

        protected virtual void OnLightboxClose()
        {
            FlexMenuManager.Instance.CloseLightbox();
        }

        #endregion
    }
}