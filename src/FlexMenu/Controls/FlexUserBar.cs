using System;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace FlexMenu.Controls
{
    public class FlexUserBar : Button
    {
        #region Constructors

        static FlexUserBar()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexUserBar)
                , new FrameworkPropertyMetadata(typeof(FlexUserBar)));

            // Image
            var img = new BitmapImage();
            img.BeginInit();
            img.UriSource = new Uri("pack://application:,,,/FlexMenu;component/Resources/Bill.jpg");
            img.EndInit();

            IconProperty.OverrideMetadata(typeof(FlexUserBar)
                , new FrameworkPropertyMetadata(img));
        }

        #endregion


        #region Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon",
            typeof(ImageSource), typeof(FlexUserBar));

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        #endregion
    }
}
