using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FlexMenu.Controls
{
    public class FlexMenuItem : Button
    {
        #region Constructors

        static FlexMenuItem()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexMenuItem)
                , new FrameworkPropertyMetadata(typeof(FlexMenuItem)));
        }

        #endregion

        #region Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon",
            typeof(ImageSource), typeof(FlexMenuItem), new PropertyMetadata());

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        #endregion
    }
}
