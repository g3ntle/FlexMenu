using System.Collections.Generic;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;

namespace FlexMenu.Controls
{
    public class FlexMenu : ItemsControl
    {
        static FlexMenu()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexMenu)
                , new FrameworkPropertyMetadata(typeof(FlexMenu)));
        }
    }
}
