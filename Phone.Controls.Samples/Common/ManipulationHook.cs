﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Phone.Controls.Samples
{
    public class ManipulationHook
    {
        private UIElement _source;
        private OnManipulationCompletedHandler _callback;
        public delegate void OnManipulationCompletedHandler(ManipulationCompletedEventArgs e);

        public void Set(UIElement source, OnManipulationCompletedHandler callback)
        {
            if (null == _source)
            {
                source.ManipulationCompleted += ManipulationCompleted;
                _source = source;
                _callback = callback;
            }
        }
        public void Unset()
        {
            _source = null;
            _callback = null;
        }
        private void ManipulationCompleted(object sender, ManipulationCompletedEventArgs e)
        {
            if (null != _source)
            {
                _source.ManipulationCompleted -= ManipulationCompleted;
                _callback(e);

                Unset();
                e.Handled = true;
            }
        }
    }
}
