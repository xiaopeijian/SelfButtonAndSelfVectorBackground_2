﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SelfButtonAndSelfVectorBackground_2
{
    class ImageButton : System.Windows.Controls.Button
    {
        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("ButtonImage", typeof(string), typeof(FrameworkElement));


        static ImageButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ImageButton), new FrameworkPropertyMetadata(typeof(ImageButton)));
        }

        public string Text
        {
            set
            {
                SetValue(TextProperty, value);
            }
            get
            {
                return (string)GetValue(TextProperty);
            }
        }
    }
}
