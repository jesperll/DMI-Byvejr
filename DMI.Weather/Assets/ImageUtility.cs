﻿#region License
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
using System.IO;
using System.IO.IsolatedStorage;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Microsoft.Phone;

namespace DMI.Assets
{
    public static class ImageUtility
    {
        /// <summary>
        /// Crops the Image Borders two pixels on each side.
        /// </summary>
        /// <param name="image">The image.</param>
        public static void CropImageBorders(this Image image)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            if (image.ActualWidth > 0 && image.ActualHeight > 0)
            {
                image.Clip = new RectangleGeometry()
                {
                    Rect = new Rect(2, 2,
                        image.ActualWidth - 4,
                        image.ActualHeight - 4
                    )
                };
            }
        }

        /// <summary>
        /// Crops the Image Borders two pixels on each side.
        /// </summary>
        /// <param name="image">The image.</param>
        /// <param name="newSize">The new size.</param>
        public static void CropImageBorders(this Image image, Size newSize)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            if (image.ActualWidth > 0 && image.ActualHeight > 0 &&
                newSize.Width > 0 && newSize.Height > 0)
            {
                image.Clip = new RectangleGeometry()
                {
                    Rect = new Rect(2, 2,
                        newSize.Width - 4,
                        newSize.Height - 4
                    )
                };
            }
        }
    }
}
