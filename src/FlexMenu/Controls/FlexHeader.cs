using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FlexMenu.Media;

namespace FlexMenu.Controls
{
    public class FlexHeader : ContentControl
    {
        static FlexHeader()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(FlexHeader), new FrameworkPropertyMetadata(typeof(FlexHeader)));
        }

        #region Icon

        public static readonly DependencyProperty IconProperty = DependencyProperty.Register("Icon",
            typeof(ImageSource), typeof(FlexHeader), new PropertyMetadata());

        [Bindable(true), Category("Appearance")]
        public ImageSource Icon
        {
            get { return (ImageSource)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }

        #endregion

        #region Title

        public static readonly DependencyProperty TitleProperty = DependencyProperty.Register("Title",
            typeof(string), typeof(FlexHeader), new PropertyMetadata());

        [Bindable(true), Category("Common")]
        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        #endregion

        #region Subtitle

        public static readonly DependencyProperty SubtitleProperty = DependencyProperty.Register("Subtitle",
            typeof(string), typeof(FlexHeader), new PropertyMetadata());

        [Bindable(true), Category("Common")]
        public string Subtitle
        {
            get { return (string)GetValue(SubtitleProperty); }
            set { SetValue(SubtitleProperty, value); }
        }

        #endregion

        #region TitleWidth

        public static readonly DependencyProperty TitleWidthProperty = DependencyProperty.Register("TitleWidth",
            typeof(GridLength), typeof(FlexHeader), new PropertyMetadata(GridLength.Auto));

        [Bindable(true), Category("Appearance")]
        public GridLength TitleWidth
        {
            get { return (GridLength)GetValue(TitleWidthProperty); }
            set { SetValue(TitleWidthProperty, value); }
        }

        #endregion

        #region SubtitleWidth

        public static readonly DependencyProperty SubtitleWidthProperty = DependencyProperty.Register("SubtitleWidth",
            typeof(GridLength), typeof(FlexHeader), new PropertyMetadata(GridLength.Auto));

        [Bindable(true), Category("Appearance")]
        public GridLength SubtitleWidth
        {
            get { return (GridLength)GetValue(SubtitleWidthProperty); }
            set { SetValue(SubtitleWidthProperty, value); }
        }

        #endregion

        #region TitleBackground

        public static readonly DependencyProperty TitleBackgroundProperty = DependencyProperty.Register("TitleBackground",
            typeof(Brush), typeof(FlexHeader), new PropertyMetadata(FlexBrushes.DarkGreen));

        [Bindable(true), Category("Appearance")]
        public Brush TitleBackground
        {
            get { return (Brush)GetValue(TitleBackgroundProperty); }
            set { SetValue(TitleBackgroundProperty, value); }
        }

        #endregion

        #region SubtitleBackground

        public static readonly DependencyProperty SubtitleBackgroundProperty = DependencyProperty.Register("SubtitleBackground",
            typeof(Brush), typeof(FlexHeader), new PropertyMetadata(FlexBrushes.LightGreen));

        [Bindable(true), Category("Appearance")]
        public Brush SubtitleBackground
        {
            get { return (Brush)GetValue(SubtitleBackgroundProperty); }
            set { SetValue(SubtitleBackgroundProperty, value); }
        }

        #endregion
    }
}
