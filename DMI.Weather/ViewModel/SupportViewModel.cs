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
using System.IO.IsolatedStorage;
using System.Windows.Input;
using System.Xml.Linq;
using DMI.Properties;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.Phone.Tasks;

namespace DMI.ViewModel
{
    public class SupportViewModel : ViewModelBase
    {
        public SupportViewModel()
        {
            this.OpenMailClient = new RelayCommand(OpenMailClientExecute);
            this.OK = new RelayCommand(OKExecute);
        }

        public string Version
        {
            get
            {
                return XDocument.Load("WMAppManifest.xml").Root
                    .Element("App")
                    .Attribute("Version").Value;
            }
        }

        public bool AllowGPS
        {
            get
            {
                if (IsolatedStorageSettings.ApplicationSettings.Contains(App.ToggleGPS))
                {
                    return (bool)IsolatedStorageSettings.ApplicationSettings[App.ToggleGPS];
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (!IsolatedStorageSettings.ApplicationSettings.Contains(App.ToggleGPS))
                {
                    IsolatedStorageSettings.ApplicationSettings.Add(App.ToggleGPS, value);
                }
                else
                {
                    IsolatedStorageSettings.ApplicationSettings[App.ToggleGPS] = value;
                }

                IsolatedStorageSettings.ApplicationSettings.Save();
            }
        }

        public ICommand OpenMailClient
        {
            get;
            private set;
        }

        public ICommand OK
        {
            get;
            private set;
        }

        private void OKExecute()
        {
            App.GoBack();
        }

        private void OpenMailClientExecute()
        {
            var emailTask = new EmailComposeTask()
            {
                To = "10229@iha.dk",
                Subject = AppResources.AppTitleSmall + " Support"
            };

            emailTask.Show();
        }
    }
}