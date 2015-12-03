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
    }
}
