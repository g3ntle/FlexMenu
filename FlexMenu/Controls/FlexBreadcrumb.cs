using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace FlexMenu.Controls
{
    public class FlexBreadcrumb : Button
    {
        #region Constructors

        static FlexBreadcrumb()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexBreadcrumb)
                , new FrameworkPropertyMetadata(typeof(FlexBreadcrumb)));
        }

        #endregion
    }
}
