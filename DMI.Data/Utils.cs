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
using System.Text;
using System.Collections.Generic;

namespace DMI.Data
{
    public static class Utils
    {
        public static string ParsePollenData(string data)
        {
            if (string.IsNullOrEmpty(data))
                throw new ArgumentException("Argument 'data' cannot be null or empty.");

            string input = data.Replace("\n", "").Replace(" ", "");

            var result = new StringBuilder();

            string[] parts = input.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var part in parts)
            {
                var partValues = part.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                if ((partValues.Length == 2) && (partValues[1] != "-"))
                    result.AppendFormat("{0}: {1} , ", partValues[0], partValues[1]);
            }

            string output = result.ToString();

            if (string.IsNullOrEmpty(output) == false && output.Length >= 4)
                output = output.Substring(0, output.Length - 3);

            return output;
        }
    }
}
