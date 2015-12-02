using System.Windows;
using System.Windows.Controls;

namespace FlexMenu.Controls
{
    public class FlexBreadcrumbs : ItemsControl
    {
        static FlexBreadcrumbs()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexBreadcrumbs)
                , new FrameworkPropertyMetadata(typeof(FlexBreadcrumbs)));
        }
    }
}
