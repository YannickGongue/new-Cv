using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace EngineeringToolsCV_1
{
    public class IconButton : Button
    {
        private static CornerRadius _defaultCornerRadius = new CornerRadius(10.0);

        static IconButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(IconButton),
               new FrameworkPropertyMetadata(typeof(IconButton)));
        }

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register(nameof(PathData), typeof(Geometry),
                   typeof(IconButton), new PropertyMetadata(Geometry.Empty));

        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static readonly DependencyProperty TextProperty = DependencyProperty.Register(nameof(Text), typeof(string),
                            typeof(IconButton), new PropertyMetadata(string.Empty));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public static readonly DependencyProperty OrientationProperty = DependencyProperty.Register(nameof(Orientation),
                                    typeof(Orientation), typeof(IconButton), new PropertyMetadata(default(Orientation)));

        public Orientation Orientation
        {
            get { return (Orientation)GetValue(OrientationProperty); }
            set { SetValue(OrientationProperty, value); }
        }

        public static readonly DependencyProperty TextVisibilityProperty = DependencyProperty.Register(nameof(TextVisibility),
                                         typeof(Visibility), typeof(IconButton), new PropertyMetadata(default(Visibility)));

        public Visibility TextVisibility
        {
            get { return (Visibility)GetValue(TextVisibilityProperty); }
            set { SetValue(TextVisibilityProperty, value); }
        }

        public static readonly DependencyProperty IconVisibilityProperty = DependencyProperty.Register(nameof(IconVisibility),
                           typeof(Visibility), typeof(IconButton), new PropertyMetadata(default(Visibility)));

        public Visibility IconVisibility
        {
            get { return (Visibility)GetValue(IconVisibilityProperty); }
            set { SetValue(IconVisibilityProperty, value); }
        }

        public static readonly DependencyProperty IconBackgroungProperty = DependencyProperty.Register(nameof(IconBackground),
                           typeof(Brush), typeof(IconButton), new PropertyMetadata(default(Brush)));
        public Brush IconBackground
        {
            get { return (Brush)GetValue(IconBackgroungProperty); }
            set { SetValue(IconBackgroungProperty, value); }
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(IconButton), new PropertyMetadata(_defaultCornerRadius));

       
    }
}
