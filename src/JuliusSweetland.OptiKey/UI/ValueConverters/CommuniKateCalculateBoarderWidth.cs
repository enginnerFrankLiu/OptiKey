﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace JuliusSweetland.OptiKey.UI.ValueConverters
{
    public class CommuniKateCalculateBoarderWidth : IMultiValueConverter
    {
        public int DefaultGridLength { get; set; }
        
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            if (values == null || values.Length != 2)
            {
                return (double)8;
            }

            int i = Math.Max((int)values[0], (int)values[1]);

            if (i <= 0)
            {
                return (double)8;
            }

            return (double)72 / (i * i);
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
