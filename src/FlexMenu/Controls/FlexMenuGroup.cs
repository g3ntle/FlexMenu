using System;
using System.Windows;
using System.Windows.Controls;

namespace FlexMenu.Controls
{
    public class FlexMenuGroup : ItemsControl
    {
        #region Constructors

        static FlexMenuGroup()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexMenuGroup)
                , new FrameworkPropertyMetadata(typeof(FlexMenuGroup)));
        }

        #endregion

        #region Properties

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title",
            typeof(string), typeof(FlexMenuGroup), new PropertyMetadata());

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        #endregion
    }
}
