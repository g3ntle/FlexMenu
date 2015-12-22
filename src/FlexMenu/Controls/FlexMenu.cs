using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace FlexMenu.Controls
{
    public class FlexMenu : ItemsControl
    {
        #region Constructors

        static FlexMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexMenu)
                , new FrameworkPropertyMetadata(typeof(FlexMenu)));
        }

        #endregion


        #region Properties

        public static readonly DependencyProperty PrependProperty = DependencyProperty.Register("Prepend"
            , typeof(FrameworkElement), typeof(FlexMenu), new PropertyMetadata());

        public FrameworkElement Prepend
        {
            get { return (FrameworkElement)GetValue(PrependProperty); }
            set { SetValue(PrependProperty, value); }
        }

        public static readonly DependencyProperty AppendProperty = DependencyProperty.Register("Append"
            , typeof(FrameworkElement), typeof(FlexMenu), new PropertyMetadata());

        public FrameworkElement Append
        {
            get { return (FrameworkElement)GetValue(AppendProperty); }
            set { SetValue(AppendProperty, value); }
        }

        #endregion
    }
}
