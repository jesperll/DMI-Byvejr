#region License
// Copyright (c) 2011 Claus Jørgensen <thedeathart@gmail.com>
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
using System.Windows;
using System.Windows.Controls;

namespace DMI.Assets
{
    public class DataTemplateSelector : ContentControl
    {
        /// <summary>
        /// Selects the template.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <param name="container">The container.</param>
        /// <returns></returns>
        public virtual DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Called when the value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property changes.
        /// </summary>
        /// <param name="oldContent">
        ///     The old value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.
        /// </param>
        /// <param name="newContent">
        ///     The new value of the <see cref="P:System.Windows.Controls.ContentControl.Content"/> property.
        /// </param>
        protected override void OnContentChanged(object oldContent, object newContent)
        {
            base.OnContentChanged(oldContent, newContent);

            ContentTemplate = SelectTemplate(newContent, this);
        }
    }
}
