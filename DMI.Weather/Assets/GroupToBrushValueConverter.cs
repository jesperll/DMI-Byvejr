﻿#region License
// Copyright (c) Microsoft Corporation
//
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993 for details.
// All other rights reserved.
#endregion
using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using DMI.Model;

namespace DMI.Assets
{
    public class GroupToBrushValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null && value is CityGroup)
            {
                var group = value as CityGroup;

                if (group.Count == 0)
                    return (SolidColorBrush)Application.Current.Resources["PhoneChromeBrush"];
                else
                    return (SolidColorBrush)Application.Current.Resources["PhoneAccentBrush"];
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}