﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace ITBox.Converters
{
    public class MemoryToPercentConverter : IMultiValueConverter
    {

        public object Convert(object[] memory, Type targetType, object parameter, CultureInfo culture)
        {
            if (memory[0] is double && memory[1] is double)
                return "%" + ConvertToPercentage((double)memory[0], (double)memory[1]).ToString("0.00");
            else
                return null;
        }

        public object[] ConvertBack(object value, Type[] targetType, object parameter, CultureInfo culture)
        {
            throw new Exception("not defined");
        }

        private double ConvertToPercentage(double valueToConvert, double totalMemoryInUse)
        {
            if (valueToConvert != 0 && totalMemoryInUse != 0)
                return (valueToConvert / totalMemoryInUse) * 100;
            else
                return (double)0;
        }
    }
}