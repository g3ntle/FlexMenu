using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace FlexMenu.Controls
{
    public class FlexLightbox : ContentControl
    {
        #region Constructors

        static FlexLightbox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexLightbox)
                , new FrameworkPropertyMetadata(typeof(FlexLightbox)));
        }

        #endregion


        #region Properties

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title", 
            typeof(string), typeof(FlexLightbox), new PropertyMetadata());

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon",
            typeof(ImageSource), typeof(FlexLightbox), new PropertyMetadata());

        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        public static readonly DependencyProperty IsOpenProperty = DependencyProperty.Register("IsOpen",
            typeof(bool), typeof(FlexLightbox), new PropertyMetadata());

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        public static readonly DependencyProperty CommandProperty = DependencyProperty.Register("Command",
            typeof(ICommand), typeof(FlexLightbox), new PropertyMetadata());

        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        #endregion


        #region Methods

        public void Open()
        {
            IsOpen = true;
        }

        public void Close()
        {
            IsOpen = false;
        }

        public void Toggle()
        {
            IsOpen = !IsOpen;
        }

        #endregion
    }
}
