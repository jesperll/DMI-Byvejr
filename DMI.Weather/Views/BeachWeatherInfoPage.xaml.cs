﻿#region License
// Copyright (c) 2011 Claus Jørgensen <10229@iha.dk>
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE
#endregion
using System;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using DMI.Service;

namespace DMI.Views
{
    public partial class BeachWeatherInfoPage
    {
        public BeachWeatherInfoPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            string beachId = NavigationContext.TryGetStringKey("ID");
            
            if (string.IsNullOrEmpty(beachId) == false)
            {
                if (TemperatureImage != null)
                    TemperatureImage.Source = new BitmapImage(new Uri(string.Format(
                        AppSettings.TemperatureImageSource, beachId), UriKind.Absolute));

                if (WavesImage != null)
                    WavesImage.Source = new BitmapImage(new Uri(string.Format(
                        AppSettings.WavesImageSource, beachId), UriKind.Absolute));
            }
        }
    }
}