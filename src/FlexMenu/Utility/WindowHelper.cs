using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace FlexMenu.Utility
{
    public static class WindowHelper
    {
        public static T Find<T>(DependencyObject parent) where T : DependencyObject
        {
            if (parent == null)
                return null;

            T result = null;

            int count = VisualTreeHelper.GetChildrenCount(parent);
            for(int i = 0; i < count; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);

                if (child is T)
                {
                    result = (T)child;
                    break;
                }
                else
                {
                    result = Find<T>(child);

                    if (result != null)
                        break;
                }
            }

            return result;
        }

        public static Window GetActiveWindow()
        {
            return Application.Current.Windows
                .OfType<Window>()
                .SingleOrDefault(o => o.IsActive);
        }
    }
}
